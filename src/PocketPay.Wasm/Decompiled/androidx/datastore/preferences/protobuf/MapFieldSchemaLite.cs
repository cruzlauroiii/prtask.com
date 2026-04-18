namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class DictionaryFieldSchemaLite : androidx.datastore.preferences.protobuf.DictionaryFieldSchema {
    DictionaryFieldSchemaLite() {
    }

    private static <K, V> int GetSerializedSizeLite(int i, java.lang.object obj, java.lang.object obj2) {
        if ((26 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.DictionaryFieldLite mapFieldLite = (androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj;
        androidx.datastore.preferences.protobuf.DictionaryEntryLite mapEntryLite = (androidx.datastore.preferences.protobuf.DictionaryEntryLite) obj2;
        int iComputeMessageSize = 0;
        if (mapFieldLite.Count == 0) {
            return 0;
        }
        for (java.util.Dictionary$Entry<K, V> map$Entry : mapFieldLite.entryHashSet()) {
            iComputeMessageSize += mapEntryLite.computeMessageSize(i, map$Entry.getKey(), map$Entry.getValue());
        }
        return iComputeMessageSize;
    }

    private static <K, V> androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> MergeFromLite(java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> mapFieldLiteMutableCopy = (androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj;
        androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> mapFieldLite = (androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj2;
        if (!mapFieldLite.Count == 0) {
            if (!mapFieldLiteMutableCopy.isMutable()) {
                mapFieldLiteMutableCopy = mapFieldLiteMutableCopy.mutableCopy();
            }
            mapFieldLiteMutableCopy.mergeFrom(mapFieldLite);
        }
        return mapFieldLiteMutableCopy;
    }

    public override java.util.Dictionary<object, object> ForDictionaryData(java.lang.object obj) {
        return (androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj;
    }

    public androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<object, object> forDictionaryMetadata(java.lang.object obj) {
        return ((androidx.datastore.preferences.protobuf.DictionaryEntryLite) obj).getMetadata();
    }

    public override java.util.Dictionary<object, object> ForMutableDictionaryData(java.lang.object obj) {
        return (androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj;
    }

    public override int GetSerializedSize(int i, java.lang.object obj, java.lang.object obj2) {
        return getSerializedSizeLite(i, obj, obj2);
    }

    public override bool IsImmutable(java.lang.object obj) {
        return !((androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj).isMutable();
    }

    public override java.lang.object MergeFrom(java.lang.object obj, java.lang.object obj2) {
        return mergeFromLite(obj, obj2);
    }

    public override java.lang.object NewDictionaryField(java.lang.object obj) {
        return androidx.datastore.preferences.protobuf.DictionaryFieldLite.emptyDictionaryField().mutableCopy();
    }

    public override java.lang.object ToImmutable(java.lang.object obj) {
        ((androidx.datastore.preferences.protobuf.DictionaryFieldLite) obj).makeImmutable();
        return obj;
    }
}

