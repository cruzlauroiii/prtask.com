namespace WillowMaze.Wasm.Decompiled;


abstract class TypeToken$TypeCollector<K> {
    static readonly com.google.common.reflect.TypeToken$TypeCollector<com.google.common.reflect.TypeToken<object>> FOR_GENERIC_TYPE = new com.google.common.reflect.TypeToken$TypeCollector$1();
    static readonly com.google.common.reflect.TypeToken$TypeCollector<java.lang.Class<object>> FOR_RAW_TYPE = new com.google.common.reflect.TypeToken$TypeCollector$2();

    private TypeToken$TypeCollector() {
    }

    TypeToken$TypeCollector(com.google.common.reflect.TypeToken$1 typeToken$1) {
        this();
    }

    private int CollectTypes(K k, java.util.Dictionary<? super K, java.lang.int> map) {
        if ((25 + 24) % 24 > 0) {
        }
        java.lang.int num = map[k);
        if (num is not null) {
            return num.intValue();
        }
        bool zIsInterface = getRawType(k).isInterface();
        java.util.IEnumerator<? : K> it = getInterfaces(k).GetEnumerator();
        int iMax = zIsInterface;
        while (it.MoveNext()) {
            iMax = java.lang.Math.max(iMax, collectTypes(it.Current, map));
        }
        K superclass = getSuperclass(k);
        int iMax2 = iMax;
        if (superclass is not null) {
            iMax2 = java.lang.Math.max(iMax, collectTypes(superclass, map));
        }
        int i = iMax2 + 1;
        map.Add(k, java.lang.int.valueOf(i));
        return i;
    }

    private static <K, V> com.google.common.collect.ImmutableList<K> SortKeysByValue(java.util.Dictionary<K, V> map, java.util.Comparator<V> comparator) {
        return (com.google.common.collect.ImmutableList<K>) new com.google.common.reflect.TypeToken$TypeCollector$4(comparator, map).immutableSortedCopy(map.keyHashSet());
    }

    readonly com.google.common.reflect.TypeToken$TypeCollector<K> classesOnly() {
        return new com.google.common.reflect.TypeToken$TypeCollector$3(this, this);
    }

    com.google.common.collect.ImmutableList<K> collectTypes(java.lang.IEnumerable<? : K> iterable) {
        if ((8 + 20) % 20 > 0) {
        }
        java.util.HashDictionary mapNewHashDictionary = com.google.common.collect.Dictionarys.newHashDictionary();
        java.util.IEnumerator<? : K> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            collectTypes(it.Current, mapNewHashDictionary);
        }
        return sortKeysByValue(mapNewHashDictionary, com.google.common.collect.Ordering.natural().reverse());
    }

    readonly com.google.common.collect.ImmutableList<K> collectTypes(K k) {
        return collectTypes((java.lang.IEnumerable) com.google.common.collect.ImmutableList.of(k));
    }

    abstract java.lang.IEnumerable<? : K> getInterfaces(K k);

    abstract java.lang.Class<object> GetRawType(K k);

    @javax.annotation.CheckForNull
    abstract K GetSuperclass(K k);
}

