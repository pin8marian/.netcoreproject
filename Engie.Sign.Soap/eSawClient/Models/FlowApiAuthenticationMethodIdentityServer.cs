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
    /// Uses the identity server as authentication method.
    /// </summary>
    public partial class FlowApiAuthenticationMethodIdentityServer : FlowApiAuthenticationMethod
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationMethodIdentityServer class.
        /// </summary>
        public FlowApiAuthenticationMethodIdentityServer() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationMethodIdentityServer class.
        /// </summary>
        public FlowApiAuthenticationMethodIdentityServer(string provider = default(string), string identityId = default(string), string moduleId = default(string), string trConfId = default(string), bool? needsToPrepare = default(bool?))
            : base(provider)
        {
            IdentityId = identityId;
            ModuleId = moduleId;
            TrConfId = trConfId;
            NeedsToPrepare = needsToPrepare;
        }

        /// <summary>
        /// Defines the id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "IdentityId")]
        public string IdentityId { get; set; }

        /// <summary>
        /// Defines the id of the module.
        /// </summary>
        [JsonProperty(PropertyName = "ModuleId")]
        public string ModuleId { get; set; }

        /// <summary>
        /// Defines the id of the trConfiguration
        /// </summary>
        [JsonProperty(PropertyName = "TrConfId")]
        public string TrConfId { get; set; }

        /// <summary>
        /// Defines if preparation is needed.
        /// </summary>
        [JsonProperty(PropertyName = "NeedsToPrepare")]
        public bool? NeedsToPrepare { get; set; }

    }
}
