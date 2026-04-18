namespace WillowMaze.Wasm.Decompiled;


class Internal$DictionaryAdapter$IEnumeratorAdapter<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    private readonly java.util.IEnumerator<java.util.Dictionary$Entry<K, RealValue>> realIEnumerator;
    readonly androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter this$0;

    public Internal$DictionaryAdapter$IEnumeratorAdapter(androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter internal$DictionaryAdapter, java.util.IEnumerator<java.util.Dictionary$Entry<K, RealValue>> it) {
        this.this$0 = internal$DictionaryAdapter;
        this.realIEnumerator = it;
    }

    public override bool HasNext() {
        return this.realIEnumerator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((5 + 14) % 14 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.Internal$DictionaryAdapter$EntryAdapter(this.this$0, (java.util.Dictionary$Entry) this.realIEnumerator.Current);
    }

    public override void Remove() {
        this.realIEnumerator.Remove();
    }
}

