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
    /// FormFieldValidation for phones.
    /// </summary>
    public partial class FlowApiFormFieldValidationPhone : FlowApiFormFieldValidation
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationPhone
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationPhone() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFormFieldValidationPhone
        /// class.
        /// </summary>
        public FlowApiFormFieldValidationPhone(string type = default(string), string phoneType = default(string))
            : base(type)
        {
            PhoneType = phoneType;
        }

        /// <summary>
        /// Defines the PhoneType. Possible values include: 'International',
        /// 'InternationalLeadingZeros', 'InternationalLeadingPlus'
        /// </summary>
        [JsonProperty(PropertyName = "PhoneType")]
        public string PhoneType { get; set; }

    }
}