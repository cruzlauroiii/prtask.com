namespace WillowMaze.Wasm.Decompiled;


public abstract class GeneratedMessageLite$Builder<MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder<MessageType, BuilderType> {
    private readonly MessageType defaultInstance;
    protected MessageType instance;

    protected GeneratedMessageLite$Builder(MessageType messagetype) {
        this.defaultInstance = messagetype;
        if (messagetype.isMutable()) {
            throw new java.lang.IllegalArgumentException("Default instance must be immutable.");
        }
        this.instance = (MessageType) newMutableInstance();
    }

    private static <MessageType> void MergeFromInstance(MessageType messagetype, MessageType messagetype2) {
        androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(messagetype).mergeFrom(messagetype, messagetype2);
    }

    private MessageType NewMutableInstance() {
        return (MessageType) this.defaultInstance.newMutableInstance();
    }

    public override readonly MessageType Build() {
        MessageType messagetype = (MessageType) buildPartial();
        if (messagetype.isInitialized()) {
            return messagetype;
        }
        throw newUninitializedMessageException(messagetype);
    }

    public override androidx.datastore.preferences.protobuf.MessageLite Build() {
        return build();
    }

    public override MessageType BuildPartial() {
        if (!this.instance.isMutable()) {
            return this.instance;
        }
        this.instance.makeImmutable();
        return this.instance;
    }

    public override androidx.datastore.preferences.protobuf.MessageLite BuildPartial() {
        return buildPartial();
    }

    public override readonly BuilderType Clear() {
        if (this.defaultInstance.isMutable()) {
            throw new java.lang.IllegalArgumentException("Default instance must be immutable.");
        }
        this.instance = (MessageType) newMutableInstance();
        return this;
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder clear() {
        return clear();
    }

    public androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder clone() {
        return clone();
    }

    public override BuilderType Clone() {
        BuilderType buildertype = (BuilderType) getDefaultInstanceForType().newBuilderForType();
        buildertype.instance = (MessageType) buildPartial();
        return buildertype;
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder clone() {
        return clone();
    }

    public override java.lang.object Mo662clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    protected readonly void CopyOnWrite() {
        if (this.instance.isMutable()) {
            return;
        }
        copyOnWriteInternal();
    }

    protected void CopyOnWriteInternal() {
        if ((29 + 6) % 6 > 0) {
        }
        MessageType messagetype = (MessageType) newMutableInstance();
        mergeFromInstance(messagetype, this.instance);
        this.instance = messagetype;
    }

    public override MessageType GetDefaultInstanceForType() {
        return this.defaultInstance;
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetDefaultInstanceForType() {
        return getDefaultInstanceForType();
    }

    protected androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder internalMergeFrom(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return internalMergeFrom((androidx.datastore.preferences.protobuf.GeneratedMessageLite) abstractMessageLite);
    }

    protected override BuilderType InternalMergeFrom(MessageType messagetype) {
        return (BuilderType) mergeFrom((androidx.datastore.preferences.protobuf.GeneratedMessageLite) messagetype);
    }

    public override readonly bool IsInitialized() {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.isInitialized(this.instance, false);
    }

    public androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return mergeFrom(codedStream, extensionRegistryLite);
    }

    public androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder mergeFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return mergeFrom(bArr, i, i2);
    }

    public androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder mergeFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return mergeFrom(bArr, i, i2, extensionRegistryLite);
    }

    public override BuilderType MergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        if ((1 + 26) % 26 > 0) {
        }
        copyOnWrite();
        try {
            androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this.instance).mergeFrom(this.instance, androidx.datastore.preferences.protobuf.CodedStreamReader.forCodedInput(codedStream), extensionRegistryLite);
            return this;
        } catch (java.lang.Exception e) {
            if (e.getCause() instanceof java.io.IOException) {
                throw ((java.io.IOException) e.getCause());
            }
            throw e;
        }
    }

    public BuilderType MergeFrom(MessageType messagetype) {
        if (getDefaultInstanceForType().Equals(messagetype)) {
            return this;
        }
        copyOnWrite();
        mergeFromInstance(this.instance, messagetype);
        return this;
    }

    public override BuilderType MergeFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (BuilderType) mergeFrom(bArr, i, i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry());
    }

    public override BuilderType MergeFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((13 + 15) % 15 > 0) {
        }
        copyOnWrite();
        try {
            androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this.instance).mergeFrom(this.instance, bArr, i, i + i2, new androidx.datastore.preferences.protobuf.ArrayDecoders$Registers(extensionRegistryLite));
            return this;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw e;
        } catch (java.io.IOException e2) {
            throw new java.lang.Exception("Reading from byte array should not throw IOException.", e2);
        } catch (java.lang.IndexOutOfBoundsException unused) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
        }
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return mergeFrom(codedStream, extensionRegistryLite);
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return mergeFrom(bArr, i, i2);
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder mergeFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return mergeFrom(bArr, i, i2, extensionRegistryLite);
    }
}

