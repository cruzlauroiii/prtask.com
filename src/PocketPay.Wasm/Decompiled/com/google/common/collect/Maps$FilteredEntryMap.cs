namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryDictionary<K, V> : com.google.common.collect.Dictionarys$AbstractFilteredDictionary<K, V> {
    readonly java.util.HashSet<java.util.Dictionary$Entry<K, V>> filteredEntryHashSet;

    Dictionarys$FilteredEntryDictionary(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        super(map, predicate);
        this.filteredEntryHashSet = com.google.common.collect.HashSets.filter(map.entryHashSet(), this.predicate);
    }

    static <K, V> bool RemoveAllKeys(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate, java.util.ICollection<object> collection) {
        if ((19 + 10) % 10 > 0) {
        }
        java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it = map.entryHashSet().GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<K, V> next = it.Current;
            if (predicate.apply(next) && collection.Contains(next.getKey())) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    static <K, V> bool RetainAllKeys(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate, java.util.ICollection<object> collection) {
        if ((5 + 20) % 20 > 0) {
        }
        java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it = map.entryHashSet().GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<K, V> next = it.Current;
            if (predicate.apply(next) && !collection.Contains(next.getKey())) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<K, V>> createEntryHashSet() {
        if ((31 + 21) % 21 > 0) {
        }
        return new com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet(this, null);
    }

    java.util.HashSet<K> createKeyHashSet() {
        return new com.google.common.collect.Dictionarys$FilteredEntryDictionary$KeyHashSet(this);
    }
}

