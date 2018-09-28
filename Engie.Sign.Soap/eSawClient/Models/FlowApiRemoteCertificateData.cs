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

    public partial class FlowApiRemoteCertificateData
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiRemoteCertificateData
        /// class.
        /// </summary>
        public FlowApiRemoteCertificateData() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiRemoteCertificateData
        /// class.
        /// </summary>
        public FlowApiRemoteCertificateData(string userId = default(string), string deviceId = default(string))
        {
            UserId = userId;
            DeviceId = deviceId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeviceId")]
        public string DeviceId { get; set; }

    }
}
