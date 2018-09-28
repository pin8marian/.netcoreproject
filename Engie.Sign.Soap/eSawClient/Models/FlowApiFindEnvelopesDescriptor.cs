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
    /// Descriptor for filtering envelopes.
    /// </summary>
    public partial class FlowApiFindEnvelopesDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFindEnvelopesDescriptor
        /// class.
        /// </summary>
        public FlowApiFindEnvelopesDescriptor() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFindEnvelopesDescriptor
        /// class.
        /// </summary>
        public FlowApiFindEnvelopesDescriptor(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string searchText = default(string), string status = default(string), int? inStatusSinceDays = default(int?), IList<string> senders = default(IList<string>), IList<string> signers = default(IList<string>), IList<string> recipients = default(IList<string>), string waitingForRecipient = default(string), string bulk = default(string))
        {
            StartDate = startDate;
            EndDate = endDate;
            SearchText = searchText;
            Status = status;
            InStatusSinceDays = inStatusSinceDays;
            Senders = senders;
            Signers = signers;
            Recipients = recipients;
            WaitingForRecipient = waitingForRecipient;
            Bulk = bulk;
        }

        /// <summary>
        /// If set, filters for envelopes which where created (Status:
        /// Template, Draft) or sent after the start date.
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If set, filters for envelopes which where created (Status:
        /// Template, Draft) or sent before the end date.
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// If set, filters for the given text in email subject/body, envelope
        /// name/description, sender first/lastname email and recipient
        /// first/lastname email.
        /// Expensive!
        /// </summary>
        [JsonProperty(PropertyName = "SearchText")]
        public string SearchText { get; set; }

        /// <summary>
        /// If set, filters for envelopes by status. Possible values include:
        /// 'Draft', 'Started', 'InProgress', 'Canceled', 'Completed',
        /// 'Expired', 'Rejected', 'Template', 'ActionRequired',
        /// 'WaitingForOthers', 'ExpiringSoon', 'Active'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// If set, filters for envelopes which have the given status for the
        /// given days.
        /// Must be combined with Status.
        /// </summary>
        [JsonProperty(PropertyName = "InStatusSinceDays")]
        public int? InStatusSinceDays { get; set; }

        /// <summary>
        /// If set, filters for the sender email adresses.
        /// </summary>
        [JsonProperty(PropertyName = "Senders")]
        public IList<string> Senders { get; set; }

        /// <summary>
        /// If set, filters for the given sender email adresses.
        /// </summary>
        [JsonProperty(PropertyName = "Signers")]
        public IList<string> Signers { get; set; }

        /// <summary>
        /// If set, filters for the given recipient email adresses.
        /// </summary>
        [JsonProperty(PropertyName = "Recipients")]
        public IList<string> Recipients { get; set; }

        /// <summary>
        /// If set, filters for envelopes which are waiting for the given
        /// recipient email address.
        /// </summary>
        [JsonProperty(PropertyName = "WaitingForRecipient")]
        public string WaitingForRecipient { get; set; }

        /// <summary>
        /// If set, filters for envelopes for of the given bulk id.
        /// </summary>
        [JsonProperty(PropertyName = "Bulk")]
        public string Bulk { get; set; }

    }
}