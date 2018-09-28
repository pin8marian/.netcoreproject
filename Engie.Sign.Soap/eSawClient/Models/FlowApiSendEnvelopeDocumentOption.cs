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
    /// Options for a specific document.
    /// </summary>
    public partial class FlowApiSendEnvelopeDocumentOption
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiSendEnvelopeDocumentOption class.
        /// </summary>
        public FlowApiSendEnvelopeDocumentOption() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiSendEnvelopeDocumentOption class.
        /// </summary>
        public FlowApiSendEnvelopeDocumentOption(string documentReference = default(string), bool? isHidden = default(bool?))
        {
            DocumentReference = documentReference;
            IsHidden = isHidden;
        }

        /// <summary>
        /// The document reference number (starting with 1).
        /// </summary>
        [JsonProperty(PropertyName = "DocumentReference")]
        public string DocumentReference { get; set; }

        /// <summary>
        /// Specifies if the referenced document is hidden.
        /// </summary>
        [JsonProperty(PropertyName = "IsHidden")]
        public bool? IsHidden { get; set; }

    }
}