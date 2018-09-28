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

    public partial class FlowApiDocumentFormField
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiDocumentFormField class.
        /// </summary>
        public FlowApiDocumentFormField() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiDocumentFormField class.
        /// </summary>
        public FlowApiDocumentFormField(string name = default(string), IList<KeyValuePairStringString> values = default(IList<KeyValuePairStringString>))
        {
            Name = name;
            Values = values;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<KeyValuePairStringString> Values { get; set; }

    }
}