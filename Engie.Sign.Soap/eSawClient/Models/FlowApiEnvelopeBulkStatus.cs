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
    /// Represents a single envelope of a bulk envelope (a child).
    /// In case of a non bulk envelope this represents a normal envelope.
    /// </summary>
    public partial class FlowApiEnvelopeBulkStatus
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiEnvelopeBulkStatus class.
        /// </summary>
        public FlowApiEnvelopeBulkStatus() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiEnvelopeBulkStatus class.
        /// </summary>
        public FlowApiEnvelopeBulkStatus(string status = default(string), string email = default(string), string id = default(string), string logDocumentId = default(string), string logXmlDocumentId = default(string), IList<FlowApiFinishedDocument> finishedDocuments = default(IList<FlowApiFinishedDocument>), IList<FlowApiEnvelopeStatusRecipient> steps = default(IList<FlowApiEnvelopeStatusRecipient>))
        {
            Status = status;
            Email = email;
            Id = id;
            LogDocumentId = logDocumentId;
            LogXmlDocumentId = logXmlDocumentId;
            FinishedDocuments = finishedDocuments;
            Steps = steps;
        }

        /// <summary>
        /// The status of the envelope. Possible values include: 'Draft',
        /// 'Started', 'InProgress', 'Canceled', 'Completed', 'Expired',
        /// 'Rejected', 'Template', 'CompletedWithWarnings', 'BulkCompleted',
        /// 'BulkPartlyCompleted'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// The email of the bulk recipient. Empty if the envelope is not a
        /// bulk.
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// The envelope id.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// The document id of the audit trail information pdf file.
        /// </summary>
        [JsonProperty(PropertyName = "LogDocumentId")]
        public string LogDocumentId { get; set; }

        /// <summary>
        /// The document id of the audit trail information xml file.
        /// </summary>
        [JsonProperty(PropertyName = "LogXmlDocumentId")]
        public string LogXmlDocumentId { get; set; }

        /// <summary>
        /// The finished documents of the envelope containing all the actions
        /// (e.g. signed signatures, etc.).
        /// </summary>
        [JsonProperty(PropertyName = "FinishedDocuments")]
        public IList<FlowApiFinishedDocument> FinishedDocuments { get; set; }

        /// <summary>
        /// The steps of the envelope.
        /// </summary>
        [JsonProperty(PropertyName = "Steps")]
        public IList<FlowApiEnvelopeStatusRecipient> Steps { get; set; }

    }
}
