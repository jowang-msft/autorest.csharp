// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure_LowLevel
{
    /// <summary> The HttpFailureRest service client. </summary>
    internal partial class HttpFailureRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of HttpFailureRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public HttpFailureRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("http://localhost:3000");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetEmptyErrorRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/emptybody/error", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetEmptyErrorAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetEmptyErrorRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetEmptyError(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetEmptyErrorRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetNoModelErrorRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/nomodel/error", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetNoModelErrorAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNoModelErrorRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get empty error form server. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetNoModelError(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNoModelErrorRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetNoModelEmptyRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/http/failure/nomodel/empty", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get empty response from server. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetNoModelEmptyAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNoModelEmptyRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get empty response from server. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetNoModelEmpty(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetNoModelEmptyRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }
    }
}