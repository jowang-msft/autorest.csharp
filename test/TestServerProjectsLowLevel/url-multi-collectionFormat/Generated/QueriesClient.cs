// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace url_multi_collectionFormat_LowLevel
{
    /// <summary> The Queries service client. </summary>
    public partial class QueriesClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        internal ClientDiagnostics ClientDiagnostics { get; }
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of QueriesClient for mocking. </summary>
        protected QueriesClient()
        {
        }

        /// <summary> Initializes a new instance of QueriesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public QueriesClient(AzureKeyCredential credential, Uri endpoint = null, QueriesClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            endpoint ??= new Uri("http://localhost:3000");
            options ??= new QueriesClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> ArrayStringMultiNullAsync(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiNull");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiNullRequest(arrayQuery, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response ArrayStringMultiNull(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiNull");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiNullRequest(arrayQuery, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> ArrayStringMultiEmptyAsync(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiEmptyRequest(arrayQuery, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response ArrayStringMultiEmpty(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiEmpty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiEmptyRequest(arrayQuery, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> ArrayStringMultiValidAsync(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiValidRequest(arrayQuery, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response ArrayStringMultiValid(IEnumerable<string> arrayQuery = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("QueriesClient.ArrayStringMultiValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateArrayStringMultiValidRequest(arrayQuery, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateArrayStringMultiNullRequest(IEnumerable<string> arrayQuery, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/null", false);
            if (arrayQuery != null)
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateArrayStringMultiEmptyRequest(IEnumerable<string> arrayQuery, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/empty", false);
            if (arrayQuery != null)
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateArrayStringMultiValidRequest(IEnumerable<string> arrayQuery, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/valid", false);
            if (arrayQuery != null)
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
