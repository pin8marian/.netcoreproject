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
    /// FormFieldValidation for dates.
    /// </summary>
    public partial class FlowApiFormFieldValidationDate : FlowApiFormFieldValidation
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationDate
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationDate() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationDate
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationDate(string type = default(string), string format = default(string), FlowApiFormFieldValidationRange range = default(FlowApiFormFieldValidationRange))
            : base(type)
        {
            Format = format;
            Range = range;
        }

        /// <summary>
        /// Defines the format of the format. (e.g. "dd. MMMM yyyy")
        /// </summary>
        [JsonProperty(PropertyName = "Format")]
        public string Format { get; set; }

        /// <summary>
        /// Define the range of the date.
        /// </summary>
        [JsonProperty(PropertyName = "Range")]
        public FlowApiFormFieldValidationRange Range { get; set; }

    }
}
