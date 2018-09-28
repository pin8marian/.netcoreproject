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
    /// TextBox form.
    /// </summary>
    public partial class FlowApiTextBox : FlowApiForm
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiTextBox class.
        /// </summary>
        public FlowApiTextBox() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiTextBox class.
        /// </summary>
        public FlowApiTextBox(string id = default(string), int? positionPage = default(int?), int? docRefNumber = default(int?), FlowApiPosition position = default(FlowApiPosition), FlowApiSize size = default(FlowApiSize), bool? isHidden = default(bool?), string exportValue = default(string), string description = default(string), bool? keepExistingValue = default(bool?), int? customOrder = default(int?), string formType = default(string), bool? isScrollAllowed = default(bool?), bool? isComb = default(bool?), string value = default(string), int? maxLength = default(int?), bool? isMultiLine = default(bool?), bool? isPassword = default(bool?), bool? isFileSelect = default(bool?), FlowApiFontSettingsAdvanced fontSettings = default(FlowApiFontSettingsAdvanced), FlowApiFormFieldValidation formFieldValidation = default(FlowApiFormFieldValidation))
            : base(id, positionPage, docRefNumber, position, size, isHidden, exportValue, description, keepExistingValue, customOrder, formType)
        {
            IsScrollAllowed = isScrollAllowed;
            IsComb = isComb;
            Value = value;
            MaxLength = maxLength;
            IsMultiLine = isMultiLine;
            IsPassword = isPassword;
            IsFileSelect = isFileSelect;
            FontSettings = fontSettings;
            FormFieldValidation = formFieldValidation;
        }

        /// <summary>
        /// Define if scrolling is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "IsScrollAllowed")]
        public bool? IsScrollAllowed { get; set; }

        /// <summary>
        /// Define if the field is automatically divided into as many equally
        /// spaced positions, or combs, as the value of 'MaxLength', and the
        /// text is laid out into those combs.
        /// </summary>
        [JsonProperty(PropertyName = "IsComb")]
        public bool? IsComb { get; set; }

        /// <summary>
        /// Value of the textbox.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// The maximum of characters in the textBox. -1 means it is not
        /// limited.
        /// </summary>
        [JsonProperty(PropertyName = "MaxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Define if the textbox is multiline.
        /// </summary>
        [JsonProperty(PropertyName = "IsMultiLine")]
        public bool? IsMultiLine { get; set; }

        /// <summary>
        /// Define if the textbox is a password.
        /// </summary>
        [JsonProperty(PropertyName = "IsPassword")]
        public bool? IsPassword { get; set; }

        /// <summary>
        /// Define if it is a file selection.
        /// </summary>
        [JsonProperty(PropertyName = "IsFileSelect")]
        public bool? IsFileSelect { get; set; }

        /// <summary>
        /// Configure FontSettings for this textbox.
        /// </summary>
        [JsonProperty(PropertyName = "FontSettings")]
        public FlowApiFontSettingsAdvanced FontSettings { get; set; }

        /// <summary>
        /// Configure FormFieldValidation for this textbox.
        /// </summary>
        [JsonProperty(PropertyName = "FormFieldValidation")]
        public FlowApiFormFieldValidation FormFieldValidation { get; set; }

    }
}
