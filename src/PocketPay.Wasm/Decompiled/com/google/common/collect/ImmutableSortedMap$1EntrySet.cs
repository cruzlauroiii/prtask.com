namespace WillowMaze.Wasm.Decompiled;


class ImmutableSortedDictionary$1EntryHashSet<K, V> : com.google.common.collect.ImmutableDictionaryEntryHashSet<K, V> {
    readonly com.google.common.collect.ImmutableSortedDictionary this$0;

    ImmutableSortedDictionary$1EntryHashSet(com.google.common.collect.ImmutableSortedDictionary immutableSortedDictionary) {
        this.this$0 = immutableSortedDictionary;
    }

    com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> createAsList() {
        return new com.google.common.collect.ImmutableSortedDictionary$1EntryHashSet$1(this);
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return asList().GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    com.google.common.collect.ImmutableDictionary<K, V> map() {
        return this.this$0;
    }
}

