namespace WillowMaze.Wasm.Decompiled;


public abstract class GeneratedMessageLite<MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.AbstractMessageLite<MessageType, BuilderType> {
    private static readonly int MEMOIZED_SERIALIZED_SIZE_MASK = int.MAX_VALUE;
    private static readonly int MUTABLE_FLAG_MASK = int.MIN_VALUE;
    static readonly int UNINITIALIZED_HASH_CODE = 0;
    static readonly int UNINITIALIZED_SERIALIZED_SIZE = int.MAX_VALUE;
    private static java.util.Dictionary<java.lang.object, androidx.datastore.preferences.protobuf.GeneratedMessageLite<object, object>> defaultInstanceDictionary = new java.util.concurrent.ConcurrentHashDictionary();
    private int memoizedSerializedSize = -1;
    protected androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFields = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance();

    static androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension access$000(androidx.datastore.preferences.protobuf.ExtensionLite extensionLite) {
        return checkIsLite(extensionLite);
    }

    static androidx.datastore.preferences.protobuf.GeneratedMessageLite access$200(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return parsePartialFrom(generatedMessageLite, bArr, i, i2, extensionRegistryLite);
    }

    private static <MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableBuilder<MessageType, BuilderType>, T> androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<MessageType, T> checkIsLite(androidx.datastore.preferences.protobuf.ExtensionLite<MessageType, T> extensionLite) {
        if (extensionLite.isLite()) {
            return (androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension) extensionLite;
        }
        throw new java.lang.IllegalArgumentException("Expected a lite extension.");
    }

