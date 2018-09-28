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
    /// Configure the notifications.
    /// </summary>
    public partial class FlowApiNotificationConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiNotificationConfiguration
        /// class.
        /// </summary>
        public FlowApiNotificationConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiNotificationConfiguration
        /// class.
        /// </summary>
        public FlowApiNotificationConfiguration(FlowApiNotificationEventsToSend notificationEventsToSend = default(FlowApiNotificationEventsToSend), string notificationUrl = default(string))
        {
            NotificationEventsToSend = notificationEventsToSend;
            NotificationUrl = notificationUrl;
        }

        /// <summary>
        /// Defines the events that should be send.
        /// </summary>
        [JsonProperty(PropertyName = "NotificationEventsToSend")]
        public FlowApiNotificationEventsToSend NotificationEventsToSend { get; set; }

        /// <summary>
        /// The url of the notifcation.
        /// </summary>
        [JsonProperty(PropertyName = "NotificationUrl")]
        public string NotificationUrl { get; set; }

    }
}
