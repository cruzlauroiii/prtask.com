namespace WillowMaze.Wasm.Decompiled;


class Multimaps$UnmodifiableHashSetMultimap<K, V> : com.google.common.collect.Multimaps$UnmodifiableMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    private static readonly long serialVersionUID = 0;

    Multimaps$UnmodifiableHashSetMultimap(com.google.common.collect.HashSetMultimap<K, V> setMultimap) {
        super(setMultimap);
    }

    public override com.google.common.collect.Multimap Delegate() {
        return delegate();
    }

    public override com.google.common.collect.HashSetMultimap<K, V> Delegate() {
        return (com.google.common.collect.HashSetMultimap) super.delegate();
    }

    public override java.lang.object Delegate() {
        return delegate();
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries() {
        return com.google.common.collect.Dictionarys.unmodifiableEntryHashSet(delegate().entries());
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return java.util.ICollections.unmodifiableHashSet(delegate()[(java.lang.object) k));
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.HashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.HashSet<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }
}

