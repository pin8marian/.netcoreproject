﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace eSaw.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// The workstep configuration used to create the workstep.
    /// </summary>
    public partial class FlowApiWorkstepConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiWorkstepConfiguration
        /// class.
        /// </summary>
        public FlowApiWorkstepConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiWorkstepConfiguration
        /// class.
        /// </summary>
        public FlowApiWorkstepConfiguration(string workstepLabel = default(string), bool? skipThirdPartyChecks = default(bool?), int? smallTextZoomFactorPercent = default(int?), int? workstepTimeToLiveInMinutes = default(int?), FlowApiFinishAction finishAction = default(FlowApiFinishAction), FlowApiIntroTexts introTexts = default(FlowApiIntroTexts), FlowApiReceiverInformation receiverInformation = default(FlowApiReceiverInformation), FlowApiSenderInformation senderInformation = default(FlowApiSenderInformation), FlowApiGeneralPolicies generalPolicies = default(FlowApiGeneralPolicies), IList<FlowApiTransactionCodeConfiguration> transactionCodeConfigurations = default(IList<FlowApiTransactionCodeConfiguration>), IList<FlowApiSignatureConfiguration> signatureConfigurations = default(IList<FlowApiSignatureConfiguration>), FlowApiViewerPreferences viewerPreferences = default(FlowApiViewerPreferences), FlowApiResourceUris resourceUris = default(FlowApiResourceUris), FlowApiAuthenticationMethods authenticationMethods = default(FlowApiAuthenticationMethods), string additionalClientWorkstepInformation = default(string), FlowApiFinalizeActions finalizeActions = default(FlowApiFinalizeActions), string timeCreated = default(string), FlowApiAuditingToolsConfiguration auditingToolsConfiguration = default(FlowApiAuditingToolsConfiguration), FlowApiWorkstepTasks workstepTasks = default(FlowApiWorkstepTasks))
        {
            WorkstepLabel = workstepLabel;
            SkipThirdPartyChecks = skipThirdPartyChecks;
            SmallTextZoomFactorPercent = smallTextZoomFactorPercent;
            WorkstepTimeToLiveInMinutes = workstepTimeToLiveInMinutes;
            FinishAction = finishAction;
            IntroTexts = introTexts;
            ReceiverInformation = receiverInformation;
            SenderInformation = senderInformation;
            GeneralPolicies = generalPolicies;
            TransactionCodeConfigurations = transactionCodeConfigurations;
            SignatureConfigurations = signatureConfigurations;
            ViewerPreferences = viewerPreferences;
            ResourceUris = resourceUris;
            AuthenticationMethods = authenticationMethods;
            AdditionalClientWorkstepInformation = additionalClientWorkstepInformation;
            FinalizeActions = finalizeActions;
            TimeCreated = timeCreated;
            AuditingToolsConfiguration = auditingToolsConfiguration;
            WorkstepTasks = workstepTasks;
        }

        /// <summary>
        /// A label for this workstep.
        /// </summary>
        [JsonProperty(PropertyName = "WorkstepLabel")]
        public string WorkstepLabel { get; set; }

        /// <summary>
        /// If set to true, no third party checks are performed to speed up
        /// workstep creation. If set to false all validity checks to third
        /// parties are done.
        /// </summary>
        [JsonProperty(PropertyName = "SkipThirdPartyChecks")]
        public bool? SkipThirdPartyChecks { get; set; }

        /// <summary>
        /// Defines a image generation correction factor. If for example this
        /// document contains very small text, which might not be readable
        /// with the standard image resolution of the client, this factor can
        /// be used to tell the client to get a higher resolution.
        /// </summary>
        [JsonProperty(PropertyName = "SmallTextZoomFactorPercent")]
        public int? SmallTextZoomFactorPercent { get; set; }

        /// <summary>
        /// Defines the time to live of all the documents created by the
        /// workstep. After this time to live is expired, all documents are
        /// deleted. '0' sets the time to live to forever.
        /// </summary>
        [JsonProperty(PropertyName = "WorkstepTimeToLiveInMinutes")]
        public int? WorkstepTimeToLiveInMinutes { get; set; }

        /// <summary>
        /// Configure the actions done by the server and the by the clients
        /// when the workstep is finished.
        /// </summary>
        [JsonProperty(PropertyName = "FinishAction")]
        public FlowApiFinishAction FinishAction { get; set; }

        /// <summary>
        /// Intro texts.
        /// </summary>
        [JsonProperty(PropertyName = "IntroTexts")]
        public FlowApiIntroTexts IntroTexts { get; set; }

        /// <summary>
        /// Information about the recipient of the document.
        /// </summary>
        [JsonProperty(PropertyName = "ReceiverInformation")]
        public FlowApiReceiverInformation ReceiverInformation { get; private set; }

        /// <summary>
        /// Information about the sender of the document.
        /// </summary>
        [JsonProperty(PropertyName = "SenderInformation")]
        public FlowApiSenderInformation SenderInformation { get; private set; }

        /// <summary>
        /// Defines general policies for this workstep.
        /// </summary>
        [JsonProperty(PropertyName = "GeneralPolicies")]
        public FlowApiGeneralPolicies GeneralPolicies { get; set; }

        /// <summary>
        /// Collection of TransactionCodeConfigurations
        /// </summary>
        [JsonProperty(PropertyName = "TransactionCodeConfigurations")]
        public IList<FlowApiTransactionCodeConfiguration> TransactionCodeConfigurations { get; set; }

        /// <summary>
        /// Collection of SignatureConfigurations
        /// </summary>
        [JsonProperty(PropertyName = "SignatureConfigurations")]
        public IList<FlowApiSignatureConfiguration> SignatureConfigurations { get; set; }

        /// <summary>
        /// The Viewer Preferences can be used to adapt the appearance and the
        /// behavior of the SignAnyWhere Viewer.
        /// </summary>
        [JsonProperty(PropertyName = "ViewerPreferences")]
        public FlowApiViewerPreferences ViewerPreferences { get; set; }

        /// <summary>
        /// Rescource uris.
        /// </summary>
        [JsonProperty(PropertyName = "ResourceUris")]
        public FlowApiResourceUris ResourceUris { get; private set; }

        /// <summary>
        /// Authentication methods.
        /// </summary>
        [JsonProperty(PropertyName = "AuthenticationMethods")]
        public FlowApiAuthenticationMethods AuthenticationMethods { get; private set; }

        /// <summary>
        /// Additional client workstep information.
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalClientWorkstepInformation")]
        public string AdditionalClientWorkstepInformation { get; private set; }

        /// <summary>
        /// Allows to define actions which will be executed when the workstep
        /// will be finished. Those actions are performed before the
        /// ServerAction will be called and, depending on the type of the
        /// action, it might change the documents according to the workstep!
        /// </summary>
        [JsonProperty(PropertyName = "FinalizeActions")]
        public FlowApiFinalizeActions FinalizeActions { get; set; }

        /// <summary>
        /// Creation time of the workstep.
        /// </summary>
        [JsonProperty(PropertyName = "TimeCreated")]
        public string TimeCreated { get; private set; }

        /// <summary>
        /// Configuration regarding tools for auditing.
        /// </summary>
        [JsonProperty(PropertyName = "AuditingToolsConfiguration")]
        public FlowApiAuditingToolsConfiguration AuditingToolsConfiguration { get; private set; }

        /// <summary>
        /// Configuration of tasks.
        /// </summary>
        [JsonProperty(PropertyName = "WorkstepTasks")]
        public FlowApiWorkstepTasks WorkstepTasks { get; set; }

    }
}
