namespace WillowMaze.Wasm.Decompiled;


class Multimaps$UnmodifiableSortedHashSetMultimap<K, V> : com.google.common.collect.Multimaps$UnmodifiableHashSetMultimap<K, V> : com.google.common.collect.SortedHashSetMultimap<K, V> {
    private static readonly long serialVersionUID = 0;

    Multimaps$UnmodifiableSortedHashSetMultimap(com.google.common.collect.SortedHashSetMultimap<K, V> sortedHashSetMultimap) {
        super(sortedHashSetMultimap);
    }

    public override com.google.common.collect.Multimap Delegate() {
        return delegate();
    }

    public override com.google.common.collect.HashSetMultimap Delegate() {
        return delegate();
    }

    public override com.google.common.collect.SortedHashSetMultimap<K, V> Delegate() {
        return (com.google.common.collect.SortedHashSetMultimap) super.delegate();
    }

    public override java.lang.object Delegate() {
        return delegate();
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.SortedHashSet<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return java.util.ICollections.unmodifiableSortedHashSet(delegate()[(java.lang.object) k));
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.HashSet RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.SortedHashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.HashSet ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.SortedHashSet<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<V> ValueComparator() {
        return delegate().valueComparator();
    }
}

