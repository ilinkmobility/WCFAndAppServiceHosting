using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Background;
using Windows.Foundation.Collections;

namespace EMICalculator.AppService
{
    public sealed class AppServiceTask : IBackgroundTask
    {
        BackgroundTaskDeferral serviceDeferral;
        AppServiceConnection connection;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            //Take a service deferral so the service isn't terminated
            serviceDeferral = taskInstance.GetDeferral();

            taskInstance.Canceled += OnTaskCanceled;
            
            var details = taskInstance.TriggerDetails as AppServiceTriggerDetails;
            connection = details.AppServiceConnection;

            //Listen for incoming app service requests
            connection.RequestReceived += OnRequestReceived;
        }

        private void OnTaskCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            if (serviceDeferral != null)
            {
                //Complete the service deferral
                serviceDeferral.Complete();
                serviceDeferral = null;
            }

            if (connection != null)
            {
                connection.Dispose();
                connection = null;
            }
        }

        async void OnRequestReceived(AppServiceConnection sender, AppServiceRequestReceivedEventArgs args)
        {
            //Get a deferral so we can use an awaitable API to respond to the message
            var messageDeferral = args.GetDeferral();

            try
            {
                var input = args.Request.Message;
                double amount = Convert.ToDouble(input["amount"].ToString());
                int period = Convert.ToInt32(input["period"].ToString());
                double rate = Convert.ToDouble(input["rate"].ToString());

                //Create the response
                var result = new ValueSet
                {
                    { "status", "OK" },
                    { "result", CalculateEMI(amount, period, rate) }
                };

                //Send the response
                await args.Request.SendResponseAsync(result);
            }
            finally
            {
                //Complete the message deferral so the platform knows we're done responding
                messageDeferral.Complete();
            }
        }

        string CalculateEMI(double amount, int period, double rate)
        {
            try
            {
                //Principale amount.
                var A = amount;

                //Number of Periodic Payments(N) = Payments per year times number of years.
                var N = period * 12;

                //Periodic Interest Rate(I) = Annual rate divided by number of payments per year.
                var I = ((float)rate / 100) / 12;

                //X = {[(1 + i) ^n] - 1}.
                var X = Math.Pow(1 + I, N) - 1;
                //Y = [i(1 + i)^n].
                var Y = Math.Pow(1 + I, N) * I;

                //Discount Factor (D) = {[(1 + i) ^n] - 1} / [i(1 + i)^n].
                var D = X / Y;

                //Loan Payment = Amount (A)/ Discount Factor(D).
                var P = A / D;

                return Math.Round(P, 2).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
