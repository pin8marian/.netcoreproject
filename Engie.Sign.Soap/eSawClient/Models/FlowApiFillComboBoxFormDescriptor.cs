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

    public partial class FlowApiFillComboBoxFormDescriptor : FlowApiFillFormDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillComboBoxFormDescriptor class.
        /// </summary>
        public FlowApiFillComboBoxFormDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillComboBoxFormDescriptor class.
        /// </summary>
        public FlowApiFillComboBoxFormDescriptor(string name = default(string), string type = default(string), string value = default(string))
            : base(name, type)
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
