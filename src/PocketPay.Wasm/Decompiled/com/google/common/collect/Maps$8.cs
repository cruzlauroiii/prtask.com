namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$8<K, V> : com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> {
    readonly java.util.IEnumerator val$entryIEnumerator;

    Dictionarys$8(java.util.IEnumerator it) {
        this.val$entryIEnumerator = it;
    }

    public override bool HasNext() {
        return this.val$entryIEnumerator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        return com.google.common.collect.Dictionarys.unmodifiableEntry((java.util.Dictionary$Entry) this.val$entryIEnumerator.Current);
    }
}

