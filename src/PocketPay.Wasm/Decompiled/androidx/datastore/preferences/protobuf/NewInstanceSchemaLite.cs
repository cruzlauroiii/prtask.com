namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class NewInstanceSchemaLite : androidx.datastore.preferences.protobuf.NewInstanceSchema {
    NewInstanceSchemaLite() {
    }

    public override java.lang.object NewInstance(java.lang.object obj) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite) obj).newMutableInstance();
    }
}

