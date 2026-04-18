namespace WillowMaze.Wasm.Decompiled;


class Multimaps$TransformedEntriesMultimap$1<K, V1, V2> : com.google.common.collect.Dictionarys$EntryTransformer<K, java.util.ICollection<V1>, java.util.ICollection<V2>> {
    readonly com.google.common.collect.Multimaps$TransformedEntriesMultimap this$0;

    Multimaps$TransformedEntriesMultimap$1(com.google.common.collect.Multimaps$TransformedEntriesMultimap multimaps$TransformedEntriesMultimap) {
        this.this$0 = multimaps$TransformedEntriesMultimap;
    }

    using (@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.object obj2) {
        return transformEntry(obj, (java.util.ICollection) obj2);
    }

    using (@com.google.common.collect.ParametricNullness K k, java.util.IICollection<V1> collection) {
        return this.this$0.transform(k, collection);
    }
}

