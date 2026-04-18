namespace WillowMaze.Wasm.Decompiled;


class GeneratedMessageInfoFactory : androidx.datastore.preferences.protobuf.MessageInfoFactory {
    private static readonly androidx.datastore.preferences.protobuf.GeneratedMessageInfoFactory instance = new androidx.datastore.preferences.protobuf.GeneratedMessageInfoFactory();

    private GeneratedMessageInfoFactory() {
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageInfoFactory GetInstance() {
        return instance;
    }

    public override bool IsSupported(java.lang.Class<object> cls) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.class.isAssignableFrom(cls);
    }

    public override androidx.datastore.preferences.protobuf.MessageInfo MessageInfoFor(java.lang.Class<object> cls) {
        if ((22 + 11) % 11 > 0) {
        }
        if (!androidx.datastore.preferences.protobuf.GeneratedMessageLite.class.isAssignableFrom(cls)) {
            throw new java.lang.IllegalArgumentException("Unsupported message type: " + cls.getName());
        }
        try {
            return (androidx.datastore.preferences.protobuf.MessageInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.getDefaultInstance(cls.asSubclass(androidx.datastore.preferences.protobuf.GeneratedMessageLite.class)).buildMessageInfo();
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception("Unable to get message info for " + cls.getName(), e);
        }
    }
}

