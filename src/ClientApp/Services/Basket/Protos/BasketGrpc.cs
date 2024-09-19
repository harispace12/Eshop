﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Services/Basket/Protos/basket.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace eShop.ClientApp.BasketGrpcClient;
public static partial class Basket
{
    static readonly string __ServiceName = "BasketApi.Basket";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
        public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest> __Marshaller_BasketApi_GetBasketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> __Marshaller_BasketApi_CustomerBasketResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest> __Marshaller_BasketApi_UpdateBasketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest> __Marshaller_BasketApi_DeleteBasketRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse> __Marshaller_BasketApi_DeleteBasketResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest, global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> __Method_GetBasket = new grpc::Method<global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest, global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBasket",
        __Marshaller_BasketApi_GetBasketRequest,
        __Marshaller_BasketApi_CustomerBasketResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest, global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> __Method_UpdateBasket = new grpc::Method<global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest, global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBasket",
        __Marshaller_BasketApi_UpdateBasketRequest,
        __Marshaller_BasketApi_CustomerBasketResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest, global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse> __Method_DeleteBasket = new grpc::Method<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest, global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBasket",
        __Marshaller_BasketApi_DeleteBasketRequest,
        __Marshaller_BasketApi_DeleteBasketResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
        get { return global::eShop.ClientApp.BasketGrpcClient.BasketReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Basket</summary>
    public partial class BasketClient : grpc::ClientBase<BasketClient>
    {
        /// <summary>Creates a new client for Basket</summary>
        /// <param name="channel">The channel to use to make remote calls.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public BasketClient(grpc::ChannelBase channel) : base(channel)
        {
        }
        /// <summary>Creates a new client for Basket that uses a custom <c>CallInvoker</c>.</summary>
        /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public BasketClient(grpc::CallInvoker callInvoker) : base(callInvoker)
        {
        }
        /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        protected BasketClient() : base()
        {
        }
        /// <summary>Protected constructor to allow creation of configured clients.</summary>
        /// <param name="configuration">The client configuration.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        protected BasketClient(ClientBaseConfiguration configuration) : base(configuration)
        {
        }

        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse GetBasket(global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return GetBasket(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse GetBasket(global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.BlockingUnaryCall(__Method_GetBasket, null, options, request);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> GetBasketAsync(global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return GetBasketAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> GetBasketAsync(global::eShop.ClientApp.BasketGrpcClient.GetBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.AsyncUnaryCall(__Method_GetBasket, null, options, request);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse UpdateBasket(global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return UpdateBasket(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse UpdateBasket(global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.BlockingUnaryCall(__Method_UpdateBasket, null, options, request);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> UpdateBasketAsync(global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return UpdateBasketAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.CustomerBasketResponse> UpdateBasketAsync(global::eShop.ClientApp.BasketGrpcClient.UpdateBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.AsyncUnaryCall(__Method_UpdateBasket, null, options, request);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse DeleteBasket(global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return DeleteBasket(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse DeleteBasket(global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.BlockingUnaryCall(__Method_DeleteBasket, null, options, request);
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse> DeleteBasketAsync(global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return DeleteBasketAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        public virtual grpc::AsyncUnaryCall<global::eShop.ClientApp.BasketGrpcClient.DeleteBasketResponse> DeleteBasketAsync(global::eShop.ClientApp.BasketGrpcClient.DeleteBasketRequest request, grpc::CallOptions options)
        {
            return CallInvoker.AsyncUnaryCall(__Method_DeleteBasket, null, options, request);
        }
        /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
        [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
        protected override BasketClient NewInstance(ClientBaseConfiguration configuration)
        {
            return new BasketClient(configuration);
        }
    }

}

#endregion
