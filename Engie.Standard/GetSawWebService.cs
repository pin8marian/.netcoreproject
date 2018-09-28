using eSAW;
using System.IO;

namespace Engie.Standard
{
    public class GetSawWebService
    {  
        public static ApiSoapClient eSawWebService(string eSawUrl)
        {
            return new ApiSoapClient(ApiSoapClient.EndpointConfiguration.ApiSoap12, eSawUrl + "/api.asmx");

        }
    }
}
