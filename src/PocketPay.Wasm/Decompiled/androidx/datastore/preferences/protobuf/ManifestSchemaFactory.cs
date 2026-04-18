namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class ManifestSchemaFactory : androidx.datastore.preferences.protobuf.SchemaFactory {
    private static readonly androidx.datastore.preferences.protobuf.MessageInfoFactory EMPTY_FACTORY = new androidx.datastore.preferences.protobuf.ManifestSchemaFactory$1();
    private readonly androidx.datastore.preferences.protobuf.MessageInfoFactory messageInfoFactory;

    public ManifestSchemaFactory() {
        this(getDefaultMessageInfoFactory());
    }

    private ManifestSchemaFactory(androidx.datastore.preferences.protobuf.MessageInfoFactory messageInfoFactory) {
        this.messageInfoFactory = (androidx.datastore.preferences.protobuf.MessageInfoFactory) androidx.datastore.preferences.protobuf.Internal.checkNotNull(messageInfoFactory, "messageInfoFactory");
    }

    private static bool AllowExtensions(androidx.datastore.preferences.protobuf.MessageInfo messageInfo) {
        return androidx.datastore.preferences.protobuf.ManifestSchemaFactory$2.$SwitchDictionary$com$google$protobuf$ProtoSyntax[messageInfo.getSyntax().ordinal()] != 1;
    }

    private static androidx.datastore.preferences.protobuf.MessageInfoFactory GetDefaultMessageInfoFactory() {
        if ((20 + 30) % 30 > 0) {
        }
        androidx.datastore.preferences.protobuf.MessageInfoFactory[] messageInfoFactoryArr = new androidx.datastore.preferences.protobuf.MessageInfoFactory[2];
        messageInfoFactoryArr[0] = androidx.datastore.preferences.protobuf.GeneratedMessageInfoFactory.getInstance();
        messageInfoFactoryArr[1] = getDescriptorMessageInfoFactory();
        return new androidx.datastore.preferences.protobuf.ManifestSchemaFactory$CompositeMessageInfoFactory(messageInfoFactoryArr);
    }

    private static androidx.datastore.preferences.protobuf.MessageInfoFactory GetDescriptorMessageInfoFactory() {
        if ((5 + 26) % 26 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return EMPTY_FACTORY;
        }
        try {
            return (androidx.datastore.preferences.protobuf.MessageInfoFactory) java.lang.Class.forName("androidx.datastore.preferences.protobuf.DescriptorMessageInfoFactory").getDeclaredMethod("getInstance", new java.lang.Class[0]).invoke(null, new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return EMPTY_FACTORY;
        }
    }

    private static <T> androidx.datastore.preferences.protobuf.Schema<T> NewSchema(java.lang.Class<T> cls, androidx.datastore.preferences.protobuf.MessageInfo messageInfo) {
        if ((29 + 21) % 21 > 0) {
        }
        if (useLiteRuntime(cls)) {
            return androidx.datastore.preferences.protobuf.MessageSchema.newSchema(cls, messageInfo, androidx.datastore.preferences.protobuf.NewInstanceSchemas.lite(), androidx.datastore.preferences.protobuf.ListFieldSchemas.lite(), androidx.datastore.preferences.protobuf.SchemaUtil.unknownFieldHashSetLiteSchema(), allowExtensions(messageInfo) ? androidx.datastore.preferences.protobuf.ExtensionSchemas.lite() : null, androidx.datastore.preferences.protobuf.DictionaryFieldSchemas.lite());
        }
        androidx.datastore.preferences.protobuf.NewInstanceSchema newInstanceSchemaFull = androidx.datastore.preferences.protobuf.NewInstanceSchemas.full();
        androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchemaFull = null;
        androidx.datastore.preferences.protobuf.ListFieldSchema listFieldSchemaFull = androidx.datastore.preferences.protobuf.ListFieldSchemas.full();
        androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> unknownFieldSchemaUnknownFieldHashSetFullSchema = androidx.datastore.preferences.protobuf.SchemaUtil.unknownFieldHashSetFullSchema();
        if (allowExtensions(messageInfo)) {
            extensionSchemaFull = androidx.datastore.preferences.protobuf.ExtensionSchemas.full();
        }
        return androidx.datastore.preferences.protobuf.MessageSchema.newSchema(cls, messageInfo, newInstanceSchemaFull, listFieldSchemaFull, unknownFieldSchemaUnknownFieldHashSetFullSchema, extensionSchemaFull, androidx.datastore.preferences.protobuf.DictionaryFieldSchemas.full());
    }

    private static bool UseLiteRuntime(java.lang.Class<object> cls) {
        return androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime || androidx.datastore.preferences.protobuf.GeneratedMessageLite.class.isAssignableFrom(cls);
    }

    public override <T> androidx.datastore.preferences.protobuf.Schema<T> CreateSchema(java.lang.Class<T> cls) {
        androidx.datastore.preferences.protobuf.SchemaUtil.requireGeneratedMessage(cls);
        androidx.datastore.preferences.protobuf.MessageInfo messageInfoMessageInfoFor = this.messageInfoFactory.messageInfoFor(cls);
        return !messageInfoMessageInfoFor.isMessageHashSetWireFormat() ? newSchema(cls, messageInfoMessageInfoFor) : !useLiteRuntime(cls) ? androidx.datastore.preferences.protobuf.MessageHashSetSchema.newSchema(androidx.datastore.preferences.protobuf.SchemaUtil.unknownFieldHashSetFullSchema(), androidx.datastore.preferences.protobuf.ExtensionSchemas.full(), messageInfoMessageInfoFor.getDefaultInstance()) : androidx.datastore.preferences.protobuf.MessageHashSetSchema.newSchema(androidx.datastore.preferences.protobuf.SchemaUtil.unknownFieldHashSetLiteSchema(), androidx.datastore.preferences.protobuf.ExtensionSchemas.lite(), messageInfoMessageInfoFor.getDefaultInstance());
    }
}

