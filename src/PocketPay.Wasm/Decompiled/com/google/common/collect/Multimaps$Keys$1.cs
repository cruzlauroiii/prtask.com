namespace WillowMaze.Wasm.Decompiled;


class Multimaps$Keys$1<K, V> : com.google.common.collect.TransformedIEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>, com.google.common.collect.Multiset$Entry<K>> {
    Multimaps$Keys$1(com.google.common.collect.Multimaps$Keys multimaps$Keys, java.util.IEnumerator it) {
        super(it);
    }

    com.google.common.collect.Multiset$Entry<K> transform(java.util.Dictionary$Entry<K, java.util.ICollection<V>> map$Entry) {
        return new com.google.common.collect.Multimaps$Keys$1$1(this, map$Entry);
    }

    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }
}

