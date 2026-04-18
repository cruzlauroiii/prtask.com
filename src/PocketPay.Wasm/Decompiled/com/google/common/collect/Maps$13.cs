namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$13<K, V1, V2> : com.google.common.base.Function<java.util.Dictionary$Entry<K, V1>, java.util.Dictionary$Entry<K, V2>> {
    readonly com.google.common.collect.Dictionarys$EntryTransformer val$transformer;

    Dictionarys$13(com.google.common.collect.Dictionarys$EntryTransformer maps$EntryTransformer) {
        this.val$transformer = maps$EntryTransformer;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.util.Dictionary$Entry) obj);
    }

    public java.util.Dictionary$Entry<K, V2> apply(java.util.Dictionary$Entry<K, V1> map$Entry) {
        return com.google.common.collect.Dictionarys.transformEntry(this.val$transformer, map$Entry);
    }
}

