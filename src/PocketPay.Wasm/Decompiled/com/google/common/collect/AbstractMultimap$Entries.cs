namespace WillowMaze.Wasm.Decompiled;


class AbstractMultimap$Entries<K, V> : com.google.common.collect.Multimaps$Entries<K, V> {
    readonly com.google.common.collect.AbstractMultimap this$0;

    AbstractMultimap$Entries(com.google.common.collect.AbstractMultimap abstractMultimap) {
        this.this$0 = abstractMultimap;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    com.google.common.collect.Multimap<K, V> multimap() {
        return this.this$0;
    }
}

