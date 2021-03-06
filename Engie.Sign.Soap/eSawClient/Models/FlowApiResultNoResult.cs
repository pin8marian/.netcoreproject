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
    /// General result body.
    /// </summary>
    public partial class FlowApiResultNoResult
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiResultNoResult class.
        /// </summary>
        public FlowApiResultNoResult() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiResultNoResult class.
        /// </summary>
        public FlowApiResultNoResult(bool? success = default(bool?), string version = default(string), FlowApiError error = default(FlowApiError), object result = default(object))
        {
            Success = success;
            Version = version;
            Error = error;
            Result = result;
        }

        /// <summary>
        /// Indicates if the call was successfully executed.
        /// </summary>
        [JsonProperty(PropertyName = "Success")]
        public bool? Success { get; set; }

        /// <summary>
        /// eSignAnyWhere version.
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

        /// <summary>
        /// The occured error. Is only present if &lt;seealso
        /// cref="P:Common.Models.Api.Types.Base.FlowApiResult`1.Success"
        /// /&gt; is false.
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public FlowApiError Error { get; set; }

        /// <summary>
        /// The included information.
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public object Result { get; set; }

    }
}
