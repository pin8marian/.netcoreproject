﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSAW
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.eSignAnyWhere.com/", ConfigurationName="eSAW.ApiSoap")]
    public interface ApiSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/UploadTemporarySspFile_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UploadTemporarySspFile_v1Async(string authorizationXml, string fileXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/DisposeSspFile_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> DisposeSspFile_v1Async(string authorizationXml, string sspFileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/GetAdHocWorkstepConfiguration_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetAdHocWorkstepConfiguration_v1Async(string authorizationXml, string[] sspFileIds, string adHocWorkstepConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/PrepareSendEnvelopeSteps_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> PrepareSendEnvelopeSteps_v1Async(string authorizationXml, string[] sspFileIds, string adHocWorkstepConfiguration, string prepareSendEnvelopeStepsDescriptor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/DownloadCompletedDocument_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> DownloadCompletedDocument_v1Async(string authorizationXml, string envelopeId, string documentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/GetEnvelopeById_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetEnvelopeById_v1Async(string authorizationXml, string envelopeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/FindEnvelopes_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> FindEnvelopes_v1Async(string authorizationXml, string findEnvelopesDescriptorXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/FindEnvelopes_v2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> FindEnvelopes_v2Async(string authorizationXml, string findEnvelopesDescriptorXml, string resultFormat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/SendEnvelope_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendEnvelope_v1Async(string authorizationXml, string[] sspFileIds, string envelopeDescriptionXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/SendEnvelopeFromTemplate_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendEnvelopeFromTemplate_v1Async(string authorizationXml, string templateId, string overrideOptionsXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/SendReminders_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendReminders_v1Async(string authorizationXml, string envelopeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/DeleteEnvelope_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> DeleteEnvelope_v1Async(string authorizationXml, string envelopeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/CancelEnvelope_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> CancelEnvelope_v1Async(string authorizationXml, string envelopeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/NotifyEnvelopeWorkstepIsCompleted_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> NotifyEnvelopeWorkstepIsCompleted_v1Async(string authorizationXml, string envelopeId, string workstepId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/RestartEnvelope_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> RestartEnvelope_v1Async(string authorizationXml, string envelopeId, int expirationInDays);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/ReplaceRecipient_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> ReplaceRecipient_v1Async(string authorizationXml, string envelopeId, string recipientOverrideXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/DeleteRecipient_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> DeleteRecipient_v1Async(string authorizationXml, string envelopeId, string recipientLookupXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/CreateDraft_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> CreateDraft_v1Async(string authorizationXml, string[] sspFileIds, string envelopeDescriptionXml, string draftOptionsXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/CreateDraftFromTemplate_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> CreateDraftFromTemplate_v1Async(string authorizationXml, string templateId, string overrideOptionsXml, string draftOptionsXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/UploadUserFile_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UploadUserFile_v1Async(string userToken, string flowFileXml, string senderApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/DownloadEnvelopePageImage_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> DownloadEnvelopePageImage_v1Async(string authorizationXml, string envelopeId, string docRefNumber, string pageNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/GetVersion_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetVersion_v1Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.eSignAnyWhere.com/ValidateAuthorization_v1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> ValidateAuthorization_v1Async(string authorizationXml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface ApiSoapChannel : eSAW.ApiSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ApiSoapClient : System.ServiceModel.ClientBase<eSAW.ApiSoap>, eSAW.ApiSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ApiSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ApiSoapClient.GetBindingForEndpoint(endpointConfiguration), ApiSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApiSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ApiSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApiSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ApiSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ApiSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> UploadTemporarySspFile_v1Async(string authorizationXml, string fileXml)
        {
            return base.Channel.UploadTemporarySspFile_v1Async(authorizationXml, fileXml);
        }
        
        public System.Threading.Tasks.Task<string> DisposeSspFile_v1Async(string authorizationXml, string sspFileId)
        {
            return base.Channel.DisposeSspFile_v1Async(authorizationXml, sspFileId);
        }
        
        public System.Threading.Tasks.Task<string> GetAdHocWorkstepConfiguration_v1Async(string authorizationXml, string[] sspFileIds, string adHocWorkstepConfiguration)
        {
            return base.Channel.GetAdHocWorkstepConfiguration_v1Async(authorizationXml, sspFileIds, adHocWorkstepConfiguration);
        }
        
        public System.Threading.Tasks.Task<string> PrepareSendEnvelopeSteps_v1Async(string authorizationXml, string[] sspFileIds, string adHocWorkstepConfiguration, string prepareSendEnvelopeStepsDescriptor)
        {
            return base.Channel.PrepareSendEnvelopeSteps_v1Async(authorizationXml, sspFileIds, adHocWorkstepConfiguration, prepareSendEnvelopeStepsDescriptor);
        }
        
        public System.Threading.Tasks.Task<string> DownloadCompletedDocument_v1Async(string authorizationXml, string envelopeId, string documentId)
        {
            return base.Channel.DownloadCompletedDocument_v1Async(authorizationXml, envelopeId, documentId);
        }
        
        public System.Threading.Tasks.Task<string> GetEnvelopeById_v1Async(string authorizationXml, string envelopeId)
        {
            return base.Channel.GetEnvelopeById_v1Async(authorizationXml, envelopeId);
        }
        
        public System.Threading.Tasks.Task<string> FindEnvelopes_v1Async(string authorizationXml, string findEnvelopesDescriptorXml)
        {
            return base.Channel.FindEnvelopes_v1Async(authorizationXml, findEnvelopesDescriptorXml);
        }
        
        public System.Threading.Tasks.Task<string> FindEnvelopes_v2Async(string authorizationXml, string findEnvelopesDescriptorXml, string resultFormat)
        {
            return base.Channel.FindEnvelopes_v2Async(authorizationXml, findEnvelopesDescriptorXml, resultFormat);
        }
        
        public System.Threading.Tasks.Task<string> SendEnvelope_v1Async(string authorizationXml, string[] sspFileIds, string envelopeDescriptionXml)
        {
            return base.Channel.SendEnvelope_v1Async(authorizationXml, sspFileIds, envelopeDescriptionXml);
        }
        
        public System.Threading.Tasks.Task<string> SendEnvelopeFromTemplate_v1Async(string authorizationXml, string templateId, string overrideOptionsXml)
        {
            return base.Channel.SendEnvelopeFromTemplate_v1Async(authorizationXml, templateId, overrideOptionsXml);
        }
        
        public System.Threading.Tasks.Task<string> SendReminders_v1Async(string authorizationXml, string envelopeId)
        {
            return base.Channel.SendReminders_v1Async(authorizationXml, envelopeId);
        }
        
        public System.Threading.Tasks.Task<string> DeleteEnvelope_v1Async(string authorizationXml, string envelopeId)
        {
            return base.Channel.DeleteEnvelope_v1Async(authorizationXml, envelopeId);
        }
        
        public System.Threading.Tasks.Task<string> CancelEnvelope_v1Async(string authorizationXml, string envelopeId)
        {
            return base.Channel.CancelEnvelope_v1Async(authorizationXml, envelopeId);
        }
        
        public System.Threading.Tasks.Task<string> NotifyEnvelopeWorkstepIsCompleted_v1Async(string authorizationXml, string envelopeId, string workstepId)
        {
            return base.Channel.NotifyEnvelopeWorkstepIsCompleted_v1Async(authorizationXml, envelopeId, workstepId);
        }
        
        public System.Threading.Tasks.Task<string> RestartEnvelope_v1Async(string authorizationXml, string envelopeId, int expirationInDays)
        {
            return base.Channel.RestartEnvelope_v1Async(authorizationXml, envelopeId, expirationInDays);
        }
        
        public System.Threading.Tasks.Task<string> ReplaceRecipient_v1Async(string authorizationXml, string envelopeId, string recipientOverrideXml)
        {
            return base.Channel.ReplaceRecipient_v1Async(authorizationXml, envelopeId, recipientOverrideXml);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecipient_v1Async(string authorizationXml, string envelopeId, string recipientLookupXml)
        {
            return base.Channel.DeleteRecipient_v1Async(authorizationXml, envelopeId, recipientLookupXml);
        }
        
        public System.Threading.Tasks.Task<string> CreateDraft_v1Async(string authorizationXml, string[] sspFileIds, string envelopeDescriptionXml, string draftOptionsXml)
        {
            return base.Channel.CreateDraft_v1Async(authorizationXml, sspFileIds, envelopeDescriptionXml, draftOptionsXml);
        }
        
        public System.Threading.Tasks.Task<string> CreateDraftFromTemplate_v1Async(string authorizationXml, string templateId, string overrideOptionsXml, string draftOptionsXml)
        {
            return base.Channel.CreateDraftFromTemplate_v1Async(authorizationXml, templateId, overrideOptionsXml, draftOptionsXml);
        }
        
        public System.Threading.Tasks.Task<string> UploadUserFile_v1Async(string userToken, string flowFileXml, string senderApplication)
        {
            return base.Channel.UploadUserFile_v1Async(userToken, flowFileXml, senderApplication);
        }
        
        public System.Threading.Tasks.Task<string> DownloadEnvelopePageImage_v1Async(string authorizationXml, string envelopeId, string docRefNumber, string pageNumber)
        {
            return base.Channel.DownloadEnvelopePageImage_v1Async(authorizationXml, envelopeId, docRefNumber, pageNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetVersion_v1Async()
        {
            return base.Channel.GetVersion_v1Async();
        }
        
        public System.Threading.Tasks.Task<string> ValidateAuthorization_v1Async(string authorizationXml)
        {
            return base.Channel.ValidateAuthorization_v1Async(authorizationXml);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ApiSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ApiSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ApiSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://demo.xyzmo.com/api.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ApiSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://demo.xyzmo.com/api.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ApiSoap,
            
            ApiSoap12,
        }
    }
}
