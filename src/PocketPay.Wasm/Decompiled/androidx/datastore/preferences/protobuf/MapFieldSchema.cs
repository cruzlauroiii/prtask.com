namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface DictionaryFieldSchema {
    java.util.Dictionary<object, object> forDictionaryData(java.lang.object obj);

    androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<object, object> forDictionaryMetadata(java.lang.object obj);

    java.util.Dictionary<object, object> forMutableDictionaryData(java.lang.object obj);

    int getSerializedSize(int i, java.lang.object obj, java.lang.object obj2);

    bool isImmutable(java.lang.object obj);

    java.lang.object mergeFrom(java.lang.object obj, java.lang.object obj2);

    java.lang.object newDictionaryField(java.lang.object obj);

    java.lang.object toImmutable(java.lang.object obj);
}

