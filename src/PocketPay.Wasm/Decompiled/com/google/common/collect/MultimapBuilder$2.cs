namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$2 : com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> {
    readonly int val$expectedKeys;

    MultimapBuilder$2(int i) {
        this.val$expectedKeys = i;
    }

    <K, V> java.util.Dictionary<K, java.util.ICollection<V>> createDictionary() {
        return com.google.common.collect.Platform.newLinkedHashDictionaryWithExpectedSize(this.val$expectedKeys);
    }
}

