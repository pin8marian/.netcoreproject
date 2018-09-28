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
    /// BiometricSignatureAndLocalCertificate SigType.
    /// </summary>
    public partial class FlowApiSigTypeBiometricSignatureAndLocalCertificate : FlowApiSigType
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiSigTypeBiometricSignatureAndLocalCertificate class.
        /// </summary>
        public FlowApiSigTypeBiometricSignatureAndLocalCertificate() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiSigTypeBiometricSignatureAndLocalCertificate class.
        /// </summary>
        public FlowApiSigTypeBiometricSignatureAndLocalCertificate(string id = default(string), string type = default(string), bool? preferred = default(bool?), string ly = default(string), bool? isBio = default(bool?))
            : base(id, type, preferred)
        {
            Ly = ly;
            IsBio = isBio;
        }

        /// <summary>
        /// Define the layout of the local certificate.
        /// </summary>
        [JsonProperty(PropertyName = "Ly")]
        public string Ly { get; set; }

        /// <summary>
        /// Define if the BiometricSignature has a BioServerVerification.
        /// </summary>
        [JsonProperty(PropertyName = "IsBio")]
        public bool? IsBio { get; set; }

    }
}