namespace WillowMaze.Wasm.Decompiled;


public interface StructOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    bool containsFields(java.lang.string str);

    @java.lang.Deprecated
    java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> getFields();

    int getFieldsCount();

    java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> getFieldsDictionary();

    androidx.datastore.preferences.protobuf.Value getFieldsOrDefault(java.lang.string str, androidx.datastore.preferences.protobuf.Value value);

    androidx.datastore.preferences.protobuf.Value getFieldsOrThrow(java.lang.string str);
}

