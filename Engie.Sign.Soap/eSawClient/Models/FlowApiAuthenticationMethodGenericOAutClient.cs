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
    /// Authentication with generic OAuthentication.
    /// </summary>
    public partial class FlowApiAuthenticationMethodGenericOAutClient : FlowApiAuthenticationMethod
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationMethodGenericOAutClient class.
        /// </summary>
        public FlowApiAuthenticationMethodGenericOAutClient() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAuthenticationMethodGenericOAutClient class.
        /// </summary>
        public FlowApiAuthenticationMethodGenericOAutClient(string provider = default(string), string scope = default(string), string providerIdentifier = default(string), IList<FlowApiAuthenticationMethodResourceUri> resourceUris = default(IList<FlowApiAuthenticationMethodResourceUri>), IList<FlowApiAuthenticationMethodCheck> checks = default(IList<FlowApiAuthenticationMethodCheck>))
            : base(provider)
        {
            Scope = scope;
            ProviderIdentifier = providerIdentifier;
            ResourceUris = resourceUris;
            Checks = checks;
        }

        /// <summary>
        /// Scope of the authentication.
        /// </summary>
        [JsonProperty(PropertyName = "Scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Provider identifier.
        /// </summary>
        [JsonProperty(PropertyName = "ProviderIdentifier")]
        public string ProviderIdentifier { get; set; }

        /// <summary>
        /// Resource uris of the authentication.
        /// </summary>
        [JsonProperty(PropertyName = "ResourceUris")]
        public IList<FlowApiAuthenticationMethodResourceUri> ResourceUris { get; set; }

        /// <summary>
        /// Checks for the authentication.
        /// </summary>
        [JsonProperty(PropertyName = "Checks")]
        public IList<FlowApiAuthenticationMethodCheck> Checks { get; set; }

    }
}
