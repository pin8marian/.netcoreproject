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

    public partial class FlowApiCreateUserResult
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiCreateUserResult class.
        /// </summary>
        public FlowApiCreateUserResult() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiCreateUserResult class.
        /// </summary>
        public FlowApiCreateUserResult(IList<Guid?> createdUserIds = default(IList<Guid?>))
        {
            CreatedUserIds = createdUserIds;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedUserIds")]
        public IList<Guid?> CreatedUserIds { get; set; }

    }
}