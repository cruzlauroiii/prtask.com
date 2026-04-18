namespace WillowMaze.Wasm.Decompiled;


public interface MessageLite$Builder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder, java.lang.Cloneable {
    androidx.datastore.preferences.protobuf.MessageLite build();

    androidx.datastore.preferences.protobuf.MessageLite buildPartial();

    androidx.datastore.preferences.protobuf.MessageLite$Builder clear();

    androidx.datastore.preferences.protobuf.MessageLite$Builder clone();

    bool mergeDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException;

    bool mergeDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.MessageLite messageLite);

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(java.io.Stream inputStream) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;
}

