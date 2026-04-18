namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class FilteredKeyHashSetMultimap<K, V> : com.google.common.collect.FilteredKeyMultimap<K, V> : com.google.common.collect.FilteredHashSetMultimap<K, V> {
    FilteredKeyHashSetMultimap(com.google.common.collect.HashSetMultimap<K, V> setMultimap, com.google.common.base.Predicate<K> predicate) {
        super(setMultimap, predicate);
    }

    java.util.ICollection createEntries() {
        return createEntries();
    }

    java.util.HashSet<java.util.Dictionary$Entry<K, V>> createEntries() {
        return new com.google.common.collect.FilteredKeyHashSetMultimap$EntryHashSet(this);
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries() {
        return (java.util.HashSet) super.entries();
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.HashSet) super[(java.lang.object) k);
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.HashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return (java.util.HashSet) super.removeAll(obj);
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.HashSet<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return (java.util.HashSet) super.replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
    }

    public override com.google.common.collect.Multimap Unfiltered() {
        return unfiltered();
    }

    public override com.google.common.collect.HashSetMultimap<K, V> Unfiltered() {
        return (com.google.common.collect.HashSetMultimap) this.unfiltered;
    }
}

