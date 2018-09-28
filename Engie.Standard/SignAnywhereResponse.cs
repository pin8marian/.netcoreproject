using System;
using System.Xml;

namespace Engie.Standard
{
    public class SignAnywhereResponse
    {
        public enum Result { Ok, Failed }

        public Result BaseResult;
        public XmlElement okInfo;
        public string Error;
        public string ErrorMsg;
        public string SupportId;
        public static SignAnywhereResponse parseResponse(string xmlResponse)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlResponse);

                SignAnywhereResponse response = new SignAnywhereResponse();

                if (xmlDoc.DocumentElement.SelectSingleNode("baseResult").InnerText.ToLower() == "ok")
                {
                    response.BaseResult = Result.Ok;
                    response.okInfo = (XmlElement)xmlDoc.DocumentElement.SelectSingleNode("okInfo");
                }
                else
                {
                    response.BaseResult = Result.Failed;
                    response.Error = xmlDoc.DocumentElement.SelectSingleNode("errorInfo").SelectSingleNode("error").InnerText;
                    response.ErrorMsg = xmlDoc.DocumentElement.SelectSingleNode("errorInfo").SelectSingleNode("errorMsg").InnerText;
                    response.SupportId = xmlDoc.DocumentElement.SelectSingleNode("errorInfo").SelectSingleNode("supportId").InnerText;

                }

                return response;

            }
            catch (Exception ex)
            {
                throw new Exception("Error on parsing response from SignAnywhere:" + Environment.NewLine + xmlResponse, ex);
            }
        }

    }
}
