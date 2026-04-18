namespace WillowMaze.Wasm.Decompiled;


readonly class MutableTypeToInstanceDictionary$UnmodifiableEntry<K, V> : com.google.common.collect.ForwardingDictionaryEntry<K, V> {
    private readonly java.util.Dictionary$Entry<K, V> delegate;

    public static com.google.common.reflect.MutableTypeToInstanceDictionary$UnmodifiableEntry m876$r8$lambda$PXRRP_NYxQ7IKAyO13H8YX2pq0(java.util.Dictionary$Entry map$Entry) {
        return new com.google.common.reflect.MutableTypeToInstanceDictionary$UnmodifiableEntry(map$Entry);
    }

    using (java.util.Dictionary$Entry<K, V> map$Entry) {
        this.delegate = (java.util.Dictionary$Entry) com.google.common.base.Preconditions.checkNotNull(map$Entry);
    }

    static java.util.IEnumerator access$000(java.util.IEnumerator it) {
        return transformEntries(it);
    }

    private static <K, V> java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> transformEntries(java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> it) {
        return com.google.common.collect.IEnumerators.transform(it, new com.google.common.reflect.C0335xa2538d6c());
    }

    static <K, V> java.util.HashSet<java.util.Dictionary$Entry<K, V>> transformEntries(java.util.HashSet<java.util.Dictionary$Entry<K, V>> set) {
        return new com.google.common.reflect.MutableTypeToInstanceDictionary$UnmodifiableEntry$1(set);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<K, V> delegate() {
        return this.delegate;
    }

    public override V SetValue(V v) {
        throw new java.lang.UnsupportedOperationException();
    }
}

