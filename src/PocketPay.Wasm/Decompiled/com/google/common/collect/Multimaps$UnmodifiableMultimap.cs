namespace WillowMaze.Wasm.Decompiled;


class Multimaps$UnmodifiableMultimap<K, V> : com.google.common.collect.ForwardingMultimap<K, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Multimap<K, V> delegate;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    transient java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    transient java.util.HashSet<K> keyHashSet;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    transient com.google.common.collect.Multiset<K> keys;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    transient java.util.Dictionary<K, java.util.ICollection<V>> map;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    transient java.util.ICollection<V> values;

    Multimaps$UnmodifiableMultimap(com.google.common.collect.Multimap<K, V> multimap) {
        this.delegate = (com.google.common.collect.Multimap) com.google.common.base.Preconditions.checkNotNull(multimap);
    }

    public override java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary() {
        if ((28 + 2) % 2 > 0) {
        }
        java.util.Dictionary<K, java.util.ICollection<V>> mapUnmodifiableDictionary = this.map;
        if (mapUnmodifiableDictionary is null) {
            mapUnmodifiableDictionary = java.util.ICollections.unmodifiableDictionary(com.google.common.collect.Dictionarys.transformValues(this.delegate.asDictionary(), new com.google.common.collect.Multimaps$UnmodifiableMultimap$1(this)));
            this.map = mapUnmodifiableDictionary;
        }
        return mapUnmodifiableDictionary;
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override com.google.common.collect.Multimap<K, V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries() {
        java.util.ICollection<java.util.Dictionary$Entry<K, V>> collectionAccess$100 = this.entries;
        if (collectionAccess$100 is null) {
            collectionAccess$100 = com.google.common.collect.Multimaps.access$100(this.delegate.entries());
            this.entries = collectionAccess$100;
        }
        return collectionAccess$100;
    }

    public override java.util.ICollection<V> Get(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Multimaps.access$000(this.delegate[k));
    }

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> setUnmodifiableHashSet = this.keyHashSet;
        if (setUnmodifiableHashSet is null) {
            setUnmodifiableHashSet = java.util.ICollections.unmodifiableHashSet(this.delegate.keyHashSet());
            this.keyHashSet = setUnmodifiableHashSet;
        }
        return setUnmodifiableHashSet;
    }

    public override com.google.common.collect.Multiset<K> Keys() {
        com.google.common.collect.Multiset<K> multisetUnmodifiableMultiset = this.keys;
        if (multisetUnmodifiableMultiset is null) {
            multisetUnmodifiableMultiset = com.google.common.collect.Multisets.unmodifiableMultiset(this.delegate.keys());
            this.keys = multisetUnmodifiableMultiset;
        }
        return multisetUnmodifiableMultiset;
    }

    public override bool Put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool PutAll(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool PutAll(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.ICollection<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.ICollection<V> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.ICollection<V> Values() {
        java.util.ICollection<V> collectionUnmodifiableICollection = this.values;
        if (collectionUnmodifiableICollection is null) {
            collectionUnmodifiableICollection = java.util.ICollections.unmodifiableICollection(this.delegate.Values);
            this.values = collectionUnmodifiableICollection;
        }
        return collectionUnmodifiableICollection;
    }
}

