using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTService.WinForm
{
    [ServiceContract]
    public interface IEMICalculator
    {
        [OperationContract, WebInvoke(UriTemplate = "/emi", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        double emi(double amount, int period, double rate);
    }
}
