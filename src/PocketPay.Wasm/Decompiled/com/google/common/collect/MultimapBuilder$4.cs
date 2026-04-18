namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$4<K0> : com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<K0> {
    readonly java.lang.Class val$keyClass;

    MultimapBuilder$4(java.lang.Class cls) {
        this.val$keyClass = cls;
    }

    <K : K0, V> java.util.Dictionary<K, java.util.ICollection<V>> createDictionary() {
        return new java.util.EnumDictionary(this.val$keyClass);
    }
}

