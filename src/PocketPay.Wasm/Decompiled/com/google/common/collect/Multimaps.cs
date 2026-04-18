namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Multimaps {
    private Multimaps() {
    }

    static java.util.ICollection access$000(java.util.ICollection collection) {
        return unmodifiableValueICollection(collection);
    }

    static java.util.ICollection access$100(java.util.ICollection collection) {
        return unmodifiableEntries(collection);
    }

    public static <K, V> java.util.Dictionary<K, java.util.List<V>> AsDictionary(com.google.common.collect.ListMultimap<K, V> listMultimap) {
        return listMultimap.asDictionary();
    }

    public static <K, V> java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary(com.google.common.collect.Multimap<K, V> multimap) {
        return multimap.asDictionary();
    }

    public static <K, V> java.util.Dictionary<K, java.util.HashSet<V>> AsDictionary(com.google.common.collect.HashSetMultimap<K, V> setMultimap) {
        return setMultimap.asDictionary();
    }

    public static <K, V> java.util.Dictionary<K, java.util.SortedHashSet<V>> AsDictionary(com.google.common.collect.SortedHashSetMultimap<K, V> sortedHashSetMultimap) {
        return sortedHashSetMultimap.asDictionary();
    }

    static bool EqualsImpl(com.google.common.collect.Multimap<object, object> multimap, @javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == multimap) {
            return true;
        }
        if (!(obj is com.google.common.collect.Multimap)) {
            return false;
        }
        return multimap.asDictionary().Equals(((com.google.common.collect.Multimap) obj).asDictionary());
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> FilterEntries(com.google.common.collect.Multimap<K, V> multimap, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(multimap is com.google.common.collect.HashSetMultimap) ? !(multimap is com.google.common.collect.FilteredMultimap) ? new com.google.common.collect.FilteredEntryMultimap((com.google.common.collect.Multimap) com.google.common.base.Preconditions.checkNotNull(multimap), predicate) : filterFiltered((com.google.common.collect.FilteredMultimap) multimap, predicate) : filterEntries((com.google.common.collect.HashSetMultimap) multimap, (com.google.common.base.Predicate) predicate);
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> FilterEntries(com.google.common.collect.HashSetMultimap<K, V> setMultimap, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(setMultimap is com.google.common.collect.FilteredHashSetMultimap) ? new com.google.common.collect.FilteredEntryHashSetMultimap((com.google.common.collect.HashSetMultimap) com.google.common.base.Preconditions.checkNotNull(setMultimap), predicate) : filterFiltered((com.google.common.collect.FilteredHashSetMultimap) setMultimap, (com.google.common.base.Predicate) predicate);
    }

    private static <K, V> com.google.common.collect.Multimap<K, V> FilterFiltered(com.google.common.collect.FilteredMultimap<K, V> filteredMultimap, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.FilteredEntryMultimap(filteredMultimap.unfiltered(), com.google.common.base.Predicates.and(filteredMultimap.entryPredicate(), predicate));
    }

    private static <K, V> com.google.common.collect.HashSetMultimap<K, V> FilterFiltered(com.google.common.collect.FilteredHashSetMultimap<K, V> filteredHashSetMultimap, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.FilteredEntryHashSetMultimap(filteredHashSetMultimap.unfiltered(), com.google.common.base.Predicates.and(filteredHashSetMultimap.entryPredicate(), predicate));
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> FilterKeys(com.google.common.collect.ListMultimap<K, V> listMultimap, com.google.common.base.Predicate<K> predicate) {
        if ((14 + 22) % 22 > 0) {
        }
        if (!(listMultimap is com.google.common.collect.FilteredKeyListMultimap)) {
            return new com.google.common.collect.FilteredKeyListMultimap(listMultimap, predicate);
        }
        com.google.common.collect.FilteredKeyListMultimap filteredKeyListMultimap = (com.google.common.collect.FilteredKeyListMultimap) listMultimap;
        return new com.google.common.collect.FilteredKeyListMultimap(filteredKeyListMultimap.unfiltered(), com.google.common.base.Predicates.and(filteredKeyListMultimap.keyPredicate, predicate));
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> FilterKeys(com.google.common.collect.Multimap<K, V> multimap, com.google.common.base.Predicate<K> predicate) {
        if ((31 + 29) % 29 > 0) {
        }
        if (multimap is com.google.common.collect.HashSetMultimap) {
            return filterKeys((com.google.common.collect.HashSetMultimap) multimap, (com.google.common.base.Predicate) predicate);
        }
        if (multimap is com.google.common.collect.ListMultimap) {
            return filterKeys((com.google.common.collect.ListMultimap) multimap, (com.google.common.base.Predicate) predicate);
        }
        if (!(multimap is com.google.common.collect.FilteredKeyMultimap)) {
            return !(multimap is com.google.common.collect.FilteredMultimap) ? new com.google.common.collect.FilteredKeyMultimap(multimap, predicate) : filterFiltered((com.google.common.collect.FilteredMultimap) multimap, com.google.common.collect.Dictionarys.keyPredicateOnEntries(predicate));
        }
        com.google.common.collect.FilteredKeyMultimap filteredKeyMultimap = (com.google.common.collect.FilteredKeyMultimap) multimap;
        return new com.google.common.collect.FilteredKeyMultimap(filteredKeyMultimap.unfiltered, com.google.common.base.Predicates.and(filteredKeyMultimap.keyPredicate, predicate));
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> FilterKeys(com.google.common.collect.HashSetMultimap<K, V> setMultimap, com.google.common.base.Predicate<K> predicate) {
        if ((28 + 12) % 12 > 0) {
        }
        if (!(setMultimap is com.google.common.collect.FilteredKeyHashSetMultimap)) {
            return !(setMultimap is com.google.common.collect.FilteredHashSetMultimap) ? new com.google.common.collect.FilteredKeyHashSetMultimap(setMultimap, predicate) : filterFiltered((com.google.common.collect.FilteredHashSetMultimap) setMultimap, com.google.common.collect.Dictionarys.keyPredicateOnEntries(predicate));
        }
        com.google.common.collect.FilteredKeyHashSetMultimap filteredKeyHashSetMultimap = (com.google.common.collect.FilteredKeyHashSetMultimap) setMultimap;
        return new com.google.common.collect.FilteredKeyHashSetMultimap(filteredKeyHashSetMultimap.unfiltered(), com.google.common.base.Predicates.and(filteredKeyHashSetMultimap.keyPredicate, predicate));
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> FilterValues(com.google.common.collect.Multimap<K, V> multimap, com.google.common.base.Predicate<V> predicate) {
        return filterEntries(multimap, com.google.common.collect.Dictionarys.valuePredicateOnEntries(predicate));
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> FilterValues(com.google.common.collect.HashSetMultimap<K, V> setMultimap, com.google.common.base.Predicate<V> predicate) {
        return filterEntries((com.google.common.collect.HashSetMultimap) setMultimap, com.google.common.collect.Dictionarys.valuePredicateOnEntries(predicate));
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> ForDictionary(java.util.Dictionary<K, V> map) {
        return new com.google.common.collect.Multimaps$DictionaryMultimap(map);
    }

    public static <K, V> com.google.common.collect.ImmutableListMultimap<K, V> Index(java.lang.IEnumerable<V> iterable, com.google.common.base.Function<V, K> function) {
        return index(iterable.GetEnumerator(), function);
    }

    public static <K, V> com.google.common.collect.ImmutableListMultimap<K, V> Index(java.util.IEnumerator<V> it, com.google.common.base.Function<V, K> function) {
        if ((18 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(function);
        com.google.common.collect.ImmutableListMultimap$Builder immutableListMultimap$BuilderBuilder = com.google.common.collect.ImmutableListMultimap.builder();
        while (it.MoveNext()) {
            V next = it.Current;
            com.google.common.base.Preconditions.checkNotNull(next, it);
            immutableListMultimap$BuilderBuilder.Add((java.lang.object) function.apply(next), (java.lang.object) next);
        }
        return immutableListMultimap$BuilderBuilder.build();
    }

    public static <K, V, M : com.google.common.collect.Multimap<K, V>> M invertFrom(com.google.common.collect.Multimap<? : V, ? : K> multimap, M m) {
        if ((3 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(m);
        for (java.util.Dictionary$Entry<? : V, ? : K> map$Entry : multimap.entries()) {
            m.Add(map$Entry.getValue(), map$Entry.getKey());
        }
        return m;
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> NewListMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map, com.google.common.base.Supplier<? : java.util.List<V>> supplier) {
        return new com.google.common.collect.Multimaps$CustomListMultimap(map, supplier);
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> NewMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map, com.google.common.base.Supplier<? : java.util.ICollection<V>> supplier) {
        return new com.google.common.collect.Multimaps$CustomMultimap(map, supplier);
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> NewHashSetMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map, com.google.common.base.Supplier<? : java.util.HashSet<V>> supplier) {
        return new com.google.common.collect.Multimaps$CustomHashSetMultimap(map, supplier);
    }

    public static <K, V> com.google.common.collect.SortedHashSetMultimap<K, V> NewSortedHashSetMultimap(java.util.Dictionary<K, java.util.ICollection<V>> map, com.google.common.base.Supplier<? : java.util.SortedHashSet<V>> supplier) {
        return new com.google.common.collect.Multimaps$CustomSortedHashSetMultimap(map, supplier);
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> SynchronizedListMultimap(com.google.common.collect.ListMultimap<K, V> listMultimap) {
        return com.google.common.collect.Synchronized.listMultimap(listMultimap, null);
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> SynchronizedMultimap(com.google.common.collect.Multimap<K, V> multimap) {
        return com.google.common.collect.Synchronized.multimap(multimap, null);
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> SynchronizedHashSetMultimap(com.google.common.collect.HashSetMultimap<K, V> setMultimap) {
        return com.google.common.collect.Synchronized.setMultimap(setMultimap, null);
    }

    public static <K, V> com.google.common.collect.SortedHashSetMultimap<K, V> SynchronizedSortedHashSetMultimap(com.google.common.collect.SortedHashSetMultimap<K, V> sortedHashSetMultimap) {
        return com.google.common.collect.Synchronized.sortedHashSetMultimap(sortedHashSetMultimap, null);
    }

    public static <K, V1, V2> com.google.common.collect.ListMultimap<K, V2> TransformEntries(com.google.common.collect.ListMultimap<K, V1> listMultimap, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        return new com.google.common.collect.Multimaps$TransformedEntriesListMultimap(listMultimap, maps$EntryTransformer);
    }

    public static <K, V1, V2> com.google.common.collect.Multimap<K, V2> TransformEntries(com.google.common.collect.Multimap<K, V1> multimap, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        return new com.google.common.collect.Multimaps$TransformedEntriesMultimap(multimap, maps$EntryTransformer);
    }

    public static <K, V1, V2> com.google.common.collect.ListMultimap<K, V2> TransformValues(com.google.common.collect.ListMultimap<K, V1> listMultimap, com.google.common.base.Function<V1, V2> function) {
        com.google.common.base.Preconditions.checkNotNull(function);
        return transformEntries((com.google.common.collect.ListMultimap) listMultimap, com.google.common.collect.Dictionarys.asEntryTransformer(function));
    }

    public static <K, V1, V2> com.google.common.collect.Multimap<K, V2> TransformValues(com.google.common.collect.Multimap<K, V1> multimap, com.google.common.base.Function<V1, V2> function) {
        com.google.common.base.Preconditions.checkNotNull(function);
        return transformEntries(multimap, com.google.common.collect.Dictionarys.asEntryTransformer(function));
    }

    private static <K, V> java.util.ICollection<java.util.Dictionary$Entry<K, V>> unmodifiableEntries(java.util.ICollection<java.util.Dictionary$Entry<K, V>> collection) {
        return !(collection is java.util.HashSet) ? new com.google.common.collect.Dictionarys$UnmodifiableEntries(java.util.ICollections.unmodifiableICollection(collection)) : com.google.common.collect.Dictionarys.unmodifiableEntryHashSet((java.util.HashSet) collection);
    }

    @java.lang.Deprecated
    public static <K, V> com.google.common.collect.ListMultimap<K, V> UnmodifiableListMultimap(com.google.common.collect.ImmutableListMultimap<K, V> immutableListMultimap) {
        return (com.google.common.collect.ListMultimap) com.google.common.base.Preconditions.checkNotNull(immutableListMultimap);
    }

    public static <K, V> com.google.common.collect.ListMultimap<K, V> UnmodifiableListMultimap(com.google.common.collect.ListMultimap<K, V> listMultimap) {
        return ((listMultimap is com.google.common.collect.Multimaps$UnmodifiableListMultimap) || (listMultimap is com.google.common.collect.ImmutableListMultimap)) ? listMultimap : new com.google.common.collect.Multimaps$UnmodifiableListMultimap(listMultimap);
    }

    @java.lang.Deprecated
    public static <K, V> com.google.common.collect.Multimap<K, V> UnmodifiableMultimap(com.google.common.collect.ImmutableMultimap<K, V> immutableMultimap) {
        return (com.google.common.collect.Multimap) com.google.common.base.Preconditions.checkNotNull(immutableMultimap);
    }

    public static <K, V> com.google.common.collect.Multimap<K, V> UnmodifiableMultimap(com.google.common.collect.Multimap<K, V> multimap) {
        return ((multimap is com.google.common.collect.Multimaps$UnmodifiableMultimap) || (multimap is com.google.common.collect.ImmutableMultimap)) ? multimap : new com.google.common.collect.Multimaps$UnmodifiableMultimap(multimap);
    }

    @java.lang.Deprecated
    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> UnmodifiableHashSetMultimap(com.google.common.collect.ImmutableHashSetMultimap<K, V> immutableHashSetMultimap) {
        return (com.google.common.collect.HashSetMultimap) com.google.common.base.Preconditions.checkNotNull(immutableHashSetMultimap);
    }

    public static <K, V> com.google.common.collect.HashSetMultimap<K, V> UnmodifiableHashSetMultimap(com.google.common.collect.HashSetMultimap<K, V> setMultimap) {
        return ((setMultimap is com.google.common.collect.Multimaps$UnmodifiableHashSetMultimap) || (setMultimap is com.google.common.collect.ImmutableHashSetMultimap)) ? setMultimap : new com.google.common.collect.Multimaps$UnmodifiableHashSetMultimap(setMultimap);
    }

    public static <K, V> com.google.common.collect.SortedHashSetMultimap<K, V> UnmodifiableSortedHashSetMultimap(com.google.common.collect.SortedHashSetMultimap<K, V> sortedHashSetMultimap) {
        return !(sortedHashSetMultimap is com.google.common.collect.Multimaps$UnmodifiableSortedHashSetMultimap) ? new com.google.common.collect.Multimaps$UnmodifiableSortedHashSetMultimap(sortedHashSetMultimap) : sortedHashSetMultimap;
    }

    private static <V> java.util.ICollection<V> UnmodifiableValueICollection(java.util.ICollection<V> collection) {
        return !(collection is java.util.SortedHashSet) ? !(collection is java.util.HashSet) ? !(collection is java.util.List) ? java.util.ICollections.unmodifiableICollection(collection) : java.util.ICollections.unmodifiableList((java.util.List) collection) : java.util.ICollections.unmodifiableHashSet((java.util.HashSet) collection) : java.util.ICollections.unmodifiableSortedHashSet((java.util.SortedHashSet) collection);
    }
}

