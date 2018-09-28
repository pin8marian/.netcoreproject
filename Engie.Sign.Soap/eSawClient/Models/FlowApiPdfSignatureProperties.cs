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
    /// Configure PdfSignatureProperties.
    /// </summary>
    public partial class FlowApiPdfSignatureProperties
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiPdfSignatureProperties
        /// class.
        /// </summary>
        public FlowApiPdfSignatureProperties() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiPdfSignatureProperties
        /// class.
        /// </summary>
        public FlowApiPdfSignatureProperties(bool? pdfAConformant = default(bool?), bool? pAdESPart4Compliant = default(bool?), bool? includeSigningCertificateChain = default(bool?), string signingCertificateRevocationInformationIncludeMode = default(string), FlowApiSignatureTimestampData signatureTimestampData = default(FlowApiSignatureTimestampData))
        {
            PdfAConformant = pdfAConformant;
            PAdESPart4Compliant = pAdESPart4Compliant;
            IncludeSigningCertificateChain = includeSigningCertificateChain;
            SigningCertificateRevocationInformationIncludeMode = signingCertificateRevocationInformationIncludeMode;
            SignatureTimestampData = signatureTimestampData;
        }

        /// <summary>
        /// Define usage of PdfAConformant.
        /// </summary>
        [JsonProperty(PropertyName = "PdfAConformant")]
        public bool? PdfAConformant { get; set; }

        /// <summary>
        /// Define usage of PAdESPart4Compliant.
        /// </summary>
        [JsonProperty(PropertyName = "PAdESPart4Compliant")]
        public bool? PAdESPart4Compliant { get; set; }

        /// <summary>
        /// Define if SigningCertificateChain should be included.
        /// </summary>
        [JsonProperty(PropertyName = "IncludeSigningCertificateChain")]
        public bool? IncludeSigningCertificateChain { get; set; }

        /// <summary>
        /// Define the SigningCertificateRevocationInformationIncludeMode
        /// type. Possible values include: 'DoNotInclude', 'Include',
        /// 'TryToInclude', 'CheckRevocationIncludeOcsp', 'IncludeDss',
        /// 'TryToIncludeDss'
        /// </summary>
        [JsonProperty(PropertyName = "SigningCertificateRevocationInformationIncludeMode")]
        public string SigningCertificateRevocationInformationIncludeMode { get; set; }

        /// <summary>
        /// Configure SignatureTimestampData for this object.
        /// </summary>
        [JsonProperty(PropertyName = "SignatureTimestampData")]
        public FlowApiSignatureTimestampData SignatureTimestampData { get; set; }

    }
}
