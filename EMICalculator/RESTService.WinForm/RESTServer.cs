using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTService.WinForm
{
    public class RESTServer
    {
        private RESTServer()
        {
        }

        private static RESTServer instance = null;

        public static RESTServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RESTServer();
                }

                return instance;
            }
        }

        public void StartService()
        {
            try
            {
                string baseAddress = "http://localhost:80/Temporary_Listen_Addresses/EMICalculator";
                WebServiceHost host = new WebServiceHost(typeof(EMICalculatorAppServiceClient), new Uri(baseAddress));
                host.Open();
            }
            catch (Exception)
            {
            }
        }
    }
}
