﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace eSaw
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Envelope operations.
    /// </summary>
    public partial interface IEnvelope
    {
        /// <summary>
        /// Creates a draft with the given information.
        /// </summary>
        /// <param name='draftCreateModel'>
        /// Draft creation model.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateWithHttpMessagesAsync(DraftCreateModel draftCreateModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a draft from an existing template.
        /// </summary>
        /// <param name='createFromTemplateModel'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateFromTemplateWithHttpMessagesAsync(DraftCreateFromTemplateModel createFromTemplateModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancel an envelope with the given envelope id.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id of the envelope/bulk.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CancelWithHttpMessagesAsync(string envelopeId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns an envelope for the given id.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id of the envelope/bulk.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> ByIdWithHttpMessagesAsync(string envelopeId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an envelope with the given id.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id of the envelope/bulk.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string envelopeId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the found envelopes for the given descriptor.
        /// </summary>
        /// <param name='descriptor'>
        /// The find descriptor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> FindWithHttpMessagesAsync(FlowApiFindEnvelopesDescriptor descriptor, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a pdf document for the given id.
        /// </summary>
        /// <param name='documentId'>
        /// The id of the document you want to download.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DownloadCompletedDocumentWithHttpMessagesAsync(string documentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a png image for the given page.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id for the envelope. NO Bulk id.
        /// </param>
        /// <param name='docRefNumber'>
        /// The document number (starting with 1)
        /// </param>
        /// <param name='pageNumber'>
        /// The page number (starting with 1)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DownloadPageImageWithHttpMessagesAsync(string envelopeId, string docRefNumber, string pageNumber, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Parses the provided files for markup fields and sig string and
        /// returns the containing elements.
        /// </summary>
        /// <param name='prepareModel'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PrepareWithHttpMessagesAsync(EnvelopePrepareModel prepareModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restarts the envelope with the given id and sets the expiration
        /// days.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id of the envelope/bulk.
        /// </param>
        /// <param name='expirationInDays'>
        /// The number of days until the restarted envelope expires again.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> RestartWithHttpMessagesAsync(string envelopeId, int expirationInDays, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates and directly sends a new envelope.
        /// </summary>
        /// <param name='sendModel'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SendWithHttpMessagesAsync(EnvelopeSendModel sendModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an envelope from a existing template and directly sends it.
        /// </summary>
        /// <param name='sendFromTemplateModel'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SendFromTemplateWithHttpMessagesAsync(EnvelopeSendFromTemplateModel sendFromTemplateModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sends a reminder email to the recipient which action is awaited
        /// for the provided envelope.
        /// </summary>
        /// <param name='envelopeId'>
        /// The id of the envelope/bulk.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> RemindWithHttpMessagesAsync(string envelopeId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
