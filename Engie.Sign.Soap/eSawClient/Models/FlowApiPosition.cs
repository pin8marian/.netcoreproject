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
    /// Positioning of elements.
    /// </summary>
    public partial class FlowApiPosition
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiPosition class.
        /// </summary>
        public FlowApiPosition() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiPosition class.
        /// </summary>
        public FlowApiPosition(double? positionX = default(double?), double? positionY = default(double?))
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        /// <summary>
        /// X position of the element.
        /// </summary>
        [JsonProperty(PropertyName = "PositionX")]
        public double? PositionX { get; set; }

        /// <summary>
        /// Y position of the element.
        /// </summary>
        [JsonProperty(PropertyName = "PositionY")]
        public double? PositionY { get; set; }

    }
}