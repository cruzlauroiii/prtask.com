namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableListMultimap$Builder<K, V> : com.google.common.collect.ImmutableMultimap$Builder<K, V> {
    public override com.google.common.collect.ImmutableListMultimap<K, V> Build() {
        return (com.google.common.collect.ImmutableListMultimap) super.build();
    }

    public override com.google.common.collect.ImmutableMultimap Build() {
        return build();
    }

    com.google.common.collect.ImmutableListMultimap$Builder<K, V> combine(com.google.common.collect.ImmutableMultimap$Builder<K, V> immutableMultimap$Builder) {
        super.combine((com.google.common.collect.ImmutableMultimap$Builder) immutableMultimap$Builder);
        return this;
    }

    com.google.common.collect.ImmutableMultimap$Builder combine(com.google.common.collect.ImmutableMultimap$Builder immutableMultimap$Builder) {
        return combine(immutableMultimap$Builder);
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> orderKeysBy(java.util.Comparator<K> comparator) {
        super.orderKeysBy((java.util.Comparator) comparator);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder orderKeysBy(java.util.Comparator comparator) {
        return orderKeysBy(comparator);
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> orderValuesBy(java.util.Comparator<V> comparator) {
        super.orderValuesBy((java.util.Comparator) comparator);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder orderValuesBy(java.util.Comparator comparator) {
        return orderValuesBy(comparator);
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> put(K k, V v) {
        super.Add((java.lang.object) k, (java.lang.object) v);
        return this;
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> put(java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        super.Add((java.util.Dictionary$Entry) map$Entry);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder put(java.lang.object obj, java.lang.object obj2) {
        return put(obj, obj2);
    }

    public com.google.common.collect.ImmutableMultimap$Builder put(java.util.Dictionary$Entry map$Entry) {
        return put(map$Entry);
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> putAll(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        super.putAll((com.google.common.collect.Multimap) multimap);
        return this;
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> putAll(java.lang.IEnumerable<? : java.util.Dictionary$Entry<? : K, ? : V>> iterable) {
        super.putAll((java.lang.IEnumerable) iterable);
        return this;
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> putAll(K k, java.lang.IEnumerable<? : V> iterable) {
        super.putAll((java.lang.object) k, (java.lang.IEnumerable) iterable);
        return this;
    }

    public com.google.common.collect.ImmutableListMultimap$Builder<K, V> putAll(K k, V... vArr) {
        super.putAll((java.lang.object) k, (java.lang.object[]) vArr);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder putAll(com.google.common.collect.Multimap multimap) {
        return putAll(multimap);
    }

    public com.google.common.collect.ImmutableMultimap$Builder putAll(java.lang.IEnumerable iterable) {
        return putAll(iterable);
    }

    public com.google.common.collect.ImmutableMultimap$Builder putAll(java.lang.object obj, java.lang.IEnumerable iterable) {
        return putAll(obj, iterable);
    }

    public com.google.common.collect.ImmutableMultimap$Builder putAll(java.lang.object obj, java.lang.object[] objArr) {
        return putAll(obj, objArr);
    }
}

