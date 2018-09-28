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
    /// ListBox form.
    /// </summary>
    public partial class FlowApiListBox : FlowApiForm
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiListBox class.
        /// </summary>
        public FlowApiListBox() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiListBox class.
        /// </summary>
        public FlowApiListBox(string id = default(string), int? positionPage = default(int?), int? docRefNumber = default(int?), FlowApiPosition position = default(FlowApiPosition), FlowApiSize size = default(FlowApiSize), bool? isHidden = default(bool?), string exportValue = default(string), string description = default(string), bool? keepExistingValue = default(bool?), int? customOrder = default(int?), string formType = default(string), IList<FlowApiBoxItem> items = default(IList<FlowApiBoxItem>), FlowApiFontSettingsAdvanced fontSettings = default(FlowApiFontSettingsAdvanced))
            : base(id, positionPage, docRefNumber, position, size, isHidden, exportValue, description, keepExistingValue, customOrder, formType)
        {
            Items = items;
            FontSettings = fontSettings;
        }

        /// <summary>
        /// Collection of items in the listbox.
        /// </summary>
        [JsonProperty(PropertyName = "Items")]
        public IList<FlowApiBoxItem> Items { get; set; }

        /// <summary>
        /// Configure FontSettings for this listbox.
        /// </summary>
        [JsonProperty(PropertyName = "FontSettings")]
        public FlowApiFontSettingsAdvanced FontSettings { get; set; }

    }
}
