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
    /// Description for overriding an existing recipient.
    /// </summary>
    public partial class FlowApiEnvelopeOverrideOptionsRecipient
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiEnvelopeOverrideOptionsRecipient class.
        /// </summary>
        public FlowApiEnvelopeOverrideOptionsRecipient() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiEnvelopeOverrideOptionsRecipient class.
        /// </summary>
        public FlowApiEnvelopeOverrideOptionsRecipient(string recipientId = default(string), int? orderIndex = default(int?), string email = default(string), FlowApiSendEnvelopeRecipient recipient = default(FlowApiSendEnvelopeRecipient))
        {
            RecipientId = recipientId;
            OrderIndex = orderIndex;
            Email = email;
            Recipient = recipient;
        }

        /// <summary>
        /// The id of the recipient to replace.
        /// </summary>
        [JsonProperty(PropertyName = "RecipientId")]
        public string RecipientId { get; set; }

        /// <summary>
        /// The order index of the recipient to replace.
        /// </summary>
        [JsonProperty(PropertyName = "OrderIndex")]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// The email of the recipient to replace.
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// The new recipient which should replace the existing recipient.
        /// </summary>
        [JsonProperty(PropertyName = "Recipient")]
        public FlowApiSendEnvelopeRecipient Recipient { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Recipient != null)
            {
                this.Recipient.Validate();
            }
        }
    }
}
