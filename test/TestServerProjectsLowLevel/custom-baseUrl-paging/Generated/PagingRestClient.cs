// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace custom_baseUrl_paging_LowLevel
{
    /// <summary> The PagingRest service client. </summary>
    internal partial class PagingRestClient
    {
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PagingRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public PagingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "host")
        {
            this.host = host ?? throw new ArgumentNullException(nameof(host));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetPagesPartialUrlRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(host, false);
            uri.AppendPath("/paging/customurl/partialnextlink", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async Task<Response> GetPagesPartialUrlAsync(string accountName, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlRequest(accountName);
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

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public Response GetPagesPartialUrl(string accountName, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlRequest(accountName);
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

        internal HttpMessage CreateGetPagesPartialUrlOperationRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(host, false);
            uri.AppendPath("/paging/customurl/partialnextlinkop", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public async Task<Response> GetPagesPartialUrlOperationAsync(string accountName, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlOperationRequest(accountName);
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

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public Response GetPagesPartialUrlOperation(string accountName, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlOperationRequest(accountName);
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

        internal HttpMessage CreateGetPagesPartialUrlOperationNextRequest(string accountName, string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(host, false);
            uri.AppendPath("/paging/customurl/", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public async Task<Response> GetPagesPartialUrlOperationNextAsync(string accountName, string nextLink, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
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

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public Response GetPagesPartialUrlOperationNext(string accountName, string nextLink, RequestOptions options = null)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
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

        internal HttpMessage CreateGetPagesPartialUrlNextPageRequest(string nextLink, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(host, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="accountName"/> is null. </exception>
        public async Task<Response> GetPagesPartialUrlNextPageAsync(string nextLink, string accountName, RequestOptions options = null)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
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

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="accountName"/> is null. </exception>
        public Response GetPagesPartialUrlNextPage(string nextLink, string accountName, RequestOptions options = null)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
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