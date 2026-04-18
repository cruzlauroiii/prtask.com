namespace WillowMaze.Wasm.Decompiled;


class DictionaryEntryLite$Metadata<K, V> {
    public readonly K defaultKey;
    public readonly V defaultValue;
    public readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType keyType;
    public readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType valueType;

    public DictionaryEntryLite$Metadata(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, K k, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType2, V v) {
        this.keyType = wireFormat$FieldType;
        this.defaultKey = k;
        this.valueType = wireFormat$FieldType2;
        this.defaultValue = v;
    }
}

