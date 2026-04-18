namespace WillowMaze.Wasm.Decompiled;


public interface FieldHashSet$FieldDescriptorLite<T : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<T>> : java.lang.IComparable<T> {
    androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> getEnumType();

    androidx.datastore.preferences.protobuf.WireFormat$JavaType getLiteJavaType();

    androidx.datastore.preferences.protobuf.WireFormat$FieldType getLiteType();

    int getNumber();

    androidx.datastore.preferences.protobuf.MessageLite$Builder internalMergeFrom(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.MessageLite messageLite);

    bool isPacked();

    bool isRepeated();
}

