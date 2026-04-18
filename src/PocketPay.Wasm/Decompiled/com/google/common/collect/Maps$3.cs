namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$3<K, V> : com.google.common.collect.TransformedIEnumerator<K, java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.base.Function val$function;

    Dictionarys$3(java.util.IEnumerator it, com.google.common.base.Function function) {
        super(it);
        this.val$function = function;
    }

    java.lang.object transform(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return transform(obj);
    }

    java.util.Dictionary$Entry<K, V> transform(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Dictionarys.immutableEntry(k, this.val$function.apply(k));
    }
}

