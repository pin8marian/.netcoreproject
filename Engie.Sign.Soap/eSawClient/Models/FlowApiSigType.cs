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
    /// Base class for SigTypes.
    /// </summary>
    public partial class FlowApiSigType
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiSigType class.
        /// </summary>
        public FlowApiSigType() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiSigType class.
        /// </summary>
        public FlowApiSigType(string id = default(string), string type = default(string), bool? preferred = default(bool?))
        {
            Id = id;
            Type = type;
            Preferred = preferred;
        }

        /// <summary>
        /// Define a identifier.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Define a SigType. Possible values include: 'BiometricSignature',
        /// 'BiometricSignature_and_LocalCertificate', 'LocalCertificate',
        /// 'Picture', 'TransactionCode',
        /// 'TransactionCodeAndBiometricSignature',
        /// 'TransactionCodeAndLocalCertificate',
        /// 'TransactionCodeBiometricSignatureAndLocalCertificate',
        /// 'BiometricSignatureAndDisposableCertificateEnroll',
        /// 'BiometricSignatureAndDisposableCertificate', 'Click2Sign',
        /// 'Type2Sign', 'Draw2Sign'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Define if this SigType is the preferred one.
        /// </summary>
        [JsonProperty(PropertyName = "Preferred")]
        public bool? Preferred { get; set; }

    }
}
