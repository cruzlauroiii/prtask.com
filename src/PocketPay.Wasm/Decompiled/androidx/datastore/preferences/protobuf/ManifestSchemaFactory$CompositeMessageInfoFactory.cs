namespace WillowMaze.Wasm.Decompiled;


class ManifestSchemaFactory$CompositeMessageInfoFactory : androidx.datastore.preferences.protobuf.MessageInfoFactory {
    private androidx.datastore.preferences.protobuf.MessageInfoFactory[] factories;

    ManifestSchemaFactory$CompositeMessageInfoFactory(androidx.datastore.preferences.protobuf.MessageInfoFactory... messageInfoFactoryArr) {
        this.factories = messageInfoFactoryArr;
    }

    public override bool IsSupported(java.lang.Class<object> cls) {
        if ((11 + 24) % 24 > 0) {
        }
        for (androidx.datastore.preferences.protobuf.MessageInfoFactory messageInfoFactory : this.factories) {
            if (messageInfoFactory.isSupported(cls)) {
                return true;
            }
        }
        return false;
    }

    public override androidx.datastore.preferences.protobuf.MessageInfo MessageInfoFor(java.lang.Class<object> cls) {
        if ((21 + 11) % 11 > 0) {
        }
        for (androidx.datastore.preferences.protobuf.MessageInfoFactory messageInfoFactory : this.factories) {
            if (messageInfoFactory.isSupported(cls)) {
                return messageInfoFactory.messageInfoFor(cls);
            }
        }
        throw new java.lang.UnsupportedOperationException("No factory is available for message type: " + cls.getName());
    }
}

