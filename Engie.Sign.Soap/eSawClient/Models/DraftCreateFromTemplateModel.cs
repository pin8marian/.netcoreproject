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

    public partial class DraftCreateFromTemplateModel
    {
        /// <summary>
        /// Initializes a new instance of the DraftCreateFromTemplateModel
        /// class.
        /// </summary>
        public DraftCreateFromTemplateModel() { }

        /// <summary>
        /// Initializes a new instance of the DraftCreateFromTemplateModel
        /// class.
        /// </summary>
        public DraftCreateFromTemplateModel(string templateId = default(string), FlowApiEnvelopeOverrideOptions flowApiEnvelopeOverrideOptions = default(FlowApiEnvelopeOverrideOptions), FlowApiCreateDraftOptions flowApiCreateDraftOptions = default(FlowApiCreateDraftOptions))
        {
            TemplateId = templateId;
            FlowApiEnvelopeOverrideOptions = flowApiEnvelopeOverrideOptions;
            FlowApiCreateDraftOptions = flowApiCreateDraftOptions;
        }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [JsonProperty(PropertyName = "TemplateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// The options to override from the template.
        /// </summary>
        [JsonProperty(PropertyName = "FlowApiEnvelopeOverrideOptions")]
        public FlowApiEnvelopeOverrideOptions FlowApiEnvelopeOverrideOptions { get; set; }

        /// <summary>
        /// Draft creation options.
        /// </summary>
        [JsonProperty(PropertyName = "FlowApiCreateDraftOptions")]
        public FlowApiCreateDraftOptions FlowApiCreateDraftOptions { get; set; }

    }
}
