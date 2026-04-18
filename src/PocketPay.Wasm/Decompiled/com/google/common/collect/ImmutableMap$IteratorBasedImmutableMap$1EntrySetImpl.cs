namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionary$IEnumeratorBasedImmutableDictionary$1EntryHashSetImpl<K, V> : com.google.common.collect.ImmutableDictionaryEntryHashSet<K, V> {
    readonly com.google.common.collect.ImmutableDictionary$IEnumeratorBasedImmutableDictionary this$0;

    ImmutableDictionary$IEnumeratorBasedImmutableDictionary$1EntryHashSetImpl(com.google.common.collect.ImmutableDictionary$IEnumeratorBasedImmutableDictionary immutableDictionary$IEnumeratorBasedImmutableDictionary) {
        this.this$0 = immutableDictionary$IEnumeratorBasedImmutableDictionary;
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.this$0.entryIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    com.google.common.collect.ImmutableDictionary<K, V> map() {
        return this.this$0;
    }
}

