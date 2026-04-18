namespace WillowMaze.Wasm.Decompiled;


class Internal$DictionaryAdapter$HashSetAdapter<K, V> : java.util.AbstractHashSet<java.util.Dictionary$Entry<K, V>> {
    private readonly java.util.HashSet<java.util.Dictionary$Entry<K, RealValue>> realHashSet;
    readonly androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter this$0;

    public Internal$DictionaryAdapter$HashSetAdapter(androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter internal$DictionaryAdapter, java.util.HashSet<java.util.Dictionary$Entry<K, RealValue>> set) {
        this.this$0 = internal$DictionaryAdapter;
        this.realHashSet = set;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        if ((20 + 28) % 28 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$IEnumeratorAdapter(this.this$0, this.realHashSet.GetEnumerator());
    }

    public override int Size() {
        return this.realHashSet.Count;
    }
}

