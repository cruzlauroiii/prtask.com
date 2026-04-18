namespace WillowMaze.Wasm.Decompiled;


protected class GeneratedMessageLite$DefaultInstanceBasedParser<T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> : androidx.datastore.preferences.protobuf.AbstractParser<T> {
    private readonly T defaultInstance;

    public GeneratedMessageLite$DefaultInstanceBasedParser(T t) {
        this.defaultInstance = t;
    }

    public override T ParsePartialFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parsePartialFrom(this.defaultInstance, codedStream, extensionRegistryLite);
    }

    public override T ParsePartialFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) androidx.datastore.preferences.protobuf.GeneratedMessageLite.access$200(this.defaultInstance, bArr, i, i2, extensionRegistryLite);
    }

    public override androidx.datastore.preferences.protobuf.MessageLite ParsePartialFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }
}

