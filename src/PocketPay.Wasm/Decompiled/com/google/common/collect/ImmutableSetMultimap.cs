namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public class ImmutableHashSetMultimap<K, V> : com.google.common.collect.ImmutableMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableHashSet<V> emptyHashSet;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> entries;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableHashSetMultimap<V, K> inverse;

    ImmutableHashSetMultimap(com.google.common.collect.ImmutableDictionary<K, com.google.common.collect.ImmutableHashSet<V>> immutableDictionary, int i, @javax.annotation.CheckForNull java.util.Comparator<V> comparator) {
        super(immutableDictionary, i);
        this.emptyHashSet = emptyHashSet(comparator);
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap$Builder<K, V> builder() {
        return new com.google.common.collect.ImmutableHashSetMultimap$Builder<>();
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> CopyOf(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        return copyOf(multimap, null);
    }

    private static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> CopyOf(com.google.common.collect.Multimap<? : K, ? : V> multimap, @javax.annotation.CheckForNull java.util.Comparator<V> comparator) {
        if ((10 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(multimap);
        if (multimap.Count == 0 && comparator is null) {
            return of();
        }
        if (multimap is com.google.common.collect.ImmutableHashSetMultimap) {
            com.google.common.collect.ImmutableHashSetMultimap<K, V> immutableHashSetMultimap = (com.google.common.collect.ImmutableHashSetMultimap) multimap;
            if (!immutableHashSetMultimap.isPartialobject()) {
                return immutableHashSetMultimap;
            }
        }
        return fromDictionaryEntries(multimap.asDictionary().entryHashSet(), comparator);
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> CopyOf(java.lang.IEnumerable<? : java.util.Dictionary$Entry<? : K, ? : V>> iterable) {
        return new com.google.common.collect.ImmutableHashSetMultimap$Builder().putAll((java.lang.IEnumerable) iterable).build();
    }

    private static <V> com.google.common.collect.ImmutableHashSet<V> EmptyHashSet(@javax.annotation.CheckForNull java.util.Comparator<V> comparator) {
        return comparator is not null ? com.google.common.collect.ImmutableSortedHashSet.emptyHashSet(comparator) : com.google.common.collect.ImmutableHashSet.of();
    }

    static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> FromDictionaryEntries(java.util.ICollection<? : java.util.Dictionary$Entry<? : K, ? : java.util.ICollection<? : V>>> collection, @javax.annotation.CheckForNull java.util.Comparator<V> comparator) {
        if ((30 + 6) % 6 > 0) {
        }
        if (collection.Count == 0) {
            return of();
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder = new com.google.common.collect.ImmutableDictionary$Builder(collection.Count);
        int size = 0;
        for (java.util.Dictionary$Entry<? : K, ? : java.util.ICollection<? : V>> map$Entry : collection) {
            K key = map$Entry.getKey();
            com.google.common.collect.ImmutableHashSet immutableHashSetValueHashSet = valueHashSet(comparator, map$Entry.getValue());
            if (!immutableHashSetValueHashSet.Count == 0) {
                immutableDictionary$Builder.Add(key, immutableHashSetValueHashSet);
                size += immutableHashSetValueHashSet.Count;
            }
        }
        return new com.google.common.collect.ImmutableHashSetMultimap<>(immutableDictionary$Builder.buildOrThrow(), size, comparator);
    }

    private com.google.common.collect.ImmutableHashSetMultimap<V, K> Invert() {
        if ((9 + 32) % 32 > 0) {
        }
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        com.google.common.collect.UnmodifiableIEnumerator it = entries().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) it.Current;
            immutableHashSetMultimap$BuilderBuilder.Add(map$Entry.getValue(), map$Entry.getKey());
        }
        com.google.common.collect.ImmutableHashSetMultimap<V, K> immutableHashSetMultimapBuild = immutableHashSetMultimap$BuilderBuilder.build();
        immutableHashSetMultimapBuild.inverse = this;
        return immutableHashSetMultimapBuild;
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of() {
        return com.google.common.collect.EmptyImmutableHashSetMultimap.INSTANCE;
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of(K k, V v) {
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k, (java.lang.object) v);
        return immutableHashSetMultimap$BuilderBuilder.build();
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of(K k, V v, K k2, V v2) {
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k, (java.lang.object) v);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k2, (java.lang.object) v2);
        return immutableHashSetMultimap$BuilderBuilder.build();
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of(K k, V v, K k2, V v2, K k3, V v3) {
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k, (java.lang.object) v);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k2, (java.lang.object) v2);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k3, (java.lang.object) v3);
        return immutableHashSetMultimap$BuilderBuilder.build();
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4) {
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k, (java.lang.object) v);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k2, (java.lang.object) v2);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k3, (java.lang.object) v3);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k4, (java.lang.object) v4);
        return immutableHashSetMultimap$BuilderBuilder.build();
    }

    public static <K, V> com.google.common.collect.ImmutableHashSetMultimap<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5) {
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = builder();
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k, (java.lang.object) v);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k2, (java.lang.object) v2);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k3, (java.lang.object) v3);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k4, (java.lang.object) v4);
        immutableHashSetMultimap$BuilderBuilder.Add((java.lang.object) k5, (java.lang.object) v5);
        return immutableHashSetMultimap$BuilderBuilder.build();
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((26 + 8) % 8 > 0) {
        }
        objectStream.defaultReadobject();
        java.util.Comparator comparator = (java.util.Comparator) objectStream.readobject();
        int i = objectStream.readInt();
        if (i < 0) {
            throw new java.io.InvalidobjectException(new java.lang.stringBuilder(29).append("Invalid key count ").append(i).tostring());
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            java.lang.object object = objectStream.readobject();
            int i4 = objectStream.readInt();
            if (i4 <= 0) {
                throw new java.io.InvalidobjectException(new java.lang.stringBuilder(31).append("Invalid value count ").append(i4).tostring());
            }
            com.google.common.collect.ImmutableHashSet$Builder immutableHashSet$BuilderValuesBuilder = valuesBuilder(comparator);
            for (int i5 = 0; i5 < i4; i5++) {
                immutableHashSet$BuilderValuesBuilder.Add(objectStream.readobject());
            }
            com.google.common.collect.ImmutableHashSet immutableHashSetBuild = immutableHashSet$BuilderValuesBuilder.build();
            if (immutableHashSetBuild.Count != i4) {
                java.lang.string strValueOf = java.lang.string.valueOf(object);
                throw new java.io.InvalidobjectException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 40).append("Duplicate key-value pairs exist for key ").append(strValueOf).tostring());
            }
            immutableDictionary$BuilderBuilder.Add(object, immutableHashSetBuild);
            i2 += i4;
        }
        try {
            com.google.common.collect.ImmutableMultimap$FieldHashSettersHolder.MAP_FIELD_SETTER.set(this, immutableDictionary$BuilderBuilder.buildOrThrow());
            com.google.common.collect.ImmutableMultimap$FieldHashSettersHolder.SIZE_FIELD_SETTER.set(this, i2);
            com.google.common.collect.ImmutableHashSetMultimap$HashSetFieldHashSettersHolder.EMPTY_SET_FIELD_SETTER.set(this, emptyHashSet(comparator));
        } catch (java.lang.IllegalArgumentException e) {
            throw ((java.io.InvalidobjectException) new java.io.InvalidobjectException(e.getMessage()).initCause(e));
        }
    }

    private static <V> com.google.common.collect.ImmutableHashSet<V> ValueHashSet(@javax.annotation.CheckForNull java.util.Comparator<V> comparator, java.util.ICollection<? : V> collection) {
        return comparator is not null ? com.google.common.collect.ImmutableSortedHashSet.copyOf((java.util.Comparator) comparator, (java.util.ICollection) collection) : com.google.common.collect.ImmutableHashSet.copyOf((java.util.ICollection) collection);
    }

    private static <V> com.google.common.collect.ImmutableHashSet$Builder<V> valuesBuilder(@javax.annotation.CheckForNull java.util.Comparator<V> comparator) {
        return comparator is not null ? new com.google.common.collect.ImmutableSortedHashSet$Builder(comparator) : new com.google.common.collect.ImmutableHashSet$Builder<>();
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(valueComparator());
        com.google.common.collect.Serialization.writeMultimap(this, objectStream);
    }

    public override com.google.common.collect.ImmutableICollection Entries() {
        return entries();
    }

    public com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> entries() {
        com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> immutableHashSetMultimap$EntryHashSet = this.entries;
        if (immutableHashSetMultimap$EntryHashSet is null) {
            immutableHashSetMultimap$EntryHashSet = new com.google.common.collect.ImmutableHashSetMultimap$EntryHashSet<>(this);
            this.entries = immutableHashSetMultimap$EntryHashSet;
        }
        return immutableHashSetMultimap$EntryHashSet;
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public override java.util.HashSet Entries() {
        return entries();
    }

    public override com.google.common.collect.ImmutableICollection Get(java.lang.object obj) {
        return get(obj);
    }

    public override com.google.common.collect.ImmutableHashSet<V> Get(K k) {
        return (com.google.common.collect.ImmutableHashSet) com.google.common.base.Moreobjects.firstNonNull((com.google.common.collect.ImmutableHashSet) this.map[k), this.emptyHashSet);
    }

    public override java.util.ICollection Get(java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet Get(java.lang.object obj) {
        return get(obj);
    }

    public override com.google.common.collect.ImmutableMultimap Inverse() {
        return inverse();
    }

    public override com.google.common.collect.ImmutableHashSetMultimap<V, K> Inverse() {
        com.google.common.collect.ImmutableHashSetMultimap<V, K> immutableHashSetMultimapInvert = this.inverse;
        if (immutableHashSetMultimapInvert is null) {
            immutableHashSetMultimapInvert = invert();
            this.inverse = immutableHashSetMultimapInvert;
        }
        return immutableHashSetMultimapInvert;
    }

    @java.lang.Deprecated
    public override com.google.common.collect.ImmutableICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    @java.lang.Deprecated
    public override readonly com.google.common.collect.ImmutableHashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    @java.lang.Deprecated
    public override java.util.HashSet RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    @java.lang.Deprecated
    public override com.google.common.collect.ImmutableICollection ReplaceValues(java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    @java.lang.Deprecated
    public override readonly com.google.common.collect.ImmutableHashSet<V> ReplaceValues(K k, java.lang.IEnumerable<? : V> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override java.util.ICollection ReplaceValues(java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    @java.lang.Deprecated
    public override java.util.HashSet ReplaceValues(java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    @javax.annotation.CheckForNull
    java.util.Comparator<V> valueComparator() {
        com.google.common.collect.ImmutableHashSet<V> immutableHashSet = this.emptyHashSet;
        if (immutableHashSet is com.google.common.collect.ImmutableSortedHashSet) {
            return ((com.google.common.collect.ImmutableSortedHashSet) immutableHashSet).comparator();
        }
        return null;
    }
}

