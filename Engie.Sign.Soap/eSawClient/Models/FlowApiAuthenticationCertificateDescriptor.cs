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
    /// Configure an AuthenticationCertificateDescriptor.
    /// </summary>
    public partial class FlowApiAuthenticationCertificateDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationCertificateDescriptor class.
        /// </summary>
        public FlowApiAuthenticationCertificateDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationCertificateDescriptor class.
        /// </summary>
        public FlowApiAuthenticationCertificateDescriptor(string identifier = default(string), string type = default(string))
        {
            Identifier = identifier;
            Type = type;
        }

        /// <summary>
        /// Identifier for this AuthenticationCertificateDescriptor.
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Defines the type.
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

    }
}
