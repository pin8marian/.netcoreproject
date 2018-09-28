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
    /// Timestamp for FinalizeActions. The timestamp allows you to add an
    /// invisible signature using a trusted timestamp service to the
    /// configured documents when finishing the workstep.
    /// </summary>
    public partial class FlowApiFinalizeActionsTimestamp
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFinalizeActionsTimestamp
        /// class.
        /// </summary>
        public FlowApiFinalizeActionsTimestamp() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFinalizeActionsTimestamp
        /// class.
        /// </summary>
        public FlowApiFinalizeActionsTimestamp(string docRefNumbers = default(string), string spcId = default(string))
        {
            DocRefNumbers = docRefNumbers;
            SpcId = spcId;
        }

        /// <summary>
        /// Document number for this timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "DocRefNumbers")]
        public string DocRefNumbers { get; set; }

        /// <summary>
        /// SignaturePluginConfiguration Id for this timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "SpcId")]
        public string SpcId { get; set; }

    }
}