namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$1<K> : com.google.common.collect.CompactHashDictionary<K, V>.CompactHashDictionary$Itr<K> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$1(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        super(compactHashDictionary, null);
        this.this$0 = compactHashDictionary;
    }

    @com.google.common.collect.ParametricNullness
    K getOutput(int i) {
        return (K) com.google.common.collect.CompactHashDictionary.access$100(this.this$0, i);
    }
}

