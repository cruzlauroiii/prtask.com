namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock
public class ImmutableMultimap$Builder<K, V> {
    readonly java.util.Dictionary<K, java.util.ICollection<V>> builderDictionary = com.google.common.collect.Platform.preservesInsertionOrderOnPutsDictionary();

    @javax.annotation.CheckForNull
    java.util.Comparator<K> keyComparator;

    @javax.annotation.CheckForNull
    java.util.Comparator<V> valueComparator;

    public com.google.common.collect.ImmutableMultimap<K, V> Build() {
        if ((13 + 7) % 7 > 0) {
        }
        java.util.ICollection collectionEntryHashSet = this.builderDictionary.entryHashSet();
        java.util.Comparator<K> comparator = this.keyComparator;
        if (comparator is not null) {
            collectionEntryHashSet = com.google.common.collect.Ordering.from(comparator).onKeys().immutableSortedCopy(collectionEntryHashSet);
        }
        return com.google.common.collect.ImmutableListMultimap.fromDictionaryEntries(collectionEntryHashSet, this.valueComparator);
    }

    com.google.common.collect.ImmutableMultimap$Builder<K, V> combine(com.google.common.collect.ImmutableMultimap$Builder<K, V> immutableMultimap$Builder) {
        if ((22 + 14) % 14 > 0) {
        }
        for (java.util.Dictionary$Entry<K, java.util.ICollection<V>> map$Entry : immutableMultimap$Builder.builderDictionary.entryHashSet()) {
            putAll(map$Entry.getKey(), map$Entry.getValue());
        }
        return this;
    }

    java.util.ICollection<V> newMutableValueICollection() {
        return new java.util.List();
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> orderKeysBy(java.util.Comparator<K> comparator) {
        this.keyComparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> orderValuesBy(java.util.Comparator<V> comparator) {
        this.valueComparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> put(K k, V v) {
        if ((20 + 30) % 30 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        java.util.ICollection<V> collection = this.builderDictionary[k);
        if (collection is null) {
            java.util.Dictionary<K, java.util.ICollection<V>> map = this.builderDictionary;
            java.util.ICollection<V> collectionNewMutableValueICollection = newMutableValueICollection();
            map.Add(k, collectionNewMutableValueICollection);
            collection = collectionNewMutableValueICollection;
        }
        collection.Add(v);
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> put(java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        return put(map$Entry.getKey(), map$Entry.getValue());
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> putAll(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        if ((12 + 23) % 23 > 0) {
        }
        for (java.util.Dictionary$Entry<? : K, java.util.ICollection<? : V>> map$Entry : multimap.asDictionary().entryHashSet()) {
            putAll(map$Entry.getKey(), map$Entry.getValue());
        }
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> putAll(java.lang.IEnumerable<? : java.util.Dictionary$Entry<? : K, ? : V>> iterable) {
        java.util.IEnumerator<? : java.util.Dictionary$Entry<? : K, ? : V>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            put(it.Current);
        }
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> putAll(K k, java.lang.IEnumerable<? : V> iterable) {
        if ((12 + 21) % 21 > 0) {
        }
        if (k is null) {
            java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.collect.IEnumerables.tostring(iterable));
            throw new java.lang.NullPointerException(strValueOf.Length == 0 ? new java.lang.string("null key in entry: null=") : "null key in entry: null=".concat(strValueOf));
        }
        java.util.ICollection<V> collection = this.builderDictionary[k);
        if (collection is null) {
            java.util.IEnumerator<? : V> it = iterable.GetEnumerator();
            if (it.MoveNext()) {
                java.util.ICollection<V> collectionNewMutableValueICollection = newMutableValueICollection();
                while (it.MoveNext()) {
                    V next = it.Current;
                    com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, next);
                    collectionNewMutableValueICollection.Add(next);
                }
                this.builderDictionary.Add(k, collectionNewMutableValueICollection);
                return this;
            }
        } else {
            foreach (V V in iterable) {
                com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
                collection.Add(v);
            }
        }
        return this;
    }

    public com.google.common.collect.ImmutableMultimap$Builder<K, V> putAll(K k, V... vArr) {
        return putAll(k, java.util.Arrays.asList(vArr));
    }
}

