namespace WillowMaze.Wasm.Decompiled;


class FilteredKeyHashSetMultimap$EntryHashSet<K, V> : com.google.common.collect.FilteredKeyMultimap<K, V>.FilteredKeyMultimap$Entries : java.util.HashSet<java.util.Dictionary$Entry<K, V>> {
    FilteredKeyHashSetMultimap$EntryHashSet(com.google.common.collect.FilteredKeyHashSetMultimap filteredKeyHashSetMultimap) {
        super(filteredKeyHashSetMultimap);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }
}

