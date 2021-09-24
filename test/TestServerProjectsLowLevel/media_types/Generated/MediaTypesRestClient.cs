// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace media_types_LowLevel
{
    /// <summary> The MediaTypesRest service client. </summary>
    internal partial class MediaTypesRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MediaTypesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MediaTypesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("http://localhost:3000");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateAnalyzeBodyRequest(RequestContent content, ContentType contentType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediatypes/analyze", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> AnalyzeBodyAsync(RequestContent content, ContentType contentType, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyRequest(content, contentType);
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

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="options"> The request options. </param>
        public Response AnalyzeBody(RequestContent content, ContentType contentType, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyRequest(content, contentType);
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

        internal HttpMessage CreateAnalyzeBodyRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediatypes/analyze", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> AnalyzeBodyAsync(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyRequest(content);
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

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public Response AnalyzeBody(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyRequest(content);
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

        internal HttpMessage CreateAnalyzeBodyNoAcceptHeaderRequest(RequestContent content, ContentType contentType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediatypes/analyzeNoAccept", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            return message;
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(RequestContent content, ContentType contentType, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyNoAcceptHeaderRequest(content, contentType);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 202:
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

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="options"> The request options. </param>
        public Response AnalyzeBodyNoAcceptHeader(RequestContent content, ContentType contentType, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyNoAcceptHeaderRequest(content, contentType);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 202:
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

        internal HttpMessage CreateAnalyzeBodyNoAcceptHeaderRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediatypes/analyzeNoAccept", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyNoAcceptHeaderRequest(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 202:
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

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public Response AnalyzeBodyNoAcceptHeader(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateAnalyzeBodyNoAcceptHeaderRequest(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 202:
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

        internal HttpMessage CreateContentTypeWithEncodingRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediatypes/contentTypeWithEncoding", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "text/plain");
            request.Content = content;
            return message;
        }

        /// <summary> Pass in contentType &apos;text/plain; encoding=UTF-8&apos; to pass test. Value for input does not matter. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public async Task<Response> ContentTypeWithEncodingAsync(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateContentTypeWithEncodingRequest(content);
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

        /// <summary> Pass in contentType &apos;text/plain; encoding=UTF-8&apos; to pass test. Value for input does not matter. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        public Response ContentTypeWithEncoding(RequestContent content, RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateContentTypeWithEncodingRequest(content);
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