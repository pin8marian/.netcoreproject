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

    public partial class FlowApiAddCheckBoxFormFieldDescriptor : FlowApiAddFormFieldDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAddCheckBoxFormFieldDescriptor class.
        /// </summary>
        public FlowApiAddCheckBoxFormFieldDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiAddCheckBoxFormFieldDescriptor class.
        /// </summary>
        public FlowApiAddCheckBoxFormFieldDescriptor(string name = default(string), bool? readOnlyProperty = default(bool?), bool? required = default(bool?), double? x = default(double?), double? y = default(double?), double? width = default(double?), double? height = default(double?), int? page = default(int?), string type = default(string), bool? isChecked = default(bool?), string exportValue = default(string))
            : base(name, readOnlyProperty, required, x, y, width, height, page, type)
        {
            IsChecked = isChecked;
            ExportValue = exportValue;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsChecked")]
        public bool? IsChecked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExportValue")]
        public string ExportValue { get; set; }

    }
}
