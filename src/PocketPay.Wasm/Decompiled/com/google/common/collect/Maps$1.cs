namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$1<K, V> : com.google.common.collect.TransformedIEnumerator<java.util.Dictionary$Entry<K, V>, K> {
    Dictionarys$1(java.util.IEnumerator it) {
        super(it);
    }

    @com.google.common.collect.ParametricNullness
    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }

    @com.google.common.collect.ParametricNullness
    K transform(java.util.Dictionary$Entry<K, V> map$Entry) {
        return map$Entry.getKey();
    }
}

