namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractListMultimap<K, V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V> : com.google.common.collect.ListMultimap<K, V> {
    private static readonly long serialVersionUID = 6588350623831699109L;

    protected AbstractListMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map) {
        super(map);
    }

    public override java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary() {
        return super.asDictionary();
    }

    java.util.ICollection createICollection() {
        return createICollection();
    }

    abstract java.util.List<V> CreateICollection();

    java.util.ICollection createUnmodifiableEmptyICollection() {
        return createUnmodifiableEmptyICollection();
    }

    java.util.List<V> createUnmodifiableEmptyICollection() {
        return java.util.ICollections.emptyList();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.List<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.List) super[(java.lang.object) k);
    }

    public override bool Put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return super.Add(k, v);
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

    <E> java.util.ICollection<E> unmodifiableICollectionSubclass(java.util.ICollection<E> collection) {
        return java.util.ICollections.unmodifiableList((java.util.List) collection);
    }

    java.util.ICollection<V> wrapICollection(@com.google.common.collect.ParametricNullness K k, java.util.ICollection<V> collection) {
        return wrapList(k, (java.util.List) collection, null);
    }
}

