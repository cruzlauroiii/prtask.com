namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryBiDictionary$1<K, V> : com.google.common.base.Predicate<java.util.Dictionary$Entry<V, K>> {
    readonly com.google.common.base.Predicate val$forwardPredicate;

    Dictionarys$FilteredEntryBiDictionary$1(com.google.common.base.Predicate predicate) {
        this.val$forwardPredicate = predicate;
    }

    public override bool Apply(java.lang.object obj) {
        return apply((java.util.Dictionary$Entry) obj);
    }

    public bool Apply(java.util.Dictionary$Entry<V, K> map$Entry) {
        return this.val$forwardPredicate.apply(com.google.common.collect.Dictionarys.immutableEntry(map$Entry.getValue(), map$Entry.getKey()));
    }
}

