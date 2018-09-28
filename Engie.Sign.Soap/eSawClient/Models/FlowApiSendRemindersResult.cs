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
    /// Holds information about the sent reminders.
    /// </summary>
    public partial class FlowApiSendRemindersResult
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiSendRemindersResult class.
        /// </summary>
        public FlowApiSendRemindersResult() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiSendRemindersResult class.
        /// </summary>
        public FlowApiSendRemindersResult(int? count = default(int?))
        {
            Count = count;
        }

        /// <summary>
        /// The number of reminder emails which were sent out.
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

    }
}
