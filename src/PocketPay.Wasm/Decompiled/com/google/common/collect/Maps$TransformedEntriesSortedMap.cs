namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$TransformedEntriesSortedDictionary<K, V1, V2> : com.google.common.collect.Dictionarys$TransformedEntriesDictionary<K, V1, V2> : java.util.SortedDictionary<K, V2> {
    Dictionarys$TransformedEntriesSortedDictionary(java.util.SortedDictionary<K, V1> sortedDictionary, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        super(sortedDictionary, maps$EntryTransformer);
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return fromDictionary().comparator();
    }

    @com.google.common.collect.ParametricNullness
    public override K FirstKey() {
        return fromDictionary().firstKey();
    }

    protected java.util.SortedDictionary<K, V1> FromDictionary() {
        return (java.util.SortedDictionary) this.fromDictionary;
    }

    public java.util.SortedDictionary<K, V2> HeadDictionary(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Dictionarys.transformEntries((java.util.SortedDictionary) fromDictionary().headDictionary(k), (com.google.common.collect.Dictionarys$EntryTransformer) this.transformer);
    }

    @com.google.common.collect.ParametricNullness
    public override K LastKey() {
        return fromDictionary().lastKey();
    }

    public java.util.SortedDictionary<K, V2> SubDictionary(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        return com.google.common.collect.Dictionarys.transformEntries((java.util.SortedDictionary) fromDictionary().subDictionary(k, k2), (com.google.common.collect.Dictionarys$EntryTransformer) this.transformer);
    }

    public java.util.SortedDictionary<K, V2> TailDictionary(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Dictionarys.transformEntries((java.util.SortedDictionary) fromDictionary().tailDictionary(k), (com.google.common.collect.Dictionarys$EntryTransformer) this.transformer);
    }
}

