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
    /// Range to define in FormFieldValidation.
    /// </summary>
    public partial class FlowApiFormFieldValidationRange
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationRange
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationRange() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationRange
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationRange(string fromProperty = default(string), string to = default(string))
        {
            FromProperty = fromProperty;
            To = to;
        }

        /// <summary>
        /// Defines a value for the start of the range.
        /// </summary>
        [JsonProperty(PropertyName = "From")]
        public string FromProperty { get; set; }

        /// <summary>
        /// Defines a value for the end of the range.
        /// </summary>
        [JsonProperty(PropertyName = "To")]
        public string To { get; set; }

    }
}