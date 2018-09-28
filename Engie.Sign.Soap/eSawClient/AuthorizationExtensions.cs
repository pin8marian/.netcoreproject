﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace eSaw
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Authorization.
    /// </summary>
    public static partial class AuthorizationExtensions
    {
            /// <summary>
            /// Test if your user token and api token are valid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Validate(this IAuthorization operations)
            {
                Task.Factory.StartNew(s => ((IAuthorization)s).ValidateAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Test if your user token and api token are valid.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ValidateAsync(this IAuthorization operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ValidateWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}
