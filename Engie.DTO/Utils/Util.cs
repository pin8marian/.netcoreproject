using System;
using System.Net;
using System.Xml;

namespace Engie.DTO
{
    public static class Util
    {
        public static string GetApiAuthorization(string OrganizationKeyBeta3, string UserAccountName)
        {
            string authorisationXml = "<authorization><organizationKey>##OrgKey##</organizationKey><userLoginName>##UserLoginName##</userLoginName></authorization>";

            authorisationXml = authorisationXml.Replace("##OrgKey##", OrganizationKeyBeta3);
            authorisationXml = authorisationXml.Replace("##UserLoginName##", UserAccountName);

            return authorisationXml;
        }

        public static string GetWebRedirectedUri(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            return response.ResponseUri.AbsoluteUri;
        }

        public static string ExtractXmlValue(string path, string xmlString)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);
                return xmlDoc.DocumentElement.SelectSingleNode(path).InnerText;
            }
            catch (Exception ex)
            {
                throw new Exception("Error on parsing response from SignAnywhere:" + Environment.NewLine + xmlString + Environment.NewLine + "path: " + Environment.NewLine + path, ex);
            }
        }

    }
}
