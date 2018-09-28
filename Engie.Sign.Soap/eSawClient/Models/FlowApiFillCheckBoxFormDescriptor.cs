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

    public partial class FlowApiFillCheckBoxFormDescriptor : FlowApiFillFormDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillCheckBoxFormDescriptor class.
        /// </summary>
        public FlowApiFillCheckBoxFormDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillCheckBoxFormDescriptor class.
        /// </summary>
        public FlowApiFillCheckBoxFormDescriptor(string name = default(string), string type = default(string), bool? isChecked = default(bool?))
            : base(name, type)
        {
            IsChecked = isChecked;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsChecked")]
        public bool? IsChecked { get; set; }

    }
}
