// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Ydb/Operations/V1/ydb_operation_v1.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Ydb.Operation.V1 {
  public static partial class OperationService
  {
    static readonly string __ServiceName = "Ydb.Operation.V1.OperationService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Ydb.Operations.GetOperationRequest> __Marshaller_Ydb_Operations_GetOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.GetOperationRequest.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.GetOperationResponse> __Marshaller_Ydb_Operations_GetOperationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.GetOperationResponse.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.CancelOperationRequest> __Marshaller_Ydb_Operations_CancelOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.CancelOperationRequest.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.CancelOperationResponse> __Marshaller_Ydb_Operations_CancelOperationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.CancelOperationResponse.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.ForgetOperationRequest> __Marshaller_Ydb_Operations_ForgetOperationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.ForgetOperationRequest.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.ForgetOperationResponse> __Marshaller_Ydb_Operations_ForgetOperationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.ForgetOperationResponse.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.ListOperationsRequest> __Marshaller_Ydb_Operations_ListOperationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.ListOperationsRequest.Parser));
    static readonly grpc::Marshaller<global::Ydb.Operations.ListOperationsResponse> __Marshaller_Ydb_Operations_ListOperationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ydb.Operations.ListOperationsResponse.Parser));

    static readonly grpc::Method<global::Ydb.Operations.GetOperationRequest, global::Ydb.Operations.GetOperationResponse> __Method_GetOperation = new grpc::Method<global::Ydb.Operations.GetOperationRequest, global::Ydb.Operations.GetOperationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOperation",
        __Marshaller_Ydb_Operations_GetOperationRequest,
        __Marshaller_Ydb_Operations_GetOperationResponse);

    static readonly grpc::Method<global::Ydb.Operations.CancelOperationRequest, global::Ydb.Operations.CancelOperationResponse> __Method_CancelOperation = new grpc::Method<global::Ydb.Operations.CancelOperationRequest, global::Ydb.Operations.CancelOperationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelOperation",
        __Marshaller_Ydb_Operations_CancelOperationRequest,
        __Marshaller_Ydb_Operations_CancelOperationResponse);

    static readonly grpc::Method<global::Ydb.Operations.ForgetOperationRequest, global::Ydb.Operations.ForgetOperationResponse> __Method_ForgetOperation = new grpc::Method<global::Ydb.Operations.ForgetOperationRequest, global::Ydb.Operations.ForgetOperationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ForgetOperation",
        __Marshaller_Ydb_Operations_ForgetOperationRequest,
        __Marshaller_Ydb_Operations_ForgetOperationResponse);

    static readonly grpc::Method<global::Ydb.Operations.ListOperationsRequest, global::Ydb.Operations.ListOperationsResponse> __Method_ListOperations = new grpc::Method<global::Ydb.Operations.ListOperationsRequest, global::Ydb.Operations.ListOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_Ydb_Operations_ListOperationsRequest,
        __Marshaller_Ydb_Operations_ListOperationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Ydb.Operation.V1.YdbOperationV1Reflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OperationService</summary>
    public partial class OperationServiceClient : grpc::ClientBase<OperationServiceClient>
    {
      /// <summary>Creates a new client for OperationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OperationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OperationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OperationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OperationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OperationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Check status for a given operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.GetOperationResponse GetOperation(global::Ydb.Operations.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check status for a given operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.GetOperationResponse GetOperation(global::Ydb.Operations.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      /// Check status for a given operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.GetOperationResponse> GetOperationAsync(global::Ydb.Operations.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check status for a given operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.GetOperationResponse> GetOperationAsync(global::Ydb.Operations.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      /// Starts cancellation of a long-running operation,
      /// Clients can use GetOperation to check whether the cancellation succeeded
      /// or whether the operation completed despite cancellation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.CancelOperationResponse CancelOperation(global::Ydb.Operations.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Starts cancellation of a long-running operation,
      /// Clients can use GetOperation to check whether the cancellation succeeded
      /// or whether the operation completed despite cancellation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.CancelOperationResponse CancelOperation(global::Ydb.Operations.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>
      /// Starts cancellation of a long-running operation,
      /// Clients can use GetOperation to check whether the cancellation succeeded
      /// or whether the operation completed despite cancellation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.CancelOperationResponse> CancelOperationAsync(global::Ydb.Operations.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Starts cancellation of a long-running operation,
      /// Clients can use GetOperation to check whether the cancellation succeeded
      /// or whether the operation completed despite cancellation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.CancelOperationResponse> CancelOperationAsync(global::Ydb.Operations.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>
      /// Forgets long-running operation. It does not cancel the operation and returns
      /// an error if operation was not completed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.ForgetOperationResponse ForgetOperation(global::Ydb.Operations.ForgetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ForgetOperation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Forgets long-running operation. It does not cancel the operation and returns
      /// an error if operation was not completed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.ForgetOperationResponse ForgetOperation(global::Ydb.Operations.ForgetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ForgetOperation, null, options, request);
      }
      /// <summary>
      /// Forgets long-running operation. It does not cancel the operation and returns
      /// an error if operation was not completed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.ForgetOperationResponse> ForgetOperationAsync(global::Ydb.Operations.ForgetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ForgetOperationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Forgets long-running operation. It does not cancel the operation and returns
      /// an error if operation was not completed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.ForgetOperationResponse> ForgetOperationAsync(global::Ydb.Operations.ForgetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ForgetOperation, null, options, request);
      }
      /// <summary>
      /// Lists operations that match the specified filter in the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.ListOperationsResponse ListOperations(global::Ydb.Operations.ListOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists operations that match the specified filter in the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Ydb.Operations.ListOperationsResponse ListOperations(global::Ydb.Operations.ListOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// Lists operations that match the specified filter in the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.ListOperationsResponse> ListOperationsAsync(global::Ydb.Operations.ListOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists operations that match the specified filter in the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Ydb.Operations.ListOperationsResponse> ListOperationsAsync(global::Ydb.Operations.ListOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OperationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OperationServiceClient(configuration);
      }
    }

  }
}
#endregion
