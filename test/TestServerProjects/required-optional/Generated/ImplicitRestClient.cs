// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace required_optional
{
    internal partial class ImplicitRestClient
    {
        private string requiredGlobalPath;
        private string requiredGlobalQuery;
        private Uri endpoint;
        private int? optionalGlobalQuery;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ImplicitRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="requiredGlobalPath"> number of items to skip. </param>
        /// <param name="requiredGlobalQuery"> number of items to skip. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="optionalGlobalQuery"> number of items to skip. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ImplicitRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string requiredGlobalPath, string requiredGlobalQuery, Uri endpoint = null, int? optionalGlobalQuery = null)
        {
            if (requiredGlobalPath == null)
            {
                throw new ArgumentNullException(nameof(requiredGlobalPath));
            }
            if (requiredGlobalQuery == null)
            {
                throw new ArgumentNullException(nameof(requiredGlobalQuery));
            }
            endpoint ??= new Uri("http://localhost:3000");

            this.requiredGlobalPath = requiredGlobalPath;
            this.requiredGlobalQuery = requiredGlobalQuery;
            this.endpoint = endpoint;
            this.optionalGlobalQuery = optionalGlobalQuery;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequiredPathRequest(string pathParameter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/implicit/required/path/", false);
            uri.AppendPath(pathParameter, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="pathParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetRequiredPathAsync(string pathParameter, CancellationToken cancellationToken = default)
        {
            if (pathParameter == null)
            {
                throw new ArgumentNullException(nameof(pathParameter));
            }

            using var message = CreateGetRequiredPathRequest(pathParameter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="pathParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetRequiredPath(string pathParameter, CancellationToken cancellationToken = default)
        {
            if (pathParameter == null)
            {
                throw new ArgumentNullException(nameof(pathParameter));
            }

            using var message = CreateGetRequiredPathRequest(pathParameter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutOptionalQueryRequest(string queryParameter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/implicit/optional/query", false);
            if (queryParameter != null)
            {
                uri.AppendQuery("queryParameter", queryParameter, true);
            }
            request.Uri = uri;
            return message;
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutOptionalQueryAsync(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalQueryRequest(queryParameter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutOptionalQuery(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalQueryRequest(queryParameter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutOptionalHeaderRequest(string queryParameter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/implicit/optional/header", false);
            request.Uri = uri;
            if (queryParameter != null)
            {
                request.Headers.Add("queryParameter", queryParameter);
            }
            return message;
        }

        /// <summary> Test implicitly optional header parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutOptionalHeaderAsync(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalHeaderRequest(queryParameter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly optional header parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutOptionalHeader(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalHeaderRequest(queryParameter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutOptionalBodyRequest(string bodyParameter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/implicit/optional/body", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (bodyParameter != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStringValue(bodyParameter);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Test implicitly optional body parameter. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutOptionalBodyAsync(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalBodyRequest(bodyParameter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly optional body parameter. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutOptionalBody(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutOptionalBodyRequest(bodyParameter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequiredGlobalPathRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/global/required/path/", false);
            uri.AppendPath(requiredGlobalPath, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetRequiredGlobalPathAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequiredGlobalPathRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetRequiredGlobalPath(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequiredGlobalPathRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequiredGlobalQueryRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/global/required/query", false);
            uri.AppendQuery("required-global-query", requiredGlobalQuery, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Test implicitly required query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetRequiredGlobalQueryAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequiredGlobalQueryRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly required query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetRequiredGlobalQuery(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequiredGlobalQueryRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOptionalGlobalQueryRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/reqopt/global/optional/query", false);
            if (optionalGlobalQuery != null)
            {
                uri.AppendQuery("optional-global-query", optionalGlobalQuery.Value, true);
            }
            request.Uri = uri;
            return message;
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> GetOptionalGlobalQueryAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetOptionalGlobalQueryRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetOptionalGlobalQuery(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetOptionalGlobalQueryRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}