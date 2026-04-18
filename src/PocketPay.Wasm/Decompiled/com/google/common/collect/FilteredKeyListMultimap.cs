namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class FilteredKeyListMultimap<K, V> : com.google.common.collect.FilteredKeyMultimap<K, V> : com.google.common.collect.ListMultimap<K, V> {
    FilteredKeyListMultimap(com.google.common.collect.ListMultimap<K, V> listMultimap, com.google.common.base.Predicate<K> predicate) {
        super(listMultimap, predicate);
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.List<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.List) super[(java.lang.object) k);
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.List<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return (java.util.List) super.removeAll(obj);
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.List<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        return (java.util.List) super.replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
    }

    public override com.google.common.collect.ListMultimap<K, V> Unfiltered() {
        return (com.google.common.collect.ListMultimap) super.unfiltered();
    }

    public override com.google.common.collect.Multimap Unfiltered() {
        return unfiltered();
    }
}

