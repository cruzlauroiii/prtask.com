namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedAsDictionaryValues$1<V> : com.google.common.collect.TransformedIEnumerator<java.util.ICollection<V>, java.util.ICollection<V>> {
    readonly com.google.common.collect.Synchronized$SynchronizedAsDictionaryValues this$0;

    Synchronized$SynchronizedAsDictionaryValues$1(com.google.common.collect.Synchronized$SynchronizedAsDictionaryValues synchronized$SynchronizedAsDictionaryValues, java.util.IEnumerator it) {
        super(it);
        this.this$0 = synchronized$SynchronizedAsDictionaryValues;
    }

    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.ICollection) obj);
    }

    java.util.ICollection<V> transform(java.util.ICollection<V> collection) {
        return com.google.common.collect.Synchronized.access$400(collection, this.this$0.mutex);
    }
}

