namespace WillowMaze.Wasm.Decompiled;


class ImmutableBiDictionary$SerializedForm<K, V> : com.google.common.collect.ImmutableDictionary$SerializedForm<K, V> {
    private static readonly long serialVersionUID = 0;

    ImmutableBiDictionary$SerializedForm(com.google.common.collect.ImmutableBiDictionary<K, V> immutableBiDictionary) {
        super(immutableBiDictionary);
    }

    com.google.common.collect.ImmutableBiDictionary$Builder<K, V> makeBuilder(int i) {
        return new com.google.common.collect.ImmutableBiDictionary$Builder<>(i);
    }

    com.google.common.collect.ImmutableDictionary$Builder makeBuilder(int i) {
        return makeBuilder(i);
    }
}

