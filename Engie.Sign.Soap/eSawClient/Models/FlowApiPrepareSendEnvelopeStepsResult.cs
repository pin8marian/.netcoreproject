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

    public partial class FlowApiPrepareSendEnvelopeStepsResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiPrepareSendEnvelopeStepsResult class.
        /// </summary>
        public FlowApiPrepareSendEnvelopeStepsResult() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiPrepareSendEnvelopeStepsResult class.
        /// </summary>
        public FlowApiPrepareSendEnvelopeStepsResult(FlowApiWorkstepConfiguration adHocWorkstepConfigResult = default(FlowApiWorkstepConfiguration), IList<FlowApiSendEnvelopeStep> steps = default(IList<FlowApiSendEnvelopeStep>), FlowApiAddFormFields addFormFields = default(FlowApiAddFormFields))
        {
            AdHocWorkstepConfigResult = adHocWorkstepConfigResult;
            Steps = steps;
            AddFormFields = addFormFields;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdHocWorkstepConfigResult")]
        public FlowApiWorkstepConfiguration AdHocWorkstepConfigResult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Steps")]
        public IList<FlowApiSendEnvelopeStep> Steps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AddFormFields")]
        public FlowApiAddFormFields AddFormFields { get; set; }

    }
}
