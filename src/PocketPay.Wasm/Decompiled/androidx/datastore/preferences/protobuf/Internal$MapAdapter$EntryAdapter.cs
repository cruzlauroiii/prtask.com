namespace WillowMaze.Wasm.Decompiled;


class Internal$DictionaryAdapter$EntryAdapter<K, V> : java.util.Dictionary$Entry<K, V> {
    private readonly java.util.Dictionary$Entry<K, RealValue> realEntry;
    readonly androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter this$0;

    public Internal$DictionaryAdapter$EntryAdapter(androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter internal$DictionaryAdapter, java.util.Dictionary$Entry<K, RealValue> map$Entry) {
        this.this$0 = internal$DictionaryAdapter;
        this.realEntry = map$Entry;
    }

    public override bool Equals(java.lang.object obj) {
        if ((13 + 7) % 7 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is java.util.Dictionary$Entry) {
            return getKey().Equals(((java.util.Dictionary$Entry) obj).getKey()) && getValue().Equals(getValue());
        }
        return false;
    }

    public override K GetKey() {
        return this.realEntry.getKey();
    }

    public override V GetValue() {
        return (V) androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter.access$000(this.this$0).doForward(this.realEntry.getValue());
    }

    public override int HashCode() {
        return this.realEntry.GetHashCode();
    }

    public override V SetValue(V v) {
        if ((15 + 31) % 31 > 0) {
        }
        java.lang.object value = this.realEntry.setValue((RealValue) androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter.access$000(this.this$0).doBackward(v));
        if (value is not null) {
            return (V) androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter.access$000(this.this$0).doForward(value);
        }
        return null;
    }
}

