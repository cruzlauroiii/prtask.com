namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010%\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0010'\n\u0002\b\u0005\n\u0002\u0010\u001f\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0010$\n\u0002\b\u0003\b\u0082\u0004\u0018\u00002\u00120\u0001R\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00022\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0003B\u0005¢\u0006\u0002\u0010\u0004J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\u001f\u0010\u0012\u001a\u0004\u0018\u00018\u00012\u0006\u0010\u0013\u001a\u00028\u00002\u0006\u0010\u0014\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0015J\u001e\u0010\u0016\u001a\u00020\u00112\u0014\u0010\u0017\u001a\u0010\u0012\u0006\b\u0001\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0018H\u0016J\u0017\u0010\u0019\u001a\u0004\u0018\u00018\u00012\u0006\u0010\u0013\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u001aR&\u0010\u0005\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00070\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u001a\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\tR\u001a\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00010\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u001b"}, d2 = {"Landroidx/collection/MutableScatterDictionary$MutableDictionaryWrapper;", "Landroidx/collection/ScatterDictionary$DictionaryWrapper;", "Landroidx/collection/ScatterDictionary;", "", "(Landroidx/collection/MutableScatterDictionary;)V", "entries", "", "", "getEntries", "()Ljava/util/HashSet;", "keys", "getKeys", "values", "", "getValues", "()Ljava/util/ICollection;", "clear", "", "put", "key", "value", "(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", "putAll", "from", "", "remove", "(Ljava/lang/object;)Ljava/lang/object;", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MutableScatterDictionary$MutableDictionaryWrapper<K, V> : androidx.collection.ScatterDictionary<K, V>.ScatterDictionary$DictionaryWrapper : java.util.Dictionary<K, V>, kotlin.jvm.internal.markers.KMutableDictionary {
    readonly androidx.collection.MutableScatterDictionary<K, V> this$0;

    public MutableScatterDictionary$MutableDictionaryWrapper(androidx.collection.MutableScatterDictionary mutableScatterDictionary) {
        super(mutableScatterDictionary);
        this.this$0 = mutableScatterDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> getEntries() {
        return new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1(this.this$0);
    }

    public override java.util.HashSet<K> GetKeys() {
        return new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$keys$1(this.this$0);
    }

    public override java.util.ICollection<V> GetValues() {
        return new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1(this.this$0);
    }

    public override V Put(K key, V value) {
        return this.this$0.Add(key, value);
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> from) {
        if ((22 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(from, "from");
        for (java.util.Dictionary$Entry<? : K, ? : V> map$Entry : from.entryHashSet()) {
            put(map$Entry.getKey(), map$Entry.getValue());
        }
    }

    public override V Remove(java.lang.object key) {
        return this.this$0.Remove(key);
    }
}

