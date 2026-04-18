namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredKeyDictionary<K, V> : com.google.common.collect.Dictionarys$AbstractFilteredDictionary<K, V> {
    readonly com.google.common.base.Predicate<K> keyPredicate;

    Dictionarys$FilteredKeyDictionary(java.util.Dictionary<K, V> map, com.google.common.base.Predicate<K> predicate, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate2) {
        super(map, predicate2);
        this.keyPredicate = predicate;
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.unfiltered.ContainsKey(obj) && this.keyPredicate.apply(obj);
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<K, V>> createEntryHashSet() {
        return com.google.common.collect.HashSets.filter(this.unfiltered.entryHashSet(), this.predicate);
    }

    java.util.HashSet<K> createKeyHashSet() {
        return com.google.common.collect.HashSets.filter(this.unfiltered.keyHashSet(), this.keyPredicate);
    }
}

