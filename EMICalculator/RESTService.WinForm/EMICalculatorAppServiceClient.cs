using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.AppService;
using Windows.Foundation.Collections;

namespace RESTService.WinForm
{
    public class EMICalculatorAppServiceClient : IEMICalculator
    {
        public double emi(double amount, int period, double rate)
        {
            double result = 0;

            try
            {
                AppServiceConnectionStatus status = AppServiceConnectionStatus.Unknown;
                AppServiceResponse response = null;

                var connection = new AppServiceConnection
                {
                    AppServiceName = "com.ilink-systems.emi",
                    PackageFamilyName = "f39a492b-4169-44ea-95e0-684611551b3b_y1rwc9yf20874"
                };

                Task.Run(async () => { status = await connection.OpenAsync(); }).Wait();

                if (status == AppServiceConnectionStatus.Success)
                {
                    var inputs = new ValueSet
                    {
                        { "amount", amount },
                        { "period", period },
                        { "rate", rate }
                    };

                    MainForm.SetRequestMessage(JsonConvert.SerializeObject(inputs));

                    Task.Run(async () => { response = await connection.SendMessageAsync(inputs); }).Wait();

                    if (response != null && response.Status == AppServiceResponseStatus.Success && response.Message.ContainsKey("result"))
                    {
                        result = Math.Ceiling(Convert.ToDouble(response.Message["result"].ToString()));
                        MainForm.SetResponseMessage(result.ToString());
                    }
                }
            }
            catch (Exception)
            {
                result = -2;
            }

            MainForm.SetLastServed(DateTime.Now.ToString());

            return result;
        }
    }
}
