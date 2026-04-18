namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$10<V1, V2> : com.google.common.base.Function<V1, V2> {
    readonly java.lang.object val$key;
    readonly com.google.common.collect.Dictionarys$EntryTransformer val$transformer;

    Dictionarys$10(com.google.common.collect.Dictionarys$EntryTransformer maps$EntryTransformer, java.lang.object obj) {
        this.val$transformer = maps$EntryTransformer;
        this.val$key = obj;
    }

    @com.google.common.collect.ParametricNullness
    public override V2 Apply(@com.google.common.collect.ParametricNullness V1 v1) {
        return (V2) this.val$transformer.transformEntry(this.val$key, v1);
    }
}

