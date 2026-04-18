namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$3<V> : com.google.common.collect.CompactHashDictionary<K, V>.CompactHashDictionary$Itr<V> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$3(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        super(compactHashDictionary, null);
        this.this$0 = compactHashDictionary;
    }

    @com.google.common.collect.ParametricNullness
    V getOutput(int i) {
        return (V) com.google.common.collect.CompactHashDictionary.access$600(this.this$0, i);
    }
}

