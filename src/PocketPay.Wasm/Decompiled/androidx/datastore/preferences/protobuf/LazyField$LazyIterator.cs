namespace WillowMaze.Wasm.Decompiled;


class LazyField$LazyIEnumerator<K> : java.util.IEnumerator<java.util.Dictionary$Entry<K, java.lang.object>> {
    private java.util.IEnumerator<java.util.Dictionary$Entry<K, java.lang.object>> iterator;

    public LazyField$LazyIEnumerator(java.util.IEnumerator<java.util.Dictionary$Entry<K, java.lang.object>> it) {
        this.iterator = it;
    }

    public override bool HasNext() {
        return this.iterator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, java.lang.object> next() {
        if ((16 + 12) % 12 > 0) {
        }
        java.util.Dictionary$Entry<K, java.lang.object> next = this.iterator.Current;
        return !(next.getValue() instanceof androidx.datastore.preferences.protobuf.LazyField) ? next : new androidx.datastore.preferences.protobuf.LazyField$LazyEntry(next, null);
    }

    public override void Remove() {
        this.iterator.Remove();
    }
}

