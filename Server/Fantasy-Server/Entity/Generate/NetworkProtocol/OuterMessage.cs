using ProtoBuf;

using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Fantasy;
using Fantasy.Network.Interface;
using Fantasy.Serialize;
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantOverriddenMember
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CheckNamespace
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8618

namespace Fantasy
{	
	[ProtoContract]
	public partial class C2A_LoginRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2A_LoginRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2A_LoginRequest>();
		}
#endif

		public static C2A_LoginRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2A_LoginRequest>();
		}
		public override void Dispose()
		{
			Account = default;
			Password = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2A_LoginRequest>(this);
#endif
		}
		[ProtoIgnore]
		public A2C_LoginResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2A_LoginRequest; }
		[ProtoMember(1)]
		public string Account { get; set; }
		[ProtoMember(2)]
		public string Password { get; set; }
	}
	[ProtoContract]
	public partial class A2C_LoginResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static A2C_LoginResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<A2C_LoginResponse>();
		}
#endif

		public static A2C_LoginResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<A2C_LoginResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Token = default;
			Address = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<A2C_LoginResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.A2C_LoginResponse; }
		[ProtoMember(1)]
		public string Token { get; set; }
		[ProtoMember(2)]
		public string Address { get; set; }
		[ProtoMember(3)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2A_RegisterRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2A_RegisterRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2A_RegisterRequest>();
		}
#endif

		public static C2A_RegisterRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2A_RegisterRequest>();
		}
		public override void Dispose()
		{
			Account = default;
			Password = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2A_RegisterRequest>(this);
#endif
		}
		[ProtoIgnore]
		public A2C_RegisterResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2A_RegisterRequest; }
		[ProtoMember(1)]
		public string Account { get; set; }
		[ProtoMember(2)]
		public string Password { get; set; }
	}
	[ProtoContract]
	public partial class A2C_RegisterResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static A2C_RegisterResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<A2C_RegisterResponse>();
		}
#endif

		public static A2C_RegisterResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<A2C_RegisterResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<A2C_RegisterResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.A2C_RegisterResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2G_LoginRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2G_LoginRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2G_LoginRequest>();
		}
#endif

		public static C2G_LoginRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_LoginRequest>();
		}
		public override void Dispose()
		{
			Token = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_LoginRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_LoginResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_LoginRequest; }
		[ProtoMember(1)]
		public string Token { get; set; }
	}
	[ProtoContract]
	public partial class G2C_LoginResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static G2C_LoginResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<G2C_LoginResponse>();
		}
#endif

		public static G2C_LoginResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_LoginResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_LoginResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_LoginResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2G_TestMessage : AMessage, IMessage, IProto
	{
#if FANTASY_UNITY

		public static C2G_TestMessage Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2G_TestMessage>();
		}
#endif

		public static C2G_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2G_TestMessage; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class C2G_TestRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2G_TestRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2G_TestRequest>();
		}
#endif

		public static C2G_TestRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_TestRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_TestRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_TestResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_TestRequest; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class G2C_TestResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static G2C_TestResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<G2C_TestResponse>();
		}
#endif

		public static G2C_TestResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_TestResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_TestResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_TestResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2G_CreateAddressableRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2G_CreateAddressableRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2G_CreateAddressableRequest>();
		}
#endif

		public static C2G_CreateAddressableRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_CreateAddressableRequest>();
		}
		public override void Dispose()
		{
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_CreateAddressableRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_CreateAddressableResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_CreateAddressableRequest; }
	}
	[ProtoContract]
	public partial class G2C_CreateAddressableResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static G2C_CreateAddressableResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<G2C_CreateAddressableResponse>();
		}
#endif

		public static G2C_CreateAddressableResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_CreateAddressableResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_CreateAddressableResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_CreateAddressableResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2M_TestMessage : AMessage, IAddressableRouteMessage, IProto
	{
#if FANTASY_UNITY

		public static C2M_TestMessage Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2M_TestMessage>();
		}
#endif

		public static C2M_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2M_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2M_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2M_TestMessage; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class C2M_TestRequest : AMessage, IAddressableRouteRequest, IProto
	{
#if FANTASY_UNITY

		public static C2M_TestRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2M_TestRequest>();
		}
#endif

		public static C2M_TestRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2M_TestRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2M_TestRequest>(this);
#endif
		}
		[ProtoIgnore]
		public M2C_TestResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2M_TestRequest; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class M2C_TestResponse : AMessage, IAddressableRouteResponse, IProto
	{
#if FANTASY_UNITY

		public static M2C_TestResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<M2C_TestResponse>();
		}
#endif

		public static M2C_TestResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<M2C_TestResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<M2C_TestResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.M2C_TestResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	/// <summary>
	///  通知Gate服务器创建一个Chat的Route连接
	/// </summary>
	[ProtoContract]
	public partial class C2G_CreateChatRouteRequest : AMessage, IRequest, IProto
	{
#if FANTASY_UNITY

		public static C2G_CreateChatRouteRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2G_CreateChatRouteRequest>();
		}
#endif

		public static C2G_CreateChatRouteRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_CreateChatRouteRequest>();
		}
		public override void Dispose()
		{
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_CreateChatRouteRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_CreateChatRouteResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_CreateChatRouteRequest; }
	}
	[ProtoContract]
	public partial class G2C_CreateChatRouteResponse : AMessage, IResponse, IProto
	{
#if FANTASY_UNITY

		public static G2C_CreateChatRouteResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<G2C_CreateChatRouteResponse>();
		}
#endif

		public static G2C_CreateChatRouteResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_CreateChatRouteResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_CreateChatRouteResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_CreateChatRouteResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	/// <summary>
	///  发送一个Route消息给Chat
	/// </summary>
	[ProtoContract]
	public partial class C2Chat_TestMessage : AMessage, ICustomRouteMessage, IProto
	{
#if FANTASY_UNITY

		public static C2Chat_TestMessage Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2Chat_TestMessage>();
		}
#endif

		public static C2Chat_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2Chat_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2Chat_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2Chat_TestMessage; }
		[ProtoIgnore]
		public int RouteType => Fantasy.RouteType.ChatRoute;
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	/// <summary>
	///  发送一个RPCRoute消息给Chat
	/// </summary>
	[ProtoContract]
	public partial class C2Chat_TestMessageRequest : AMessage, ICustomRouteRequest, IProto
	{
#if FANTASY_UNITY

		public static C2Chat_TestMessageRequest Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<C2Chat_TestMessageRequest>();
		}
#endif

		public static C2Chat_TestMessageRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2Chat_TestMessageRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2Chat_TestMessageRequest>(this);
#endif
		}
		[ProtoIgnore]
		public Chat2C_TestMessageResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2Chat_TestMessageRequest; }
		[ProtoIgnore]
		public int RouteType => Fantasy.RouteType.ChatRoute;
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class Chat2C_TestMessageResponse : AMessage, ICustomRouteResponse, IProto
	{
#if FANTASY_UNITY

		public static Chat2C_TestMessageResponse Create()
		{
			return Fantasy.Platform.Unity.Entry.Scene.MessagePoolComponent.Rent<Chat2C_TestMessageResponse>();
		}
#endif

		public static Chat2C_TestMessageResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<Chat2C_TestMessageResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<Chat2C_TestMessageResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.Chat2C_TestMessageResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
}
