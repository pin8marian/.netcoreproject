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
    /// Configuration for parsing the form fields.
    /// </summary>
    public partial class FlowApiParseFormFields
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiParseFormFields class.
        /// </summary>
        public FlowApiParseFormFields() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiParseFormFields class.
        /// </summary>
        public FlowApiParseFormFields(bool? mapRequiredFieldsToRequiredTask = default(bool?), string formsGrouping = default(string), bool? returnSimplifiedConfig = default(bool?), bool? addKeepExistingValueFlag = default(bool?), bool? parseFormFields = default(bool?))
        {
            MapRequiredFieldsToRequiredTask = mapRequiredFieldsToRequiredTask;
            FormsGrouping = formsGrouping;
            ReturnSimplifiedConfig = returnSimplifiedConfig;
            AddKeepExistingValueFlag = addKeepExistingValueFlag;
            ParseFormFields = parseFormFields;
        }

        /// <summary>
        /// Maps required fields to required task.
        /// </summary>
        [JsonProperty(PropertyName = "MapRequiredFieldsToRequiredTask")]
        public bool? MapRequiredFieldsToRequiredTask { get; set; }

        /// <summary>
        /// Defines how the forms are grouped. Possible values include:
        /// 'PerPage', 'PerDocument', 'PerEnvelope'
        /// </summary>
        [JsonProperty(PropertyName = "FormsGrouping")]
        public string FormsGrouping { get; set; }

        /// <summary>
        /// Defines if the simplified configuration should be returned.
        /// </summary>
        [JsonProperty(PropertyName = "ReturnSimplifiedConfig")]
        public bool? ReturnSimplifiedConfig { get; set; }

        /// <summary>
        /// Adds KeepExisitingValue flag.
        /// </summary>
        [JsonProperty(PropertyName = "AddKeepExistingValueFlag")]
        public bool? AddKeepExistingValueFlag { get; set; }

        /// <summary>
        /// Defines if form fields should be parsed.
        /// </summary>
        [JsonProperty(PropertyName = "ParseFormFields")]
        public bool? ParseFormFields { get; set; }

    }
}