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
    /// Size of an element.
    /// </summary>
    public partial class FlowApiSize
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiSize class.
        /// </summary>
        public FlowApiSize() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiSize class.
        /// </summary>
        public FlowApiSize(double? height = default(double?), double? width = default(double?))
        {
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Height of the element.
        /// </summary>
        [JsonProperty(PropertyName = "Height")]
        public double? Height { get; set; }

        /// <summary>
        /// Width of the element.
        /// </summary>
        [JsonProperty(PropertyName = "Width")]
        public double? Width { get; set; }

    }
}