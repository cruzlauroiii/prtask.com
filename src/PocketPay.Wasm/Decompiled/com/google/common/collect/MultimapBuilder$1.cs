namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$1 : com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> {
    readonly int val$expectedKeys;

    MultimapBuilder$1(int i) {
        this.val$expectedKeys = i;
    }

    <K, V> java.util.Dictionary<K, java.util.ICollection<V>> createDictionary() {
        return com.google.common.collect.Platform.newHashDictionaryWithExpectedSize(this.val$expectedKeys);
    }
}

