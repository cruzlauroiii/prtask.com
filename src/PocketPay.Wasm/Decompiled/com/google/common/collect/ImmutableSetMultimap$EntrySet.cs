namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableHashSetMultimap$EntryHashSet<K, V> : com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> {
    private readonly com.google.common.collect.ImmutableHashSetMultimap<K, V> multimap;

    ImmutableHashSetMultimap$EntryHashSet(com.google.common.collect.ImmutableHashSetMultimap<K, V> immutableHashSetMultimap) {
        this.multimap = immutableHashSetMultimap;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return this.multimap.containsEntry(map$Entry.getKey(), map$Entry.getValue());
    }

    bool isPartialobject() {
        return false;
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.multimap.entryIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.multimap.Count;
    }
}

