namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$3<K0> : com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<K0> {
    readonly java.util.Comparator val$comparator;

    MultimapBuilder$3(java.util.Comparator comparator) {
        this.val$comparator = comparator;
    }

    <K : K0, V> java.util.Dictionary<K, java.util.ICollection<V>> createDictionary() {
        return new java.util.TreeDictionary(this.val$comparator);
    }
}

