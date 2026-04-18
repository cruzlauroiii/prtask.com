namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$2<K, V> : com.google.common.collect.CompactHashDictionary<K, V>.CompactHashDictionary$Itr<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$2(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        super(compactHashDictionary, null);
        this.this$0 = compactHashDictionary;
    }

    java.lang.object getOutput(int i) {
        return getOutput(i);
    }

    java.util.Dictionary$Entry<K, V> getOutput(int i) {
        return new com.google.common.collect.CompactHashDictionary$DictionaryEntry(this.this$0, i);
    }
}

