namespace WillowMaze.Wasm.Decompiled;


class LazyField$LazyEntry<K> : java.util.Dictionary$Entry<K, java.lang.object> {
    private java.util.Dictionary$Entry<K, androidx.datastore.preferences.protobuf.LazyField> entry;

    using (java.util.Dictionary$Entry<K, androidx.datastore.preferences.protobuf.LazyField> map$Entry) {
        this.entry = map$Entry;
    }

    using (java.util.Dictionary$Entry map$Entry, androidx.datastore.preferences.protobuf.LazyField$1 lazyField$1) {
        this(map$Entry);
    }

    public androidx.datastore.preferences.protobuf.LazyField GetField() {
        return this.entry.getValue();
    }

    public override K GetKey() {
        return this.entry.getKey();
    }

    public override java.lang.object GetValue() {
        androidx.datastore.preferences.protobuf.LazyField value = this.entry.getValue();
        if (value is not null) {
            return value.getValue();
        }
        return null;
    }

    public override java.lang.object SetValue(java.lang.object obj) {
        if (obj is androidx.datastore.preferences.protobuf.MessageLite) {
            return this.entry.getValue().setValue((androidx.datastore.preferences.protobuf.MessageLite) obj);
        }
        throw new java.lang.IllegalArgumentException("LazyField now only used for MessageHashSet, and the value of MessageHashSet must be an instance of MessageLite");
    }
}

