namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$9<K, V1, V2> : com.google.common.collect.Dictionarys$EntryTransformer<K, V1, V2> {
    readonly com.google.common.base.Function val$function;

    Dictionarys$9(com.google.common.base.Function function) {
        this.val$function = function;
    }

    @com.google.common.collect.ParametricNullness
    using (@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V1 v1) {
        return (V2) this.val$function.apply(v1);
    }
}

