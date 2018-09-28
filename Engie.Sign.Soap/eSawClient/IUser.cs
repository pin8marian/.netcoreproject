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
    /// User operations.
    /// </summary>
    public partial interface IUser
    {
        /// <summary>
        /// Creates an user in the organization of the api user.
        /// </summary>
        /// <param name='model'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateWithHttpMessagesAsync(UserCreateModel model, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an user from the api user's organization.
        /// </summary>
        /// <param name='userId'>
        /// The id of the user who should be deleted.
        /// </param>
        /// <param name='reassignDescriptor'>
        /// Information about the user and remaining envelopes handling.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string userId, FlowApiDeleteUserReassignDescriptor reassignDescriptor, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates settings of a particular user.
        /// </summary>
        /// <param name='userId'>
        /// The id of the user who should be updated.
        /// </param>
        /// <param name='userUpdateDescription'>
        /// Information about the user to be updated
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateWithHttpMessagesAsync(string userId, FlowApiUserUpdateDescription userUpdateDescription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Finds users corresponding to the given user descriptor.
        /// </summary>
        /// <param name='findUsersDescriptor'>
        /// The descriptor for finding users (filter).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> FindWithHttpMessagesAsync(FlowApiFindUsersDescriptor findUsersDescriptor, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Replaces the signature image.
        /// </summary>
        /// <param name='userId'>
        /// The id of the user whos signature image should be replaced.
        /// </param>
        /// <param name='file'>
        /// Upload software package
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UploadSignatureImageWithHttpMessagesAsync(string userId, System.IO.Stream file, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}