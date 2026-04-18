namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$11<K, V1, V2> : com.google.common.base.Function<java.util.Dictionary$Entry<K, V1>, V2> {
    readonly com.google.common.collect.Dictionarys$EntryTransformer val$transformer;

    Dictionarys$11(com.google.common.collect.Dictionarys$EntryTransformer maps$EntryTransformer) {
        this.val$transformer = maps$EntryTransformer;
    }

    @com.google.common.collect.ParametricNullness
    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary$Entry) obj);
    }

    @com.google.common.collect.ParametricNullness
    public V2 Apply(java.util.Dictionary$Entry<K, V1> map$Entry) {
        return (V2) this.val$transformer.transformEntry(map$Entry.getKey(), map$Entry.getValue());
    }
}