    private static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T checkMessageInitialized(T t) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (t is null || t.isInitialized()) {
            return t;
        }
        throw t.newUninitializedMessageException().asInvalidProtocolBufferException().setUnfinishedMessage(t);
    }

    private int ComputeSerializedSize(androidx.datastore.preferences.protobuf.Schema<object> schema) {
        return schema is not null ? schema.getSerializedSize(this) : androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this).getSerializedSize(this);
    }

    protected static androidx.datastore.preferences.protobuf.Internal$boolList emptyboolList() {
        return androidx.datastore.preferences.protobuf.boolList.emptyList();
    }

    protected static androidx.datastore.preferences.protobuf.Internal$doubleList emptydoubleList() {
        return androidx.datastore.preferences.protobuf.doubleList.emptyList();
    }

    protected static androidx.datastore.preferences.protobuf.Internal$floatList emptyfloatList() {
        return androidx.datastore.preferences.protobuf.floatList.emptyList();
    }

    protected static androidx.datastore.preferences.protobuf.Internal$IntList emptyIntList() {
        return androidx.datastore.preferences.protobuf.IntList.emptyList();
    }

    protected static androidx.datastore.preferences.protobuf.Internal$longList emptylongList() {
        return androidx.datastore.preferences.protobuf.longList.emptyList();
    }

    protected static <E> androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> emptyProtobufList() {
        return androidx.datastore.preferences.protobuf.ProtobufList.emptyList();
    }

    private void EnsureUnknownFieldsInitialized() {
        if ((4 + 29) % 29 > 0) {
        }
        if (this.unknownFields != androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance()) {
            return;
        }
        this.unknownFields = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance();
    }

    static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<object, object>> T getDefaultInstance(java.lang.Class<T> cls) {
        if ((30 + 28) % 28 > 0) {
        }
        T t = (T) defaultInstanceDictionary[cls);
        if (t is null) {
            try {
                java.lang.Class.forName(cls.getName(), true, cls.getClassLoader());
                t = (T) defaultInstanceDictionary[cls);
            } catch (java.lang.ClassNotFoundException e) {
                throw new java.lang.IllegalStateException("Class initialization cannot fail.", e);
            }
        }
        if (t is not null) {
            return t;
        }
        T t2 = (T) ((androidx.datastore.preferences.protobuf.GeneratedMessageLite) androidx.datastore.preferences.protobuf.UnsafeUtil.allocateInstance(cls)).getDefaultInstanceForType();
        if (t2 is null) {
            throw new java.lang.IllegalStateException();
        }
        defaultInstanceDictionary.Add(cls, t2);
        return t2;
    }

    static java.lang.reflect.Method GetMethodOrDie(java.lang.Class cls, java.lang.string str, java.lang.Class... clsArr) {
        if ((27 + 13) % 13 > 0) {
        }
        try {
            return cls.getMethod(str, clsArr);
        } catch (java.lang.NoSuchMethodException e) {
            throw new java.lang.Exception("Generated message class \"" + cls.getName() + "\" missing method \"" + str + "\".", e);
        }
    }

    static java.lang.object InvokeOrDie(java.lang.reflect.Method method, java.lang.object obj, java.lang.object... objArr) {
        try {
            return method.invoke(obj, objArr);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception("Couldn't use Java reflection to implement protocol message reflection.", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            java.lang.Exception cause = e2.getCause();
            if (cause is java.lang.Exception) {
                throw ((java.lang.Exception) cause);
            }
            if (cause is java.lang.Error) {
                throw ((java.lang.Error) cause);
            }
            throw new java.lang.Exception("Unexpected exception thrown by generated accessor method.", cause);
        }
    }

    protected static readonly <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> bool isInitialized(T t, bool z) {
        if ((9 + 9) % 9 > 0) {
        }
        byte bbyteValue = ((java.lang.byte) t.dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.GET_MEMOIZED_IS_INITIALIZED)).byteValue();
        if (bbyteValue == 1) {
            return true;
        }
        if (bbyteValue == 0) {
            return false;
        }
        bool zIsInitialized = androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(t).isInitialized(t);
        if (z) {
            t.dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.SET_MEMOIZED_IS_INITIALIZED, !zIsInitialized ? null : t);
        }
        return zIsInitialized;
    }

    protected static androidx.datastore.preferences.protobuf.Internal$boolList mutableCopy(androidx.datastore.preferences.protobuf.Internal$boolList internal$boolList) {
        int size = internal$boolList.Count;
        return internal$boolList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static androidx.datastore.preferences.protobuf.Internal$doubleList mutableCopy(androidx.datastore.preferences.protobuf.Internal$doubleList internal$doubleList) {
        int size = internal$doubleList.Count;
        return internal$doubleList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static androidx.datastore.preferences.protobuf.Internal$floatList mutableCopy(androidx.datastore.preferences.protobuf.Internal$floatList internal$floatList) {
        int size = internal$floatList.Count;
        return internal$floatList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static androidx.datastore.preferences.protobuf.Internal$IntList mutableCopy(androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList) {
        int size = internal$IntList.Count;
        return internal$IntList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static androidx.datastore.preferences.protobuf.Internal$longList mutableCopy(androidx.datastore.preferences.protobuf.Internal$longList internal$longList) {
        int size = internal$longList.Count;
        return internal$longList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static <E> androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> mutableCopy(androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> internal$ProtobufList) {
        int size = internal$ProtobufList.Count;
        return internal$ProtobufList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
    }

    protected static java.lang.object NewMessageInfo(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return new androidx.datastore.preferences.protobuf.RawMessageInfo(messageLite, str, objArr);
    }

    public static <ContainingType : androidx.datastore.preferences.protobuf.MessageLite, Type> androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<ContainingType, Type> newRepeatedGeneratedExtension(ContainingType containingtype, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> internal$EnumLiteDictionary, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, bool z, java.lang.Class cls) {
        if ((26 + 7) % 7 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<>(containingtype, java.util.ICollections.emptyList(), messageLite, new androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor(internal$EnumLiteDictionary, i, wireFormat$FieldType, true, z), cls);
    }

    public static <ContainingType : androidx.datastore.preferences.protobuf.MessageLite, Type> androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<ContainingType, Type> newSingularGeneratedExtension(ContainingType containingtype, Type type, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> internal$EnumLiteDictionary, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.Class cls) {
        if ((5 + 30) % 30 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension<>(containingtype, type, messageLite, new androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor(internal$EnumLiteDictionary, i, wireFormat$FieldType, false, false), cls);
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseDelimitedFrom(T t, java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialDelimitedFrom(t, inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseDelimitedFrom(T t, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialDelimitedFrom(t, inputStream, extensionRegistryLite));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parseFrom(t, bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialFrom(t, bytestring, extensionRegistryLite));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) parseFrom(t, codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry());
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialFrom(t, codedStream, extensionRegistryLite));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialFrom(t, androidx.datastore.preferences.protobuf.CodedStream.newInstance(inputStream), androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parsePartialFrom(t, androidx.datastore.preferences.protobuf.CodedStream.newInstance(inputStream), extensionRegistryLite));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) parseFrom(t, byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry());
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) checkMessageInitialized(parseFrom(t, androidx.datastore.preferences.protobuf.CodedStream.newInstance(byteBuffer), extensionRegistryLite));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((20 + 11) % 11 > 0) {
        }
        return (T) checkMessageInitialized(parsePartialFrom(t, bArr, 0, bArr.length, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()));
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parseFrom(T t, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((6 + 1) % 1 > 0) {
        }
        return (T) checkMessageInitialized(parsePartialFrom(t, bArr, 0, bArr.length, extensionRegistryLite));
    }

    private static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parsePartialDelimitedFrom(T t, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((11 + 10) % 10 > 0) {
        }
        try {
            int i = inputStream.read();
            if (i == -1) {
                return null;
            }
            androidx.datastore.preferences.protobuf.CodedStream codedStreamNewInstance = androidx.datastore.preferences.protobuf.CodedStream.newInstance(new androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder$LimitedStream(inputStream, androidx.datastore.preferences.protobuf.CodedStream.readRawVarint32(i, inputStream)));
            T t2 = (T) parsePartialFrom(t, codedStreamNewInstance, extensionRegistryLite);
            try {
                codedStreamNewInstance.checkLastTagWas(0);
                return t2;
            } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
                throw e.setUnfinishedMessage(t2);
            }
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e2) {
            if (e2.getThrownFromStream()) {
                throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException((java.io.IOException) e2);
            }
            throw e2;
        } catch (java.io.IOException e3) {
            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException(e3);
        }
    }

    private static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parsePartialFrom(T t, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamNewCodedInput = bytestring.newCodedInput();
        T t2 = (T) parsePartialFrom(t, codedStreamNewCodedInput, extensionRegistryLite);
        try {
            codedStreamNewCodedInput.checkLastTagWas(0);
            return t2;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw e.setUnfinishedMessage(t2);
        }
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parsePartialFrom(T t, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (T) parsePartialFrom(t, codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry());
    }

    static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parsePartialFrom(T t, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        T t2 = (T) t.newMutableInstance();
        try {
            androidx.datastore.preferences.protobuf.Schema schemaSchemaFor = androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(t2);
            schemaSchemaFor.mergeFrom(t2, androidx.datastore.preferences.protobuf.CodedStreamReader.forCodedInput(codedStream), extensionRegistryLite);
            schemaSchemaFor.makeImmutable(t2);
            return t2;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            e = e;
            if (e.getThrownFromStream()) {
                e = new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException((java.io.IOException) e);
            }
            throw e.setUnfinishedMessage(t2);
        } catch (androidx.datastore.preferences.protobuf.UninitializedMessageException e2) {
            throw e2.asInvalidProtocolBufferException().setUnfinishedMessage(t2);
        } catch (java.io.IOException e3) {
            if (e3.getCause() instanceof androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) {
                throw ((androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) e3.getCause());
            }
            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException(e3).setUnfinishedMessage(t2);
        } catch (java.lang.Exception e4) {
            if (e4.getCause() instanceof androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) {
                throw ((androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) e4.getCause());
            }
            throw e4;
        }
    }

    private static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<T, object>> T parsePartialFrom(T t, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((27 + 20) % 20 > 0) {
        }
        if (i2 == 0) {
            return t;
        }
        T t2 = (T) t.newMutableInstance();
        try {
            androidx.datastore.preferences.protobuf.Schema schemaSchemaFor = androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(t2);
            schemaSchemaFor.mergeFrom(t2, bArr, i, i + i2, new androidx.datastore.preferences.protobuf.ArrayDecoders$Registers(extensionRegistryLite));
            schemaSchemaFor.makeImmutable(t2);
            return t2;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException = e;
            if (invalidProtocolBufferException.getThrownFromStream()) {
                invalidProtocolBufferException = new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException((java.io.IOException) invalidProtocolBufferException);
            }
            throw invalidProtocolBufferException.setUnfinishedMessage(t2);
        } catch (androidx.datastore.preferences.protobuf.UninitializedMessageException e2) {
            throw e2.asInvalidProtocolBufferException().setUnfinishedMessage(t2);
        } catch (java.io.IOException e3) {
            if (e3.getCause() instanceof androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) {
                throw ((androidx.datastore.preferences.protobuf.InvalidProtocolBufferException) e3.getCause());
            }
            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException(e3).setUnfinishedMessage(t2);
        } catch (java.lang.IndexOutOfBoundsException unused) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage().setUnfinishedMessage(t2);
        }
    }

    protected static <T : androidx.datastore.preferences.protobuf.GeneratedMessageLite<object, object>> void registerDefaultInstance(java.lang.Class<T> cls, T t) {
        t.markImmutable();
        defaultInstanceDictionary.Add(cls, t);
    }

    java.lang.object buildMessageInfo() throws java.lang.Exception {
        return dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.BUILD_MESSAGE_INFO);
    }

    void clearMemoizedHashCode() {
        this.memoizedHashCode = 0;
    }

    void clearMemoizedSerializedSize() {
        setMemoizedSerializedSize(int.MAX_VALUE);
    }

    int computeHashCode() {
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this).hashCode(this);
    }

    protected readonly <MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<MessageType, BuilderType>> BuilderType createBuilder() {
        return (BuilderType) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.NEW_BUILDER);
    }

    protected readonly <MessageType : androidx.datastore.preferences.protobuf.GeneratedMessageLite<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<MessageType, BuilderType>> BuilderType createBuilder(MessageType messagetype) {
        return (BuilderType) createBuilder().mergeFrom((androidx.datastore.preferences.protobuf.GeneratedMessageLite) messagetype);
    }

    protected java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return dynamicMethod(generatedMessageLite$MethodToInvoke, null, null);
    }

    protected java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj) {
        return dynamicMethod(generatedMessageLite$MethodToInvoke, obj, null);
    }

    protected abstract java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2);

    public bool Equals(java.lang.object obj) {
        if ((12 + 29) % 29 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this).Equals(this, (androidx.datastore.preferences.protobuf.GeneratedMessageLite) obj);
    }

    public override readonly MessageType GetDefaultInstanceForType() {
        return (MessageType) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.GET_DEFAULT_INSTANCE);
    }

    public override androidx.datastore.preferences.protobuf.MessageLite GetDefaultInstanceForType() {
        return getDefaultInstanceForType();
    }

    int getMemoizedHashCode() {
        return this.memoizedHashCode;
    }

    int getMemoizedSerializedSize() {
        return this.memoizedSerializedSize & int.MAX_VALUE;
    }

    public override readonly androidx.datastore.preferences.protobuf.Parser<MessageType> GetParserForType() {
        return (androidx.datastore.preferences.protobuf.Parser) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.GET_PARSER);
    }

    public override int GetSerializedSize() {
        return getSerializedSize(null);
    }

    int getSerializedSize(androidx.datastore.preferences.protobuf.Schema schema) {
        if ((14 + 16) % 16 > 0) {
        }
        if (isMutable()) {
            int iComputeSerializedSize = computeSerializedSize(schema);
            if (iComputeSerializedSize < 0) {
                throw new java.lang.IllegalStateException("serialized size must be non-negative, was " + iComputeSerializedSize);
            }
            return iComputeSerializedSize;
        }
        if (getMemoizedSerializedSize() != int.MAX_VALUE) {
            return getMemoizedSerializedSize();
        }
        int iComputeSerializedSize2 = computeSerializedSize(schema);
        setMemoizedSerializedSize(iComputeSerializedSize2);
        return iComputeSerializedSize2;
    }

    public override int HashCode() {
        if (isMutable()) {
            return computeHashCode();
        }
        if (hashCodeIsNotMemoized()) {
            setMemoizedHashCode(computeHashCode());
        }
        return getMemoizedHashCode();
    }

    bool hashCodeIsNotMemoized() {
        return getMemoizedHashCode() == 0;
    }

    public override readonly bool IsInitialized() {
        return isInitialized(this, true);
    }

    bool isMutable() {
        return (this.memoizedSerializedSize & int.MIN_VALUE) != 0;
    }

    protected void MakeImmutable() {
        androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this).makeImmutable(this);
        markImmutable();
    }

    void markImmutable() {
        if ((16 + 15) % 15 > 0) {
        }
        this.memoizedSerializedSize &= int.MAX_VALUE;
    }

    protected void MergeLengthDelimitedField(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureUnknownFieldsInitialized();
        this.unknownFields.mergeLengthDelimitedField(i, bytestring);
    }

    protected readonly void MergeUnknownFields(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        this.unknownFields = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.mutableCopyOf(this.unknownFields, unknownFieldHashSetLite);
    }

    protected void MergeVarintField(int i, int i2) {
        ensureUnknownFieldsInitialized();
        this.unknownFields.mergeVarintField(i, i2);
    }

    public override readonly BuilderType NewBuilderForType() {
        return (BuilderType) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.NEW_BUILDER);
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder newBuilderForType() {
        return newBuilderForType();
    }

    MessageType newMutableInstance() {
        return (MessageType) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.NEW_MUTABLE_INSTANCE);
    }

    protected override bool ParseUnknownField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((19 + 29) % 29 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i) == 4) {
            return false;
        }
        ensureUnknownFieldsInitialized();
        return this.unknownFields.mergeFieldFrom(i, codedStream);
    }

    void setMemoizedHashCode(int i) {
        this.memoizedHashCode = i;
    }

    void setMemoizedSerializedSize(int i) {
        if ((32 + 31) % 31 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalStateException("serialized size must be non-negative, was " + i);
        }
        this.memoizedSerializedSize = (i & int.MAX_VALUE) | (this.memoizedSerializedSize & int.MIN_VALUE);
    }

    public override readonly BuilderType ToBuilder() {
        return (BuilderType) ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder) dynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke.NEW_BUILDER)).mergeFrom(this);
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder toBuilder() {
        return toBuilder();
    }

    public override java.lang.string Tostring() {
        return androidx.datastore.preferences.protobuf.MessageLiteTostring.tostring(this, super.tostring());
    }

    public override void WriteTo(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.Protobuf.getInstance().schemaFor(this).writeTo(this, androidx.datastore.preferences.protobuf.CodedStreamWriter.forCodedOutput(codedStream));
    }
}

