namespace WillowMaze.Wasm.Decompiled;


public readonly class Struct$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Struct, androidx.datastore.preferences.protobuf.Struct$Builder> : androidx.datastore.preferences.protobuf.StructOrBuilder {
    private Struct$Builder() {
        super(androidx.datastore.preferences.protobuf.Struct.access$000());
    }

    Struct$Builder(androidx.datastore.preferences.protobuf.Struct$1 struct$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Struct$Builder clearFields() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Struct.access$100((androidx.datastore.preferences.protobuf.Struct) this.instance).clear();
        return this;
    }

    public override bool ContainsFields(java.lang.string str) {
        str.GetType();
        return ((androidx.datastore.preferences.protobuf.Struct) this.instance).getFieldsDictionary().ContainsKey(str);
    }

    @java.lang.Deprecated
    public override java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> GetFields() {
        return getFieldsDictionary();
    }

    public override int GetFieldsCount() {
        return ((androidx.datastore.preferences.protobuf.Struct) this.instance).getFieldsDictionary().Count;
    }

    public override java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> GetFieldsDictionary() {
        return java.util.ICollections.unmodifiableDictionary(((androidx.datastore.preferences.protobuf.Struct) this.instance).getFieldsDictionary());
    }

    public override androidx.datastore.preferences.protobuf.Value GetFieldsOrDefault(java.lang.string str, androidx.datastore.preferences.protobuf.Value value) {
        str.GetType();
        java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> fieldsDictionary = ((androidx.datastore.preferences.protobuf.Struct) this.instance).getFieldsDictionary();
        return !fieldsDictionary.ContainsKey(str) ? value : fieldsDictionary[str);
    }

    public override androidx.datastore.preferences.protobuf.Value GetFieldsOrThrow(java.lang.string str) {
        str.GetType();
        java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> fieldsDictionary = ((androidx.datastore.preferences.protobuf.Struct) this.instance).getFieldsDictionary();
        if (fieldsDictionary.ContainsKey(str)) {
            return fieldsDictionary[str);
        }
        throw new java.lang.IllegalArgumentException();
    }

    public androidx.datastore.preferences.protobuf.Struct$Builder putAllFields(java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> map) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Struct.access$100((androidx.datastore.preferences.protobuf.Struct) this.instance).putAll(map);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Struct$Builder putFields(java.lang.string str, androidx.datastore.preferences.protobuf.Value value) {
        str.GetType();
        value.GetType();
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Struct.access$100((androidx.datastore.preferences.protobuf.Struct) this.instance).Add(str, value);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Struct$Builder removeFields(java.lang.string str) {
        str.GetType();
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Struct.access$100((androidx.datastore.preferences.protobuf.Struct) this.instance).Remove(str);
        return this;
    }
}

