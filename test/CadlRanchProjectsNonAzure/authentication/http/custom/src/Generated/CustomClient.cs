// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.ClientModel.Primitives.Pipeline;
using System.Threading.Tasks;

namespace Authentication.Http.Custom
{
    // Data plane generated client.
    /// <summary> Illustrates clients generated with generic HTTP auth. </summary>
    public partial class CustomClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly KeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "SharedAccessKey";
        private readonly MessagePipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal TelemetrySource ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual MessagePipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CustomClient for mocking. </summary>
        protected CustomClient()
        {
        }

        /// <summary> Initializes a new instance of CustomClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public CustomClient(KeyCredential credential) : this(new Uri("http://localhost:3000"), credential, new CustomClientOptions())
        {
        }

        /// <summary> Initializes a new instance of CustomClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CustomClient(Uri endpoint, KeyCredential credential, CustomClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new CustomClientOptions();

            ClientDiagnostics = new TelemetrySource(options, true);
            _keyCredential = credential;
            _pipeline = MessagePipeline.Create(options, new IPipelinePolicy<PipelineMessage>[] { new KeyCredentialPolicy(_keyCredential, AuthorizationHeader, AuthorizationApiKeyPrefix) }, Array.Empty<IPipelinePolicy<PipelineMessage>>());
            _endpoint = endpoint;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Check whether client is authenticated
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="MessageFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Result> ValidAsync(RequestOptions context = null)
        {
            using var scope = ClientDiagnostics.CreateSpan("CustomClient.Valid");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateValidRequest(context);
                return Result.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Check whether client is authenticated
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="MessageFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Result Valid(RequestOptions context = null)
        {
            using var scope = ClientDiagnostics.CreateSpan("CustomClient.Valid");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateValidRequest(context);
                return Result.FromResponse(_pipeline.ProcessMessage(message, context));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Check whether client is authenticated.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="MessageFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Result> InvalidAsync(RequestOptions context = null)
        {
            using var scope = ClientDiagnostics.CreateSpan("CustomClient.Invalid");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateInvalidRequest(context);
                return Result.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Check whether client is authenticated.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="MessageFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Result Invalid(RequestOptions context = null)
        {
            using var scope = ClientDiagnostics.CreateSpan("CustomClient.Invalid");
            scope.Start();
            try
            {
                using PipelineMessage message = CreateInvalidRequest(context);
                return Result.FromResponse(_pipeline.ProcessMessage(message, context));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal PipelineMessage CreateValidRequest(RequestOptions context)
        {
            var message = _pipeline.CreateMessage(context, ResponseErrorClassifier204);
            var request = message.Request;
            request.SetMethod("GET");
            var uri = new RequestUri();
            uri.Reset(_endpoint);
            uri.AppendPath("/authentication/http/custom/valid", false);
            request.Uri = uri.ToUri();
            request.SetHeaderValue("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateInvalidRequest(RequestOptions context)
        {
            var message = _pipeline.CreateMessage(context, ResponseErrorClassifier204);
            var request = message.Request;
            request.SetMethod("GET");
            var uri = new RequestUri();
            uri.Reset(_endpoint);
            uri.AppendPath("/authentication/http/custom/invalid", false);
            request.Uri = uri.ToUri();
            request.SetHeaderValue("Accept", "application/json");
            return message;
        }

        private static ResponseErrorClassifier _responseErrorClassifier204;
        private static ResponseErrorClassifier ResponseErrorClassifier204 => _responseErrorClassifier204 ??= new StatusResponseClassifier(stackalloc ushort[] { 204 });
    }
}