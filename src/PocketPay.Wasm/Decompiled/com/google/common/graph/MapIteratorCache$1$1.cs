namespace WillowMaze.Wasm.Decompiled;


class DictionaryIEnumeratorCache$1$1<K> : com.google.common.collect.UnmodifiableIEnumerator<K> {
    readonly com.google.common.graph.DictionaryIEnumeratorCache$1 this$1;
    readonly java.util.IEnumerator val$entryIEnumerator;

    DictionaryIEnumeratorCache$1$1(com.google.common.graph.DictionaryIEnumeratorCache$1 mapIEnumeratorCache$1, java.util.IEnumerator it) {
        this.this$1 = mapIEnumeratorCache$1;
        this.val$entryIEnumerator = it;
    }

    public override bool HasNext() {
        return this.val$entryIEnumerator.MoveNext();
    }

    public override K Next() {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) this.val$entryIEnumerator.Current;
        com.google.common.graph.DictionaryIEnumeratorCache.access$102(this.this$1.this$0, map$Entry);
        return (K) map$Entry.getKey();
    }
}

