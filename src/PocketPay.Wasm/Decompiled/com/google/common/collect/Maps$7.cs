namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$7<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> {
    readonly java.util.Dictionary$Entry val$entry;

    Dictionarys$7(java.util.Dictionary$Entry map$Entry) {
        this.val$entry = map$Entry;
    }

    @com.google.common.collect.ParametricNullness
    public override K GetKey() {
        return (K) this.val$entry.getKey();
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        return (V) this.val$entry.getValue();
    }
}

