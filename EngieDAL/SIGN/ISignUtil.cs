using Engie.DTO;
using eSAW;
using System.Xml;

namespace EngieDAL
{
    public interface ISignUtil
    {
        string[] UploadPdfsAndGetDocIds(ApiSoapClient ws, string authXml, string[] documentPaths);
        XmlDocument FormatedXmlNotaInformativa(EngieNotaInformatiovaDataDto engieData, string xmlOverrideOptionTests);
        XmlDocument FormatedXmlContractEngie(CtrEngieDataDTO engieData, string xmlOverrideOptionTests);
    }
}