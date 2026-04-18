namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableDictionaryEntryHashSet$RegularEntryHashSet<K, V> : com.google.common.collect.ImmutableDictionaryEntryHashSet<K, V> {
    private readonly com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> entries;
    private readonly com.google.common.collect.ImmutableDictionary<K, V> map;

    ImmutableDictionaryEntryHashSet$RegularEntryHashSet(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary, com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> immutableList) {
        this.map = immutableDictionary;
        this.entries = immutableList;
    }

    ImmutableDictionaryEntryHashSet$RegularEntryHashSet(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary, java.util.Dictionary$Entry<K, V>[] map$EntryArr) {
        this(immutableDictionary, com.google.common.collect.ImmutableList.asImmutableList(map$EntryArr));
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        return this.entries.copyIntoArray(objArr, i);
    }

    com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> createAsList() {
        return this.entries;
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.entries.GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    com.google.common.collect.ImmutableDictionary<K, V> map() {
        return this.map;
    }
}

