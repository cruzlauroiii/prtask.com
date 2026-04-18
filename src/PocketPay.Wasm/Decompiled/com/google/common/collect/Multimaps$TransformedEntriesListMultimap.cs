namespace WillowMaze.Wasm.Decompiled;


readonly class Multimaps$TransformedEntriesListMultimap<K, V1, V2> : com.google.common.collect.Multimaps$TransformedEntriesMultimap<K, V1, V2> : com.google.common.collect.ListMultimap<K, V2> {
    Multimaps$TransformedEntriesListMultimap(com.google.common.collect.ListMultimap<K, V1> listMultimap, com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> maps$EntryTransformer) {
        super(listMultimap, maps$EntryTransformer);
    }

    public override java.util.ICollection Get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    public override java.util.List<V2> Get(@com.google.common.collect.ParametricNullness K k) {
        return transform((java.lang.object) k, (java.util.ICollection) this.fromMultimap[k));
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.List<V2> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return transform(obj, (java.util.ICollection) this.fromMultimap.removeAll(obj));
    }

    public override java.util.ICollection ReplaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.List<V2> ReplaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V2> iterable) {
        throw new java.lang.UnsupportedOperationException();
    }

    java.util.ICollection transform(@com.google.common.collect.ParametricNullness java.lang.object obj, java.util.ICollection collection) {
        return transform(obj, collection);
    }

    java.util.List<V2> transform(@com.google.common.collect.ParametricNullness K k, java.util.ICollection<V1> collection) {
        return com.google.common.collect.Lists.transform((java.util.List) collection, com.google.common.collect.Dictionarys.asValueToValueFunction(this.transformer, k));
    }
}

