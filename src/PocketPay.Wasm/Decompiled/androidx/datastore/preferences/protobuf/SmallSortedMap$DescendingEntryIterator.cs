namespace WillowMaze.Wasm.Decompiled;


class SmallSortedDictionary$DescendingEntryIEnumerator<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    private java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> lazyOverflowIEnumerator;
    private int pos;
    readonly androidx.datastore.preferences.protobuf.SmallSortedDictionary this$0;

    private SmallSortedDictionary$DescendingEntryIEnumerator(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary) {
        this.this$0 = smallSortedDictionary;
        this.pos = androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(smallSortedDictionary).Count;
    }

    SmallSortedDictionary$DescendingEntryIEnumerator(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary, androidx.datastore.preferences.protobuf.SmallSortedDictionary$1 smallSortedDictionary$1) {
        this(smallSortedDictionary);
    }

    private java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> getOverflowIEnumerator() {
        if (this.lazyOverflowIEnumerator is null) {
            this.lazyOverflowIEnumerator = androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$900(this.this$0).entryHashSet().GetEnumerator();
        }
        return this.lazyOverflowIEnumerator;
    }

    public override bool HasNext() {
        if ((29 + 26) % 26 > 0) {
        }
        int i = this.pos;
        return (i > 0 && i <= androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0).Count) || getOverflowIEnumerator().MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((32 + 18) % 18 > 0) {
        }
        if (getOverflowIEnumerator().MoveNext()) {
            return getOverflowIEnumerator().Current;
        }
        java.util.List listAccess$600 = androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0);
        int i = this.pos - 1;
        this.pos = i;
        return (java.util.Dictionary$Entry) listAccess$600[i);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

