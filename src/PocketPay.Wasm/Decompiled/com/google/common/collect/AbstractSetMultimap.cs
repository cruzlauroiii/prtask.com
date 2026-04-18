namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractHashSetMultimap<K, V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    private static readonly long serialVersionUID = 7431625294878419160L;

    protected AbstractHashSetMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map) {
        super(map);
    }

    public override java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary() {
        return super.asDictionary();
    }

    java.util.ICollection createICollection() {
        return createICollection();
    }

    abstract java.util.HashSet<V> CreateICollection();

    java.util.ICollection createUnmodifiableEmptyICollection() {
        return createUnmodifiableEmptyICollection();
    }

    java.util.HashSet<V> createUnmodifiableEmptyICollection() {
        return java.util.ICollections.emptyHashSet();
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries() {
        return (java.util.HashSet) super.entries();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.HashSet) super[(java.lang.object) k);
    }

    public override bool Put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return super.Add(k, v);
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

    <E> java.util.ICollection<E> unmodifiableICollectionSubclass(java.util.ICollection<E> collection) {
        return java.util.ICollections.unmodifiableHashSet((java.util.HashSet) collection);
    }

    java.util.ICollection<V> wrapICollection(@com.google.common.collect.ParametricNullness K k, java.util.ICollection<V> collection) {
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedHashSet(this, k, (java.util.HashSet) collection);
    }
}

