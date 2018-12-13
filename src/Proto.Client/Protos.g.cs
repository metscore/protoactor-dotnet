// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.Client {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SBmNsaWVudBoYUHJvdG8uQWN0b3IvcHJvdG9zLnBy",
            "b3RvGhlQcm90by5SZW1vdGUvcHJvdG9zLnByb3RvIjcKFkNyZWF0ZUNsaWVu",
            "dFByb3h5QWN0b3ISHQoJY2xpZW50UElEGAEgASgLMgouYWN0b3IuUElEIlYK",
            "F0NsaWVudFByb3h5QWN0b3JDcmVhdGVkEh0KCWNsaWVudFBJRBgBIAEoCzIK",
            "LmFjdG9yLlBJRBIcCghwcm94eVBJRBgCIAEoCzIKLmFjdG9yLlBJRCJ1ChJD",
            "bGllbnRNZXNzYWdlQmF0Y2gSEgoKdHlwZV9uYW1lcxgBIAMoCRIfCgt0YXJn",
            "ZXRfcGlkcxgCIAMoCzIKLmFjdG9yLlBJRBIqCgllbnZlbG9wZXMYAyADKAsy",
            "Fy5yZW1vdGUuTWVzc2FnZUVudmVsb3BlMl8KDkNsaWVudFJlbW90aW5nEk0K",
            "DUNvbm5lY3RDbGllbnQSGi5jbGllbnQuQ2xpZW50TWVzc2FnZUJhdGNoGhou",
            "Y2xpZW50LkNsaWVudE1lc3NhZ2VCYXRjaCIAKAEwAUIPqgIMUHJvdG8uQ2xp",
            "ZW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtosReflection.Descriptor, global::Proto.Remote.ProtosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Client.CreateClientProxyActor), global::Proto.Client.CreateClientProxyActor.Parser, new[]{ "ClientPID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Client.ClientProxyActorCreated), global::Proto.Client.ClientProxyActorCreated.Parser, new[]{ "ClientPID", "ProxyPID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Client.ClientMessageBatch), global::Proto.Client.ClientMessageBatch.Parser, new[]{ "TypeNames", "TargetPids", "Envelopes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreateClientProxyActor : pb::IMessage<CreateClientProxyActor> {
    private static readonly pb::MessageParser<CreateClientProxyActor> _parser = new pb::MessageParser<CreateClientProxyActor>(() => new CreateClientProxyActor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateClientProxyActor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Client.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientProxyActor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientProxyActor(CreateClientProxyActor other) : this() {
      clientPID_ = other.clientPID_ != null ? other.clientPID_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientProxyActor Clone() {
      return new CreateClientProxyActor(this);
    }

    /// <summary>Field number for the "clientPID" field.</summary>
    public const int ClientPIDFieldNumber = 1;
    private global::Proto.PID clientPID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID ClientPID {
      get { return clientPID_; }
      set {
        clientPID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateClientProxyActor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateClientProxyActor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClientPID, other.ClientPID)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (clientPID_ != null) hash ^= ClientPID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (clientPID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClientPID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (clientPID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientPID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateClientProxyActor other) {
      if (other == null) {
        return;
      }
      if (other.clientPID_ != null) {
        if (clientPID_ == null) {
          clientPID_ = new global::Proto.PID();
        }
        ClientPID.MergeFrom(other.ClientPID);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (clientPID_ == null) {
              clientPID_ = new global::Proto.PID();
            }
            input.ReadMessage(clientPID_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientProxyActorCreated : pb::IMessage<ClientProxyActorCreated> {
    private static readonly pb::MessageParser<ClientProxyActorCreated> _parser = new pb::MessageParser<ClientProxyActorCreated>(() => new ClientProxyActorCreated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientProxyActorCreated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Client.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientProxyActorCreated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientProxyActorCreated(ClientProxyActorCreated other) : this() {
      clientPID_ = other.clientPID_ != null ? other.clientPID_.Clone() : null;
      proxyPID_ = other.proxyPID_ != null ? other.proxyPID_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientProxyActorCreated Clone() {
      return new ClientProxyActorCreated(this);
    }

    /// <summary>Field number for the "clientPID" field.</summary>
    public const int ClientPIDFieldNumber = 1;
    private global::Proto.PID clientPID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID ClientPID {
      get { return clientPID_; }
      set {
        clientPID_ = value;
      }
    }

    /// <summary>Field number for the "proxyPID" field.</summary>
    public const int ProxyPIDFieldNumber = 2;
    private global::Proto.PID proxyPID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID ProxyPID {
      get { return proxyPID_; }
      set {
        proxyPID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientProxyActorCreated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientProxyActorCreated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClientPID, other.ClientPID)) return false;
      if (!object.Equals(ProxyPID, other.ProxyPID)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (clientPID_ != null) hash ^= ClientPID.GetHashCode();
      if (proxyPID_ != null) hash ^= ProxyPID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (clientPID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClientPID);
      }
      if (proxyPID_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ProxyPID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (clientPID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientPID);
      }
      if (proxyPID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProxyPID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientProxyActorCreated other) {
      if (other == null) {
        return;
      }
      if (other.clientPID_ != null) {
        if (clientPID_ == null) {
          clientPID_ = new global::Proto.PID();
        }
        ClientPID.MergeFrom(other.ClientPID);
      }
      if (other.proxyPID_ != null) {
        if (proxyPID_ == null) {
          proxyPID_ = new global::Proto.PID();
        }
        ProxyPID.MergeFrom(other.ProxyPID);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (clientPID_ == null) {
              clientPID_ = new global::Proto.PID();
            }
            input.ReadMessage(clientPID_);
            break;
          }
          case 18: {
            if (proxyPID_ == null) {
              proxyPID_ = new global::Proto.PID();
            }
            input.ReadMessage(proxyPID_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClientMessageBatch : pb::IMessage<ClientMessageBatch> {
    private static readonly pb::MessageParser<ClientMessageBatch> _parser = new pb::MessageParser<ClientMessageBatch>(() => new ClientMessageBatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientMessageBatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Client.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMessageBatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMessageBatch(ClientMessageBatch other) : this() {
      typeNames_ = other.typeNames_.Clone();
      targetPids_ = other.targetPids_.Clone();
      envelopes_ = other.envelopes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMessageBatch Clone() {
      return new ClientMessageBatch(this);
    }

    /// <summary>Field number for the "type_names" field.</summary>
    public const int TypeNamesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_typeNames_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> typeNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> TypeNames {
      get { return typeNames_; }
    }

    /// <summary>Field number for the "target_pids" field.</summary>
    public const int TargetPidsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Proto.PID> _repeated_targetPids_codec
        = pb::FieldCodec.ForMessage(18, global::Proto.PID.Parser);
    private readonly pbc::RepeatedField<global::Proto.PID> targetPids_ = new pbc::RepeatedField<global::Proto.PID>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Proto.PID> TargetPids {
      get { return targetPids_; }
    }

    /// <summary>Field number for the "envelopes" field.</summary>
    public const int EnvelopesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Proto.Remote.MessageEnvelope> _repeated_envelopes_codec
        = pb::FieldCodec.ForMessage(26, global::Proto.Remote.MessageEnvelope.Parser);
    private readonly pbc::RepeatedField<global::Proto.Remote.MessageEnvelope> envelopes_ = new pbc::RepeatedField<global::Proto.Remote.MessageEnvelope>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Proto.Remote.MessageEnvelope> Envelopes {
      get { return envelopes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientMessageBatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientMessageBatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!typeNames_.Equals(other.typeNames_)) return false;
      if(!targetPids_.Equals(other.targetPids_)) return false;
      if(!envelopes_.Equals(other.envelopes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= typeNames_.GetHashCode();
      hash ^= targetPids_.GetHashCode();
      hash ^= envelopes_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      typeNames_.WriteTo(output, _repeated_typeNames_codec);
      targetPids_.WriteTo(output, _repeated_targetPids_codec);
      envelopes_.WriteTo(output, _repeated_envelopes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += typeNames_.CalculateSize(_repeated_typeNames_codec);
      size += targetPids_.CalculateSize(_repeated_targetPids_codec);
      size += envelopes_.CalculateSize(_repeated_envelopes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientMessageBatch other) {
      if (other == null) {
        return;
      }
      typeNames_.Add(other.typeNames_);
      targetPids_.Add(other.targetPids_);
      envelopes_.Add(other.envelopes_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            typeNames_.AddEntriesFrom(input, _repeated_typeNames_codec);
            break;
          }
          case 18: {
            targetPids_.AddEntriesFrom(input, _repeated_targetPids_codec);
            break;
          }
          case 26: {
            envelopes_.AddEntriesFrom(input, _repeated_envelopes_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
