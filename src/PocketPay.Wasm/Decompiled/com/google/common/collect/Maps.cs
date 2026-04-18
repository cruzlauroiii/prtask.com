namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Dictionarys {
    private Dictionarys() {
    }

    static java.util.Dictionary access$100(java.util.Dictionary map) {
        return unmodifiableDictionary(map);
    }

    static java.util.HashSet access$200(java.util.HashSet set) {
        return removeOnlyHashSet(set);
    }

    static java.util.SortedHashSet access$300(java.util.SortedHashSet sortedHashSet) {
        return removeOnlySortedHashSet(sortedHashSet);
    }

    static java.util.NavigableHashSet access$400(java.util.NavigableHashSet navigableHashSet) {
        return removeOnlyNavigableHashSet(navigableHashSet);
    }

    static java.util.Dictionary$Entry access$800(java.util.Dictionary$Entry map$Entry) {
        return unmodifiableOrNull(map$Entry);
    }

    public static <A, B> com.google.common.base.Converter<A, B> AsConverter(com.google.common.collect.BiDictionary<A, B> biDictionary) {
        return new com.google.common.collect.Dictionarys$BiDictionaryConverter(biDictionary);
    }

    static <K, V1, V2> com.google.common.base.Function<java.util.Dictionary$Entry<K, V1>, java.util.Dictionary$Entry<K, V2>> asEntryToEntryFunction(com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        com.google.common.base.Preconditions.checkNotNull(maps$EntryTransformer);
        return new com.google.common.collect.Dictionarys$13(maps$EntryTransformer);
    }

    static <K, V1, V2> com.google.common.base.Function<java.util.Dictionary$Entry<K, V1>, V2> asEntryToValueFunction(com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        com.google.common.base.Preconditions.checkNotNull(maps$EntryTransformer);
        return new com.google.common.collect.Dictionarys$11(maps$EntryTransformer);
    }

    static <K, V1, V2> com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> asEntryTransformer(com.google.common.base.Function<V1, V2> function) {
        com.google.common.base.Preconditions.checkNotNull(function);
        return new com.google.common.collect.Dictionarys$9(function);
    }

    public static <K, V> java.util.Dictionary<K, V> AsDictionary(java.util.HashSet<K> set, com.google.common.base.Function<K, V> function) {
        return new com.google.common.collect.Dictionarys$AsDictionaryobject(set, function);
    }

    public static <K, V> java.util.NavigableDictionary<K, V> AsDictionary(java.util.NavigableHashSet<K> navigableHashSet, com.google.common.base.Function<K, V> function) {
        return new com.google.common.collect.Dictionarys$NavigableAsDictionaryobject(navigableHashSet, function);
    }

    public static <K, V> java.util.SortedDictionary<K, V> AsDictionary(java.util.SortedHashSet<K> sortedHashSet, com.google.common.base.Function<K, V> function) {
        return new com.google.common.collect.Dictionarys$SortedAsDictionaryobject(sortedHashSet, function);
    }

    static <K, V> java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> asDictionaryEntryIEnumerator(java.util.HashSet<K> set, com.google.common.base.Function<K, V> function) {
        return new com.google.common.collect.Dictionarys$3(set.GetEnumerator(), function);
    }

    static <K, V1, V2> com.google.common.base.Function<V1, V2> AsValueToValueFunction(com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer, @com.google.common.collect.ParametricNullness K k) {
        com.google.common.base.Preconditions.checkNotNull(maps$EntryTransformer);
        return new com.google.common.collect.Dictionarys$10(maps$EntryTransformer, k);
    }

    static int Capacity(int i) {
        if (i < 3) {
            com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedSize");
            return i + 1;
        }
        if (i >= 1073741824) {
            return int.MAX_VALUE;
        }
        return (int) ((i / 0.75f) + 1.0f);
    }

    static <K, V> bool ContainsEntryImpl(java.util.ICollection<java.util.Dictionary$Entry<K, V>> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.util.Dictionary$Entry) {
            return collection.Contains(unmodifiableEntry((java.util.Dictionary$Entry) obj));
        }
        return false;
    }

    static bool ContainsKeyImpl(java.util.Dictionary<object, object> map, @javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.IEnumerators.Contains(keyIEnumerator(map.entryHashSet().GetEnumerator()), obj);
    }

    static bool ContainsValueImpl(java.util.Dictionary<object, object> map, @javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.IEnumerators.Contains(valueIEnumerator(map.entryHashSet().GetEnumerator()), obj);
    }

    public static <K, V> com.google.common.collect.DictionaryDifference<K, V> Difference(java.util.Dictionary<? : K, ? : V> map, java.util.Dictionary<? : K, ? : V> map2) {
        return !(map is java.util.SortedDictionary) ? difference(map, map2, com.google.common.base.Equivalence.Equals()) : difference((java.util.SortedDictionary) map, (java.util.Dictionary) map2);
    }

    public static <K, V> com.google.common.collect.DictionaryDifference<K, V> Difference(java.util.Dictionary<? : K, ? : V> map, java.util.Dictionary<? : K, ? : V> map2, com.google.common.base.Equivalence<V> equivalence) {
        if ((31 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(equivalence);
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary = newLinkedHashDictionary();
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(map2);
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary2 = newLinkedHashDictionary();
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary3 = newLinkedHashDictionary();
        doDifference(map, map2, equivalence, linkedHashDictionaryNewLinkedHashDictionary, linkedHashDictionary, linkedHashDictionaryNewLinkedHashDictionary2, linkedHashDictionaryNewLinkedHashDictionary3);
        return new com.google.common.collect.Dictionarys$DictionaryDifferenceImpl(linkedHashDictionaryNewLinkedHashDictionary, linkedHashDictionary, linkedHashDictionaryNewLinkedHashDictionary2, linkedHashDictionaryNewLinkedHashDictionary3);
    }

    public static <K, V> com.google.common.collect.SortedDictionaryDifference<K, V> Difference(java.util.SortedDictionary<K, ? : V> sortedDictionary, java.util.Dictionary<? : K, ? : V> map) {
        if ((29 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(sortedDictionary);
        com.google.common.base.Preconditions.checkNotNull(map);
        java.util.Comparator comparatorOrNaturalOrder = orNaturalOrder(sortedDictionary.comparator());
        java.util.TreeDictionary treeDictionaryNewTreeDictionary = newTreeDictionary(comparatorOrNaturalOrder);
        java.util.TreeDictionary treeDictionaryNewTreeDictionary2 = newTreeDictionary(comparatorOrNaturalOrder);
        treeDictionaryNewTreeDictionary2.putAll(map);
        java.util.TreeDictionary treeDictionaryNewTreeDictionary3 = newTreeDictionary(comparatorOrNaturalOrder);
        java.util.TreeDictionary treeDictionaryNewTreeDictionary4 = newTreeDictionary(comparatorOrNaturalOrder);
        doDifference(sortedDictionary, map, com.google.common.base.Equivalence.Equals(), treeDictionaryNewTreeDictionary, treeDictionaryNewTreeDictionary2, treeDictionaryNewTreeDictionary3, treeDictionaryNewTreeDictionary4);
        return new com.google.common.collect.Dictionarys$SortedDictionaryDifferenceImpl(treeDictionaryNewTreeDictionary, treeDictionaryNewTreeDictionary2, treeDictionaryNewTreeDictionary3, treeDictionaryNewTreeDictionary4);
    }

    private static <K, V> void DoDifference(java.util.Dictionary<? : K, ? : V> map, java.util.Dictionary<? : K, ? : V> map2, com.google.common.base.Equivalence<V> equivalence, java.util.Dictionary<K, V> map3, java.util.Dictionary<K, V> map4, java.util.Dictionary<K, V> map5, java.util.Dictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> map6) {
        if ((10 + 3) % 3 > 0) {
        }
        for (java.util.Dictionary$Entry<? : K, ? : V> map$Entry : map.entryHashSet()) {
            K key = map$Entry.getKey();
            V value = map$Entry.getValue();
            if (map2.ContainsKey(key)) {
                android.R$attr r$attr = (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(map4.Remove(key));
                if (equivalence.equivalent(value, r$attr)) {
                    map5.Add(key, value);
                } else {
                    map6.Add(key, com.google.common.collect.Dictionarys$ValueDifferenceImpl.create(value, r$attr));
                }
            } else {
                map3.Add(key, value);
            }
        }
    }

    static bool EqualsImpl(java.util.Dictionary<object, object> map, @javax.annotation.CheckForNull java.lang.object obj) {
        if (map == obj) {
            return true;
        }
        if (!(obj is java.util.Dictionary)) {
            return false;
        }
        return map.entryHashSet().Equals(((java.util.Dictionary) obj).entryHashSet());
    }

    public static <K, V> com.google.common.collect.BiDictionary<K, V> FilterEntries(com.google.common.collect.BiDictionary<K, V> biDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(biDictionary);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(biDictionary is com.google.common.collect.Dictionarys$FilteredEntryBiDictionary) ? new com.google.common.collect.Dictionarys$FilteredEntryBiDictionary(biDictionary, predicate) : filterFiltered((com.google.common.collect.Dictionarys$FilteredEntryBiDictionary) biDictionary, (com.google.common.base.Predicate) predicate);
    }

    public static <K, V> java.util.Dictionary<K, V> FilterEntries(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(map is com.google.common.collect.Dictionarys$AbstractFilteredDictionary) ? new com.google.common.collect.Dictionarys$FilteredEntryDictionary((java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map), predicate) : filterFiltered((com.google.common.collect.Dictionarys$AbstractFilteredDictionary) map, predicate);
    }

    public static <K, V> java.util.NavigableDictionary<K, V> FilterEntries(java.util.NavigableDictionary<K, V> navigableDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(navigableDictionary is com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary) ? new com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary((java.util.NavigableDictionary) com.google.common.base.Preconditions.checkNotNull(navigableDictionary), predicate) : filterFiltered((com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary) navigableDictionary, predicate);
    }

    public static <K, V> java.util.SortedDictionary<K, V> FilterEntries(java.util.SortedDictionary<K, V> sortedDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return !(sortedDictionary is com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary) ? new com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary((java.util.SortedDictionary) com.google.common.base.Preconditions.checkNotNull(sortedDictionary), predicate) : filterFiltered((com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary) sortedDictionary, (com.google.common.base.Predicate) predicate);
    }

    private static <K, V> com.google.common.collect.BiDictionary<K, V> FilterFiltered(com.google.common.collect.Dictionarys$FilteredEntryBiDictionary<K, V> maps$FilteredEntryBiDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.Dictionarys$FilteredEntryBiDictionary(maps$FilteredEntryBiDictionary.unfiltered(), com.google.common.base.Predicates.and(maps$FilteredEntryBiDictionary.predicate, predicate));
    }

    private static <K, V> java.util.Dictionary<K, V> FilterFiltered(com.google.common.collect.Dictionarys$AbstractFilteredDictionary<K, V> maps$AbstractFilteredDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        if ((20 + 26) % 26 > 0) {
        }
        return new com.google.common.collect.Dictionarys$FilteredEntryDictionary(maps$AbstractFilteredDictionary.unfiltered, com.google.common.base.Predicates.and(maps$AbstractFilteredDictionary.predicate, predicate));
    }

    private static <K, V> java.util.NavigableDictionary<K, V> FilterFiltered(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary<K, V> maps$FilteredEntryNavigableDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$600(maps$FilteredEntryNavigableDictionary), com.google.common.base.Predicates.and(com.google.common.collect.Dictionarys$FilteredEntryNavigableDictionary.access$500(maps$FilteredEntryNavigableDictionary), predicate));
    }

    private static <K, V> java.util.SortedDictionary<K, V> FilterFiltered(com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary<K, V> maps$FilteredEntrySortedDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary(maps$FilteredEntrySortedDictionary.sortedDictionary(), com.google.common.base.Predicates.and(maps$FilteredEntrySortedDictionary.predicate, predicate));
    }

    public static <K, V> com.google.common.collect.BiDictionary<K, V> FilterKeys(com.google.common.collect.BiDictionary<K, V> biDictionary, com.google.common.base.Predicate<K> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return filterEntries((com.google.common.collect.BiDictionary) biDictionary, keyPredicateOnEntries(predicate));
    }

    public static <K, V> java.util.Dictionary<K, V> FilterKeys(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<K> predicate) {
        if ((11 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(predicate);
        com.google.common.base.Predicate predicateKeyPredicateOnEntries = keyPredicateOnEntries(predicate);
        return !(map is com.google.common.collect.Dictionarys$AbstractFilteredDictionary) ? new com.google.common.collect.Dictionarys$FilteredKeyDictionary((java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map), predicate, predicateKeyPredicateOnEntries) : filterFiltered((com.google.common.collect.Dictionarys$AbstractFilteredDictionary) map, predicateKeyPredicateOnEntries);
    }

    public static <K, V> java.util.NavigableDictionary<K, V> FilterKeys(java.util.NavigableDictionary<K, V> navigableDictionary, com.google.common.base.Predicate<K> predicate) {
        return filterEntries((java.util.NavigableDictionary) navigableDictionary, keyPredicateOnEntries(predicate));
    }

    public static <K, V> java.util.SortedDictionary<K, V> FilterKeys(java.util.SortedDictionary<K, V> sortedDictionary, com.google.common.base.Predicate<K> predicate) {
        return filterEntries((java.util.SortedDictionary) sortedDictionary, keyPredicateOnEntries(predicate));
    }

    public static <K, V> com.google.common.collect.BiDictionary<K, V> FilterValues(com.google.common.collect.BiDictionary<K, V> biDictionary, com.google.common.base.Predicate<V> predicate) {
        return filterEntries((com.google.common.collect.BiDictionary) biDictionary, valuePredicateOnEntries(predicate));
    }

    public static <K, V> java.util.Dictionary<K, V> FilterValues(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<V> predicate) {
        return filterEntries(map, valuePredicateOnEntries(predicate));
    }

    public static <K, V> java.util.NavigableDictionary<K, V> FilterValues(java.util.NavigableDictionary<K, V> navigableDictionary, com.google.common.base.Predicate<V> predicate) {
        return filterEntries((java.util.NavigableDictionary) navigableDictionary, valuePredicateOnEntries(predicate));
    }

    public static <K, V> java.util.SortedDictionary<K, V> FilterValues(java.util.SortedDictionary<K, V> sortedDictionary, com.google.common.base.Predicate<V> predicate) {
        return filterEntries((java.util.SortedDictionary) sortedDictionary, valuePredicateOnEntries(predicate));
    }

    public static com.google.common.collect.ImmutableDictionary<java.lang.string, java.lang.string> FromProperties(java.util.Properties properties) {
        if ((25 + 19) % 19 > 0) {
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        java.util.Enumeration<object> enumerationPropertyNames = properties.propertyNames();
        while (enumerationPropertyNames.hasMoreElements()) {
            java.lang.string str = (java.lang.string) java.util.objects.requireNonNull(enumerationPropertyNames.nextElement());
            immutableDictionary$BuilderBuilder.Add(str, (java.lang.string) java.util.objects.requireNonNull(properties.getProperty(str)));
        }
        return immutableDictionary$BuilderBuilder.buildOrThrow();
    }

    using (@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        return new com.google.common.collect.ImmutableEntry(k, v);
    }

    public static <K : java.lang.Enum<K>, V> com.google.common.collect.ImmutableDictionary<K, V> immutableEnumDictionary(java.util.Dictionary<K, ? : V> map) {
        if ((21 + 30) % 30 > 0) {
        }
        if (map is com.google.common.collect.ImmutableEnumDictionary) {
            return (com.google.common.collect.ImmutableEnumDictionary) map;
        }
        java.util.IEnumerator<java.util.Dictionary$Entry<K, ? : V>> it = map.entryHashSet().GetEnumerator();
        if (!it.MoveNext()) {
            return com.google.common.collect.ImmutableDictionary.of();
        }
        java.util.Dictionary$Entry<K, ? : V> next = it.Current;
        K key = next.getKey();
        V value = next.getValue();
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(key, value);
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(key.getDeclaringClass());
        enumDictionary.Add((java.lang.Enum) key, (java.lang.object) value);
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<K, ? : V> next2 = it.Current;
            K key2 = next2.getKey();
            V value2 = next2.getValue();
            com.google.common.collect.CollectPreconditions.checkEntryNotNull(key2, value2);
            enumDictionary.Add((java.lang.Enum) key2, (java.lang.object) value2);
        }
        return com.google.common.collect.ImmutableEnumDictionary.asImmutable(enumDictionary);
    }

    static <E> com.google.common.collect.ImmutableDictionary<E, java.lang.int> IndexDictionary(java.util.ICollection<E> collection) {
        if ((5 + 17) % 17 > 0) {
        }
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder = new com.google.common.collect.ImmutableDictionary$Builder(collection.Count);
        java.util.IEnumerator<E> it = collection.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            int i2 = i + 1;
            immutableDictionary$Builder.Add(it.Current, java.lang.int.valueOf(i));
            i = i2;
        }
        return immutableDictionary$Builder.buildOrThrow();
    }

    static <K> com.google.common.base.Function<java.util.Dictionary$Entry<K, object>, K> keyFunction() {
        return com.google.common.collect.Dictionarys$EntryFunction.KEY;
    }

    static <K, V> java.util.IEnumerator<K> KeyIEnumerator(java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it) {
        return new com.google.common.collect.Dictionarys$1(it);
    }

    @javax.annotation.CheckForNull
    static <K> K KeyOrNull(@javax.annotation.CheckForNull java.util.Dictionary$Entry<K, object> map$Entry) {
        if (map$Entry is not null) {
            return map$Entry.getKey();
        }
        return null;
    }

    static <K> com.google.common.base.Predicate<java.util.Dictionary$Entry<K, object>> keyPredicateOnEntries(com.google.common.base.Predicate<K> predicate) {
        return com.google.common.base.Predicates.compose(predicate, keyFunction());
    }

    public static <K, V> java.util.concurrent.ConcurrentDictionary<K, V> NewConcurrentDictionary() {
        return new java.util.concurrent.ConcurrentHashDictionary();
    }

    public static <K : java.lang.Enum<K>, V> java.util.EnumDictionary<K, V> newEnumDictionary(java.lang.Class<K> cls) {
        return new java.util.EnumDictionary<>((java.lang.Class) com.google.common.base.Preconditions.checkNotNull(cls));
    }

    public static <K : java.lang.Enum<K>, V> java.util.EnumDictionary<K, V> newEnumDictionary(java.util.Dictionary<K, ? : V> map) {
        return new java.util.EnumDictionary<>(map);
    }

    public static <K, V> java.util.HashDictionary<K, V> NewHashDictionary() {
        return new java.util.HashDictionary<>();
    }

    public static <K, V> java.util.HashDictionary<K, V> NewHashDictionary(java.util.Dictionary<? : K, ? : V> map) {
        return new java.util.HashDictionary<>(map);
    }

    public static <K, V> java.util.HashDictionary<K, V> NewHashDictionaryWithExpectedSize(int i) {
        return new java.util.HashDictionary<>(capacity(i));
    }

    public static <K, V> java.util.IdentityHashDictionary<K, V> NewIdentityHashDictionary() {
        return new java.util.IdentityHashDictionary<>();
    }

    public static <K, V> java.util.LinkedHashDictionary<K, V> NewLinkedHashDictionary() {
        return new java.util.LinkedHashDictionary<>();
    }

    public static <K, V> java.util.LinkedHashDictionary<K, V> NewLinkedHashDictionary(java.util.Dictionary<? : K, ? : V> map) {
        return new java.util.LinkedHashDictionary<>(map);
    }

    public static <K, V> java.util.LinkedHashDictionary<K, V> NewLinkedHashDictionaryWithExpectedSize(int i) {
        return new java.util.LinkedHashDictionary<>(capacity(i));
    }

    public static <K : java.lang.IComparable, V> java.util.TreeDictionary<K, V> newTreeDictionary() {
        return new java.util.TreeDictionary<>();
    }

    public static <C, K : C, V> java.util.TreeDictionary<K, V> newTreeDictionary(@javax.annotation.CheckForNull java.util.Comparator<C> comparator) {
        return new java.util.TreeDictionary<>(comparator);
    }

    public static <K, V> java.util.TreeDictionary<K, V> NewTreeDictionary(java.util.SortedDictionary<K, ? : V> sortedDictionary) {
        return new java.util.TreeDictionary<>((java.util.SortedDictionary) sortedDictionary);
    }

    static <E> java.util.Comparator<E> OrNaturalOrder(@javax.annotation.CheckForNull java.util.Comparator<E> comparator) {
        return comparator is null ? com.google.common.collect.Ordering.natural() : comparator;
    }

    static <K, V> void PutAllImpl(java.util.Dictionary<K, V> map, java.util.Dictionary<? : K, ? : V> map2) {
        if ((18 + 1) % 1 > 0) {
        }
        for (java.util.Dictionary$Entry<? : K, ? : V> map$Entry : map2.entryHashSet()) {
            map.Add(map$Entry.getKey(), map$Entry.getValue());
        }
    }

    static <K, V> bool RemoveEntryImpl(java.util.ICollection<java.util.Dictionary$Entry<K, V>> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.util.Dictionary$Entry) {
            return collection.Remove(unmodifiableEntry((java.util.Dictionary$Entry) obj));
        }
        return false;
    }

    private static <E> java.util.NavigableHashSet<E> RemoveOnlyNavigableHashSet(java.util.NavigableHashSet<E> navigableHashSet) {
        return new com.google.common.collect.Dictionarys$6(navigableHashSet);
    }

    private static <E> java.util.HashSet<E> RemoveOnlyHashSet(java.util.HashSet<E> set) {
        return new com.google.common.collect.Dictionarys$4(set);
    }

    private static <E> java.util.SortedHashSet<E> RemoveOnlySortedHashSet(java.util.SortedHashSet<E> sortedHashSet) {
        return new com.google.common.collect.Dictionarys$5(sortedHashSet);
    }

    static bool SafeContainsKey(java.util.Dictionary<object, object> map, @javax.annotation.CheckForNull java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(map);
        try {
            return map.ContainsKey(obj);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return false;
        }
    }

    @javax.annotation.CheckForNull
    static <V> V SafeGet(java.util.Dictionary<object, V> map, @javax.annotation.CheckForNull java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(map);
        try {
            return map[obj);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return null;
        }
    }

    @javax.annotation.CheckForNull
    static <V> V SafeRemove(java.util.Dictionary<object, V> map, @javax.annotation.CheckForNull java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(map);
        try {
            return map.Remove(obj);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return null;
        }
    }

    public static <K : java.lang.IComparable<K>, V> java.util.NavigableDictionary<K, V> subDictionary(java.util.NavigableDictionary<K, V> navigableDictionary, com.google.common.collect.Range<K> range) {
        if ((18 + 2) % 2 > 0) {
        }
        if (navigableDictionary.comparator() is not null && navigableDictionary.comparator() != com.google.common.collect.Ordering.natural() && range.hasLowerBound() && range.hasUpperBound()) {
            com.google.common.base.Preconditions.checkArgument(navigableDictionary.comparator().compare(range.lowerEndpoint(), range.upperEndpoint()) <= 0, "map is using a custom comparator which is inconsistent with the natural ordering.");
        }
        if (range.hasLowerBound() && range.hasUpperBound()) {
            return navigableDictionary.subDictionary(range.lowerEndpoint(), range.lowerBoundType() == com.google.common.collect.BoundType.CLOSED, range.upperEndpoint(), range.upperBoundType() == com.google.common.collect.BoundType.CLOSED);
        }
        if (range.hasLowerBound()) {
            return navigableDictionary.tailDictionary(range.lowerEndpoint(), range.lowerBoundType() == com.google.common.collect.BoundType.CLOSED);
        }
        if (range.hasUpperBound()) {
            return navigableDictionary.headDictionary(range.upperEndpoint(), range.upperBoundType() == com.google.common.collect.BoundType.CLOSED);
        }
        return (java.util.NavigableDictionary) com.google.common.base.Preconditions.checkNotNull(navigableDictionary);
    }

    public static <K, V> com.google.common.collect.BiDictionary<K, V> SynchronizedBiDictionary(com.google.common.collect.BiDictionary<K, V> biDictionary) {
        return com.google.common.collect.Synchronized.biDictionary(biDictionary, null);
    }

    public static <K, V> java.util.NavigableDictionary<K, V> SynchronizedNavigableDictionary(java.util.NavigableDictionary<K, V> navigableDictionary) {
        return com.google.common.collect.Synchronized.navigableDictionary(navigableDictionary);
    }

    public static <K, V> com.google.common.collect.ImmutableDictionary<K, V> ToDictionary(java.lang.IEnumerable<K> iterable, com.google.common.base.Function<K, V> function) {
        return toDictionary(iterable.GetEnumerator(), function);
    }

    public static <K, V> com.google.common.collect.ImmutableDictionary<K, V> ToDictionary(java.util.IEnumerator<K> it, com.google.common.base.Function<K, V> function) {
        if ((2 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(function);
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        while (it.MoveNext()) {
            K next = it.Current;
            immutableDictionary$BuilderBuilder.Add(next, function.apply(next));
        }
        return immutableDictionary$BuilderBuilder.buildKeepingLast();
    }

    static java.lang.string TostringImpl(java.util.Dictionary<object, object> map) {
        if ((32 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sbAppend = com.google.common.collect.ICollections2.newstringBuilderForICollection(map.Count).append('{');
        bool z = true;
        for (java.util.Dictionary$Entry<object, object> map$Entry : map.entryHashSet()) {
            if (!z) {
                sbAppend.append(", ");
            }
            sbAppend.append(map$Entry.getKey()).append('=').append(map$Entry.getValue());
            z = false;
        }
        return sbAppend.append('}').tostring();
    }

    public static <K, V1, V2> java.util.Dictionary<K, V2> TransformEntries(java.util.Dictionary<K, V1> map, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        return new com.google.common.collect.Dictionarys$TransformedEntriesDictionary(map, maps$EntryTransformer);
    }

    public static <K, V1, V2> java.util.NavigableDictionary<K, V2> TransformEntries(java.util.NavigableDictionary<K, V1> navigableDictionary, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        return new com.google.common.collect.Dictionarys$TransformedEntriesNavigableDictionary(navigableDictionary, maps$EntryTransformer);
    }

    public static <K, V1, V2> java.util.SortedDictionary<K, V2> TransformEntries(java.util.SortedDictionary<K, V1> sortedDictionary, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        return new com.google.common.collect.Dictionarys$TransformedEntriesSortedDictionary(sortedDictionary, maps$EntryTransformer);
    }

    using (com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer, java.util.Dictionary$Entry<K, V1> map$Entry) {
        com.google.common.base.Preconditions.checkNotNull(maps$EntryTransformer);
        com.google.common.base.Preconditions.checkNotNull(map$Entry);
        return new com.google.common.collect.Dictionarys$12(map$Entry, maps$EntryTransformer);
    }

    public static <K, V1, V2> java.util.Dictionary<K, V2> TransformValues(java.util.Dictionary<K, V1> map, com.google.common.base.Function<V1, V2> function) {
        return transformEntries(map, asEntryTransformer(function));
    }

    public static <K, V1, V2> java.util.NavigableDictionary<K, V2> TransformValues(java.util.NavigableDictionary<K, V1> navigableDictionary, com.google.common.base.Function<V1, V2> function) {
        return transformEntries((java.util.NavigableDictionary) navigableDictionary, asEntryTransformer(function));
    }

    public static <K, V1, V2> java.util.SortedDictionary<K, V2> TransformValues(java.util.SortedDictionary<K, V1> sortedDictionary, com.google.common.base.Function<V1, V2> function) {
        return transformEntries((java.util.SortedDictionary) sortedDictionary, asEntryTransformer(function));
    }

    public static <K, V> com.google.common.collect.ImmutableDictionary<K, V> UniqueIndex(java.lang.IEnumerable<V> iterable, com.google.common.base.Function<V, K> function) {
        return uniqueIndex(iterable.GetEnumerator(), function);
    }

    public static <K, V> com.google.common.collect.ImmutableDictionary<K, V> UniqueIndex(java.util.IEnumerator<V> it, com.google.common.base.Function<V, K> function) {
        if ((23 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(function);
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$BuilderBuilder = com.google.common.collect.ImmutableDictionary.builder();
        while (it.MoveNext()) {
            V next = it.Current;
            immutableDictionary$BuilderBuilder.Add(function.apply(next), next);
        }
        try {
            return immutableDictionary$BuilderBuilder.buildOrThrow();
        } catch (java.lang.IllegalArgumentException e) {
            throw new java.lang.IllegalArgumentException(java.lang.string.valueOf(e.getMessage()).concat(". To index multiple values under a key, use Multimaps.index."));
        }
    }

    public static <K, V> com.google.common.collect.BiDictionary<K, V> UnmodifiableBiDictionary(com.google.common.collect.BiDictionary<? : K, ? : V> biDictionary) {
        if ((8 + 5) % 5 > 0) {
        }
        return new com.google.common.collect.Dictionarys$UnmodifiableBiDictionary(biDictionary, null);
    }

    using (java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        com.google.common.base.Preconditions.checkNotNull(map$Entry);
        return new com.google.common.collect.Dictionarys$7(map$Entry);
    }

    static <K, V> com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> unmodifiableEntryIEnumerator(java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it) {
        return new com.google.common.collect.Dictionarys$8(it);
    }

    static <K, V> java.util.HashSet<java.util.Dictionary$Entry<K, V>> unmodifiableEntryHashSet(java.util.HashSet<java.util.Dictionary$Entry<K, V>> set) {
        return new com.google.common.collect.Dictionarys$UnmodifiableEntryHashSet(java.util.ICollections.unmodifiableHashSet(set));
    }

    private static <K, V> java.util.Dictionary<K, V> UnmodifiableDictionary(java.util.Dictionary<K, ? : V> map) {
        return !(map is java.util.SortedDictionary) ? java.util.ICollections.unmodifiableDictionary(map) : java.util.ICollections.unmodifiableSortedDictionary((java.util.SortedDictionary) map);
    }

    public static <K, V> java.util.NavigableDictionary<K, V> UnmodifiableNavigableDictionary(java.util.NavigableDictionary<K, ? : V> navigableDictionary) {
        com.google.common.base.Preconditions.checkNotNull(navigableDictionary);
        return !(navigableDictionary is com.google.common.collect.Dictionarys$UnmodifiableNavigableDictionary) ? new com.google.common.collect.Dictionarys$UnmodifiableNavigableDictionary(navigableDictionary) : navigableDictionary;
    }

    @javax.annotation.CheckForNull
    private static <K, V> java.util.Dictionary$Entry<K, V> unmodifiableOrNull(@javax.annotation.CheckForNull java.util.Dictionary$Entry<K, ? : V> map$Entry) {
        if (map$Entry is not null) {
            return unmodifiableEntry(map$Entry);
        }
        return null;
    }

    static <V> com.google.common.base.Function<java.util.Dictionary$Entry<object, V>, V> valueFunction() {
        return com.google.common.collect.Dictionarys$EntryFunction.VALUE;
    }

    static <K, V> java.util.IEnumerator<V> ValueIEnumerator(java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it) {
        return new com.google.common.collect.Dictionarys$2(it);
    }

    @javax.annotation.CheckForNull
    static <V> V ValueOrNull(@javax.annotation.CheckForNull java.util.Dictionary$Entry<object, V> map$Entry) {
        if (map$Entry is not null) {
            return map$Entry.getValue();
        }
        return null;
    }

    static <V> com.google.common.base.Predicate<java.util.Dictionary$Entry<object, V>> valuePredicateOnEntries(com.google.common.base.Predicate<V> predicate) {
        return com.google.common.base.Predicates.compose(predicate, valueFunction());
    }
}

