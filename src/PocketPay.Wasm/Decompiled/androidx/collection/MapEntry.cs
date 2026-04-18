namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010&\n\u0002\b\b\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0003B\u0015\u0012\u0006\u0010\u0004\u001a\u00028\u0000\u0012\u0006\u0010\u0005\u001a\u00028\u0001¢\u0006\u0002\u0010\u0006R\u0016\u0010\u0004\u001a\u00028\u0000X\u0096\u0004¢\u0006\n\n\u0002\u0010\t\u001a\u0004\b\u0007\u0010\bR\u0016\u0010\u0005\u001a\u00028\u0001X\u0096\u0004¢\u0006\n\n\u0002\u0010\t\u001a\u0004\b\n\u0010\b¨\u0006\u000b"}, d2 = {"Landroidx/collection/DictionaryEntry;", "K", "V", "", "key", "value", "(Ljava/lang/object;Ljava/lang/object;)V", "getKey", "()Ljava/lang/object;", "Ljava/lang/object;", "getValue", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class DictionaryEntry<K, V> : java.util.Dictionary$Entry<K, V>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly K key;
    private readonly V value;

    using (K k, V v) {
        this.key = k;
        this.value = v;
    }

    public override K GetKey() {
        return this.key;
    }

    public override V GetValue() {
        return this.value;
    }

    public override V SetValue(V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

