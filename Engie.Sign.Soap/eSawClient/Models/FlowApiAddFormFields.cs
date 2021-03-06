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
    /// Contains a list of form fields which should be added to the document.
    /// </summary>
    public partial class FlowApiAddFormFields
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiAddFormFields class.
        /// </summary>
        public FlowApiAddFormFields() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiAddFormFields class.
        /// </summary>
        public FlowApiAddFormFields(IDictionary<string, IList<FlowApiAddFormFieldDescriptor>> forms = default(IDictionary<string, IList<FlowApiAddFormFieldDescriptor>>))
        {
            Forms = forms;
        }

        /// <summary>
        /// A dictionary consisting of doc reference numbers and form field
        /// descriptions.
        /// </summary>
        [JsonProperty(PropertyName = "Forms")]
        public IDictionary<string, IList<FlowApiAddFormFieldDescriptor>> Forms { get; set; }

    }
}
