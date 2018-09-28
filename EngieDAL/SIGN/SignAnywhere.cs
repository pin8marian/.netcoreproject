using Engie.DTO;
using Engie.Standard;
using EngiePOC.DTO;
using eSAW;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EngieDAL
{
    public class SignAnywhere : ISignAnywhere
    {
        protected AppSettings _appConfiguration;

        protected ISignUtil _signUtil;
        public SignAnywhere(IOptions<AppSettings> appConfiguration, ISignUtil signUtil)
        {
            _appConfiguration = appConfiguration.Value;
            _signUtil = signUtil;
        }

        public async Task<List<string>> GetEnvelopeByIdCreateWorkStepId(EngieNotaInformatiovaDataDto engieData)
        {
            var returnUrlsLinks = new List<string>();
            try
            {
                string xmlOverrideOptionTests = File.ReadAllText(_appConfiguration.NotaVerificareSignConfig);

                var documentc = _signUtil.FormatedXmlNotaInformativa(engieData, xmlOverrideOptionTests);

                var ws = GetSawWebService.eSawWebService(_appConfiguration.eSawUrlBeta3);

                if (ws != null)
                {

                    string[] documentsPath = new string[] { _appConfiguration.NotaVerificareFormPdf };
                    string[] docIds = _signUtil.UploadPdfsAndGetDocIds(ws, Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), documentsPath);

                    string sendEnvelopeResponseXml = ws.SendEnvelope_v1Async(Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), docIds, documentc.InnerXml).GetAwaiter().GetResult();

                    SignAnywhereResponse response = SignAnywhereResponse.parseResponse(sendEnvelopeResponseXml);
                    if (response.BaseResult == SignAnywhereResponse.Result.Failed)
                    {
                        returnUrlsLinks.Add(response.ErrorMsg);
                        return returnUrlsLinks;
                    }
                    var envelopeId = response.okInfo.InnerText;

                    var getEnvelopeByIdResponse = ws.GetEnvelopeById_v1Async(Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), envelopeId).GetAwaiter().GetResult();

                    var linkUrl = Util.ExtractXmlValue("/apiResult/okInfo/envelopeStatus/bulkRecipients/bulkRecipient/recipients/recipient/workstepRedirectionUrl", getEnvelopeByIdResponse);

                    if (string.IsNullOrEmpty(linkUrl))
                    {
                        returnUrlsLinks.Add("Error extracting the xml node value");
                        return returnUrlsLinks;
                    }

                    //the urllink like this
                    //https://beta3.testlab.xyzmo.com/saw/SignAnyWhere.aspx?WorkstepId=2632166D6CE3D58D992A024A7D2FDCFC51AA52FC4201EAA8F1158BB361BEE0B6E0CFBEF308D02E8D536F4A253C33117A&setLng=en
                    string webLinkUrl = Util.GetWebRedirectedUri(linkUrl);

                    if (!string.IsNullOrEmpty(webLinkUrl))
                    {
                        var workStepId = webLinkUrl.Split("=")[1].Split("&").First();

                        if (!string.IsNullOrEmpty(workStepId))
                        {
                            var androidLink = string.Format(_appConfiguration.AndroidLinkTemplate, workStepId);
                            returnUrlsLinks.Add(webLinkUrl);
                            returnUrlsLinks.Add(androidLink);
                        }
                    }
                }
                return returnUrlsLinks;
            }
            catch (Exception ex)
            {
                returnUrlsLinks.Add(ex.Message);
                return returnUrlsLinks;
            }
        }

        public List<string> SendToSign_NVR(EngieNotaInformatiovaDataDto d)
        {
            return GetEnvelopeByIdCreateWorkStepId(d).GetAwaiter().GetResult();
        }

        public List<string> SendToSign_CTR(CtrEngieDataDTO d)
        {
            var returnUrlsLinks = new List<string>();
            try
            {
                string xmlOverrideOptionTests = File.ReadAllText(_appConfiguration.ContractElSignConfig);

                var documentc = _signUtil.FormatedXmlContractEngie(d, xmlOverrideOptionTests);

                var ws = GetSawWebService.eSawWebService(_appConfiguration.eSawUrlBeta3);

                if (ws != null)
                {
                    string[] documentsPath = new string[] { _appConfiguration.ContractFormPdf };
                    string[] docIds = _signUtil.UploadPdfsAndGetDocIds(ws, Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), documentsPath);

                    string sendEnvelopeResponseXml = ws.SendEnvelope_v1Async(Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), docIds, documentc.InnerXml).GetAwaiter().GetResult();

                    SignAnywhereResponse response = SignAnywhereResponse.parseResponse(sendEnvelopeResponseXml);
                    if (response.BaseResult == SignAnywhereResponse.Result.Failed)
                    {
                        returnUrlsLinks.Add(response.ErrorMsg);
                        return returnUrlsLinks;
                    }
                    var envelopeId = response.okInfo.InnerText;

                    var getEnvelopeByIdResponse = ws.GetEnvelopeById_v1Async(Util.GetApiAuthorization(_appConfiguration.OrganizationKeyBeta3, _appConfiguration.UserAccountName), envelopeId).GetAwaiter().GetResult();

                    var linkUrl = Util.ExtractXmlValue("/apiResult/okInfo/envelopeStatus/bulkRecipients/bulkRecipient/recipients/recipient/workstepRedirectionUrl", getEnvelopeByIdResponse);

                    if (string.IsNullOrEmpty(linkUrl))
                    {
                        returnUrlsLinks.Add("Error extracting the xml node value");
                        return returnUrlsLinks;
                    }

                    //the urllink like this
                    //https://beta3.testlab.xyzmo.com/saw/SignAnyWhere.aspx?WorkstepId=2632166D6CE3D58D992A024A7D2FDCFC51AA52FC4201EAA8F1158BB361BEE0B6E0CFBEF308D02E8D536F4A253C33117A&setLng=en
                    string webLinkUrl = Util.GetWebRedirectedUri(linkUrl);

                    if (!string.IsNullOrEmpty(webLinkUrl))
                    {
                        var workStepId = webLinkUrl.Split("=")[1].Split("&").First();

                        if (!string.IsNullOrEmpty(workStepId))
                        {
                            var androidLink = string.Format(_appConfiguration.AndroidLinkTemplate, workStepId);
                            returnUrlsLinks.Add(webLinkUrl);
                            returnUrlsLinks.Add(androidLink);
                        }
                    }
                }
                return returnUrlsLinks;
            }
            catch (Exception ex)
            {
                returnUrlsLinks.Add(ex.Message);
                return returnUrlsLinks;
            }
        }
    }
}
