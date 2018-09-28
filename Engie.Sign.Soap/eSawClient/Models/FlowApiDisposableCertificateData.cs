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

    public partial class FlowApiDisposableCertificateData
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiDisposableCertificateData
        /// class.
        /// </summary>
        public FlowApiDisposableCertificateData() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiDisposableCertificateData
        /// class.
        /// </summary>
        public FlowApiDisposableCertificateData(string countryResidence = default(string), string identificationCountry = default(string), string identificationType = default(string), string phoneMobile = default(string), string documentType = default(string), string documentIssuedBy = default(string), DateTime? documentIssuedOn = default(DateTime?), DateTime? documentExpiryDate = default(DateTime?), string serialNumber = default(string), string documentNumber = default(string))
        {
            CountryResidence = countryResidence;
            IdentificationCountry = identificationCountry;
            IdentificationType = identificationType;
            PhoneMobile = phoneMobile;
            DocumentType = documentType;
            DocumentIssuedBy = documentIssuedBy;
            DocumentIssuedOn = documentIssuedOn;
            DocumentExpiryDate = documentExpiryDate;
            SerialNumber = serialNumber;
            DocumentNumber = documentNumber;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CountryResidence")]
        public string CountryResidence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IdentificationCountry")]
        public string IdentificationCountry { get; set; }

        /// <summary>
        /// Possible values include: 'NONE', 'FOREIGN_TAX_CODE',
        /// 'PERSONAL_NUMBER', 'PASSPORT', 'NATIONAL_IDENTITY_CARD',
        /// 'ITALIAN_TAX_CODE', 'NO_SERIAL_NUMBER'
        /// </summary>
        [JsonProperty(PropertyName = "IdentificationType")]
        public string IdentificationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneMobile")]
        public string PhoneMobile { get; set; }

        /// <summary>
        /// Possible values include: 'CI', 'PA', 'PASS', 'PD', 'ID', 'PN', 'AT'
        /// </summary>
        [JsonProperty(PropertyName = "DocumentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentIssuedBy")]
        public string DocumentIssuedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentIssuedOn")]
        public DateTime? DocumentIssuedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentExpiryDate")]
        public DateTime? DocumentExpiryDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SerialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentNumber")]
        public string DocumentNumber { get; set; }

    }
}