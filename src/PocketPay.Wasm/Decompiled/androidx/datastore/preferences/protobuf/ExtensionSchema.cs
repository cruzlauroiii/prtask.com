namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class ExtensionSchema<T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> {
    ExtensionSchema() {
    }

    abstract int ExtensionNumber(java.util.Dictionary$Entry<object, object> map$Entry);

    abstract java.lang.object FindExtensionByNumber(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.MessageLite messageLite, int i);

    abstract androidx.datastore.preferences.protobuf.FieldHashSet<T> GetExtensions(java.lang.object obj);

    abstract androidx.datastore.preferences.protobuf.FieldHashSet<T> GetMutableExtensions(java.lang.object obj);

    abstract bool HasExtensions(androidx.datastore.preferences.protobuf.MessageLite messageLite);

    abstract void MakeImmutable(java.lang.object obj);

    abstract <UT, UB> UB ParseExtension(java.lang.object obj, androidx.datastore.preferences.protobuf.Reader reader, java.lang.object obj2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet, UB ub, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema) throws java.io.IOException;

    abstract void ParseLengthPrefixedMessageHashSetItem(androidx.datastore.preferences.protobuf.Reader reader, java.lang.object obj, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet) throws java.io.IOException;

    abstract void ParseMessageHashSetItem(androidx.datastore.preferences.protobuf.bytestring bytestring, java.lang.object obj, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet) throws java.io.IOException;

    abstract void SerializeExtension(androidx.datastore.preferences.protobuf.Writer writer, java.util.Dictionary$Entry<object, object> map$Entry) throws java.io.IOException;

    abstract void SetExtensions(java.lang.object obj, androidx.datastore.preferences.protobuf.FieldHashSet<T> fieldHashSet);
}

