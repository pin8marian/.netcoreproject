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
    /// Checks for OAuth and Saml
    /// </summary>
    public partial class FlowApiAuthenticationMethodCheck
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiAuthenticationMethodCheck
        /// class.
        /// </summary>
        public FlowApiAuthenticationMethodCheck() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiAuthenticationMethodCheck
        /// class.
        /// </summary>
        public FlowApiAuthenticationMethodCheck(string fieldId = default(string), string compareOperation = default(string), string value = default(string))
        {
            FieldId = fieldId;
            CompareOperation = compareOperation;
            Value = value;
        }

        /// <summary>
        /// Field id
        /// </summary>
        [JsonProperty(PropertyName = "FieldId")]
        public string FieldId { get; set; }

        /// <summary>
        /// Compare operator. Possible values include: 'Equal', 'NotEqual'
        /// </summary>
        [JsonProperty(PropertyName = "CompareOperation")]
        public string CompareOperation { get; set; }

        /// <summary>
        /// Value of the check.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}