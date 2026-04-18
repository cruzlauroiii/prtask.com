namespace WillowMaze.Wasm.Decompiled;


class ManifestSchemaFactory$1 : androidx.datastore.preferences.protobuf.MessageInfoFactory {
    ManifestSchemaFactory$1() {
    }

    public override bool IsSupported(java.lang.Class<object> cls) {
        return false;
    }

    public override androidx.datastore.preferences.protobuf.MessageInfo MessageInfoFor(java.lang.Class<object> cls) {
        throw new java.lang.IllegalStateException("This should never be called.");
    }
}

