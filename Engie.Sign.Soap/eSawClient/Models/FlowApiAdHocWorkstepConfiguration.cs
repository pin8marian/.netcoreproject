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
    /// Configure the adhoc workstep creation.
    /// </summary>
    public partial class FlowApiAdHocWorkstepConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAdHocWorkstepConfiguration class.
        /// </summary>
        public FlowApiAdHocWorkstepConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAdHocWorkstepConfiguration class.
        /// </summary>
        public FlowApiAdHocWorkstepConfiguration(string workstepLabel = default(string), int? smallTextZoomFactorPercent = default(int?), int? workstepTimeToLiveInMinutes = default(int?), FlowApiFinishAction finishAction = default(FlowApiFinishAction), bool? noSequenceEnforced = default(bool?), FlowApiSigTemplate sigTemplate = default(FlowApiSigTemplate), FlowApiParseFormFields parseFormFields = default(FlowApiParseFormFields), FlowApiAdhocPolicies adhocPolicies = default(FlowApiAdhocPolicies), FlowApiViewerPreferences viewerPreferences = default(FlowApiViewerPreferences), IList<FlowApiSignatureConfiguration> signatureConfigurations = default(IList<FlowApiSignatureConfiguration>), FlowApiSigStringParsingConfiguration sigStringParsingConfiguration = default(FlowApiSigStringParsingConfiguration), FlowApiGeneralPolicies generalPolicies = default(FlowApiGeneralPolicies), FlowApiFinalizeActions finalizeActions = default(FlowApiFinalizeActions), IList<FlowApiTransactionCodeConfiguration> transactionCodeConfigurations = default(IList<FlowApiTransactionCodeConfiguration>))
        {
            WorkstepLabel = workstepLabel;
            SmallTextZoomFactorPercent = smallTextZoomFactorPercent;
            WorkstepTimeToLiveInMinutes = workstepTimeToLiveInMinutes;
            FinishAction = finishAction;
            NoSequenceEnforced = noSequenceEnforced;
            SigTemplate = sigTemplate;
            ParseFormFields = parseFormFields;
            AdhocPolicies = adhocPolicies;
            ViewerPreferences = viewerPreferences;
            SignatureConfigurations = signatureConfigurations;
            SigStringParsingConfiguration = sigStringParsingConfiguration;
            GeneralPolicies = generalPolicies;
            FinalizeActions = finalizeActions;
            TransactionCodeConfigurations = transactionCodeConfigurations;
        }

        /// <summary>
        /// A label for this workstep
        /// </summary>
        [JsonProperty(PropertyName = "WorkstepLabel")]
        public string WorkstepLabel { get; set; }

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
        /// Define the sequence mode.
        /// </summary>
        [JsonProperty(PropertyName = "NoSequenceEnforced")]
        public bool? NoSequenceEnforced { get; set; }

        /// <summary>
        /// A template for signature definitions.
        /// </summary>
        [JsonProperty(PropertyName = "SigTemplate")]
        public FlowApiSigTemplate SigTemplate { get; set; }

        /// <summary>
        /// Configuration for parsing the form fields.
        /// </summary>
        [JsonProperty(PropertyName = "ParseFormFields")]
        public FlowApiParseFormFields ParseFormFields { get; set; }

        /// <summary>
        /// If the workstep is not generated by hand but automatically
        /// generated by the Workstep Controller AdhocPolicies are specified.
        /// </summary>
        [JsonProperty(PropertyName = "AdhocPolicies")]
        public FlowApiAdhocPolicies AdhocPolicies { get; set; }

        /// <summary>
        /// The Viewer Preferences can be used to adapt the appearance and the
        /// behavior of the SignAnyWhere Viewer.
        /// </summary>
        [JsonProperty(PropertyName = "ViewerPreferences")]
        public FlowApiViewerPreferences ViewerPreferences { get; set; }

        /// <summary>
        /// Configurate the signatures for this workstep. One default
        /// configuration has to be defined. The default configuration is
        /// used for flatten signatures, adhoc signatures and signature
        /// fields which do not reference a special signature plugin
        /// configuration. The default configuration does not contain the
        /// attribute 'spcId'. If the attribute 'spcId' is defined the
        /// signature plugin configuration does only apply to signature
        /// fields referencing the configuration by specifiying &lt;param
        /// name="spcId"&gt;id&lt;/param&gt;.
        /// </summary>
        [JsonProperty(PropertyName = "SignatureConfigurations")]
        public IList<FlowApiSignatureConfiguration> SignatureConfigurations { get; set; }

        /// <summary>
        /// Configure the signature string parsing.
        /// </summary>
        [JsonProperty(PropertyName = "SigStringParsingConfiguration")]
        public FlowApiSigStringParsingConfiguration SigStringParsingConfiguration { get; set; }

        /// <summary>
        /// Defines general policies for this workstep.
        /// </summary>
        [JsonProperty(PropertyName = "GeneralPolicies")]
        public FlowApiGeneralPolicies GeneralPolicies { get; set; }

        /// <summary>
        /// Allows to define actions which will be executed when the workstep
        /// will be finished. Those actions are performed before the
        /// ServerAction will be called and, depending on the type of the
        /// action, it might change the documents according to the workstep!
        /// </summary>
        [JsonProperty(PropertyName = "FinalizeActions")]
        public FlowApiFinalizeActions FinalizeActions { get; set; }

        /// <summary>
        /// Collection of TransactionCodeConfigurations
        /// </summary>
        [JsonProperty(PropertyName = "TransactionCodeConfigurations")]
        public IList<FlowApiTransactionCodeConfiguration> TransactionCodeConfigurations { get; set; }

    }
}