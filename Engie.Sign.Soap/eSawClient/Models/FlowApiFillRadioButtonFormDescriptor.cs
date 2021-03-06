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

    public partial class FlowApiFillRadioButtonFormDescriptor : FlowApiFillFormDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillRadioButtonFormDescriptor class.
        /// </summary>
        public FlowApiFillRadioButtonFormDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiFillRadioButtonFormDescriptor class.
        /// </summary>
        public FlowApiFillRadioButtonFormDescriptor(string name = default(string), string type = default(string), string selectedItem = default(string))
            : base(name, type)
        {
            SelectedItem = selectedItem;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SelectedItem")]
        public string SelectedItem { get; set; }

    }
}
