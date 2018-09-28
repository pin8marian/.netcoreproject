using System;
using System.Xml;

namespace Engie.Standard
{
    public class SignAnywhereFile
    {
        public string FileName;
        public byte[] Data;

        public static SignAnywhereFile FromXmlElement(XmlElement fileXmlElem)
        {
            SignAnywhereFile file = new SignAnywhereFile();
            if (fileXmlElem != null)
            {
                file.FileName = fileXmlElem.SelectSingleNode("name").InnerText;
                file.Data = Convert.FromBase64String(fileXmlElem.SelectSingleNode("data").InnerText);
            }
            return file;
        }

        public string ToXml()
        {
            const string docXmlTemplate = "<file><data>##fileContent##</data><name>##filename##</name></file>";

            string docXml = docXmlTemplate.Replace("##filename##", this.FileName);
            docXml = docXml.Replace("##fileContent##", Convert.ToBase64String(this.Data));

            return docXml;
        }
    }
}
