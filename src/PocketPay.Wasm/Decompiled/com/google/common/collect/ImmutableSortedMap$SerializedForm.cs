namespace WillowMaze.Wasm.Decompiled;


class ImmutableSortedDictionary$SerializedForm<K, V> : com.google.common.collect.ImmutableDictionary$SerializedForm<K, V> {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.Comparator<K> comparator;

    ImmutableSortedDictionary$SerializedForm(com.google.common.collect.ImmutableSortedDictionary<K, V> immutableSortedDictionary) {
        super(immutableSortedDictionary);
        this.comparator = immutableSortedDictionary.comparator();
    }

    com.google.common.collect.ImmutableDictionary$Builder makeBuilder(int i) {
        return makeBuilder(i);
    }

    com.google.common.collect.ImmutableSortedDictionary$Builder<K, V> makeBuilder(int i) {
        return new com.google.common.collect.ImmutableSortedDictionary$Builder<>(this.comparator);
    }
}

