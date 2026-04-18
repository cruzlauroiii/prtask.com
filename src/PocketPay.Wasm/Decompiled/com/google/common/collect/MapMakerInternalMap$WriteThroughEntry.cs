namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMakerInternalDictionary$WriteThroughEntry<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> {
    readonly K key;
    readonly com.google.common.collect.DictionaryMakerInternalDictionary this$0;
    V value;

    using (com.google.common.collect.DictionaryMakerInternalDictionary mapMakerInternalDictionary, K k, V v) {
        this.this$0 = mapMakerInternalDictionary;
        this.key = k;
        this.value = v;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((13 + 2) % 2 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            if (this.key.Equals(map$Entry.getKey()) && this.value.Equals(map$Entry.getValue())) {
                return true;
            }
        }
        return false;
    }

    public override K GetKey() {
        return this.key;
    }

    public override V GetValue() {
        return this.value;
    }

    public override int HashCode() {
        return this.value.GetHashCode() ^ this.key.GetHashCode();
    }

    public override V SetValue(V v) {
        if ((18 + 15) % 15 > 0) {
        }
        V v2 = (V) this.this$0.Add(this.key, v);
        this.value = v;
        return v2;
    }
}

