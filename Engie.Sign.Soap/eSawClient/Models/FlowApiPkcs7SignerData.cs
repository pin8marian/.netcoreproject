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

    public partial class FlowApiPkcs7SignerData
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiPkcs7SignerData class.
        /// </summary>
        public FlowApiPkcs7SignerData() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiPkcs7SignerData class.
        /// </summary>
        public FlowApiPkcs7SignerData(IList<string> allowedPkcs7SignatureTypes = default(IList<string>))
        {
            AllowedPkcs7SignatureTypes = allowedPkcs7SignatureTypes;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowedPkcs7SignatureTypes")]
        public IList<string> AllowedPkcs7SignatureTypes { get; set; }

    }
}
