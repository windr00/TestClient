﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CubeSTE.proto
namespace CubeEvent
{
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CubeSTE")]
	public partial class CubeSTE : global::ProtoBuf.IExtensible
	{
		public CubeSTE() {}
		
		private readonly global::System.Collections.Generic.List<Content> _content = new global::System.Collections.Generic.List<Content>();
		[global::ProtoBuf.ProtoMember(1, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<Content> content
		{
			get { return _content; }
		}
		
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Content")]
	public partial class Content : global::ProtoBuf.IExtensible
	{
		public Content() {}
		
		private StateEnum _state;
		[global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
		public StateEnum state
		{
			get { return _state; }
			set { _state = value; }
		}
		private Vector3 _value;
		[global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public Vector3 value
		{
			get { return _value; }
			set { _value = value; }
		}
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vector3")]
	public partial class Vector3 : global::ProtoBuf.IExtensible
	{
		public Vector3() {}
		
		private float _x;
		[global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
		public float x
		{
			get { return _x; }
			set { _x = value; }
		}
		private float _y;
		[global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
		public float y
		{
			get { return _y; }
			set { _y = value; }
		}
		private float _z;
		[global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
		public float z
		{
			get { return _z; }
			set { _z = value; }
		}
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
			{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	
	[global::ProtoBuf.ProtoContract(Name=@"StateEnum")]
	public enum StateEnum
	{
		
		[global::ProtoBuf.ProtoEnum(Name=@"POS", Value=1)]
		POS = 1,
		
		[global::ProtoBuf.ProtoEnum(Name=@"ROT", Value=2)]
		ROT = 2
	}
	
}