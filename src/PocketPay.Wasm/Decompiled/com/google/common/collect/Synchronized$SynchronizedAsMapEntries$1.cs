namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedAsDictionaryEntries$1<K, V> : com.google.common.collect.TransformedIEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>, java.util.Dictionary$Entry<K, java.util.ICollection<V>>> {
    readonly com.google.common.collect.Synchronized$SynchronizedAsDictionaryEntries this$0;

    Synchronized$SynchronizedAsDictionaryEntries$1(com.google.common.collect.Synchronized$SynchronizedAsDictionaryEntries synchronized$SynchronizedAsDictionaryEntries, java.util.IEnumerator it) {
        super(it);
        this.this$0 = synchronized$SynchronizedAsDictionaryEntries;
    }

    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }

    java.util.Dictionary$Entry<K, java.util.ICollection<V>> transform(java.util.Dictionary$Entry<K, java.util.ICollection<V>> map$Entry) {
        return new com.google.common.collect.Synchronized$SynchronizedAsDictionaryEntries$1$1(this, map$Entry);
    }
}

