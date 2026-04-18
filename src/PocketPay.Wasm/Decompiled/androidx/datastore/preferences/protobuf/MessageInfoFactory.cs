namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface MessageInfoFactory {
    bool isSupported(java.lang.Class<object> cls);

    androidx.datastore.preferences.protobuf.MessageInfo messageInfoFor(java.lang.Class<object> cls);
}

