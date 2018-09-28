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
    /// CheckBox form.
    /// </summary>
    public partial class FlowApiCheckBox : FlowApiForm
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiCheckBox class.
        /// </summary>
        public FlowApiCheckBox() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiCheckBox class.
        /// </summary>
        public FlowApiCheckBox(string id = default(string), int? positionPage = default(int?), int? docRefNumber = default(int?), FlowApiPosition position = default(FlowApiPosition), FlowApiSize size = default(FlowApiSize), bool? isHidden = default(bool?), string exportValue = default(string), string description = default(string), bool? keepExistingValue = default(bool?), int? customOrder = default(int?), string formType = default(string), bool? isReadonly = default(bool?), bool? isRequired = default(bool?), bool? isChecked = default(bool?), string requiredEvalPolicy = default(string))
            : base(id, positionPage, docRefNumber, position, size, isHidden, exportValue, description, keepExistingValue, customOrder, formType)
        {
            IsReadonly = isReadonly;
            IsRequired = isRequired;
            IsChecked = isChecked;
            RequiredEvalPolicy = requiredEvalPolicy;
        }

        /// <summary>
        /// Defines if the checkbox is readonly.
        /// </summary>
        [JsonProperty(PropertyName = "IsReadonly")]
        public bool? IsReadonly { get; set; }

        /// <summary>
        /// Defines if the checkbox is required,
        /// </summary>
        [JsonProperty(PropertyName = "IsRequired")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Defines if the checkbos is checked.
        /// </summary>
        [JsonProperty(PropertyName = "IsChecked")]
        public bool? IsChecked { get; set; }

        /// <summary>
        /// Defines the policy if the checkbox is required. Possible values
        /// include: 'None', 'IsChecked'
        /// </summary>
        [JsonProperty(PropertyName = "RequiredEvalPolicy")]
        public string RequiredEvalPolicy { get; set; }

    }
}