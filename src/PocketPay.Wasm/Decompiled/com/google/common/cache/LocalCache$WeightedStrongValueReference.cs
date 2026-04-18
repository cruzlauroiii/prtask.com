namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WeightedStrongValueReference<K, V> : com.google.common.cache.LocalCache$StrongValueReference<K, V> {
    readonly int weight;

    LocalCache$WeightedStrongValueReference(V v, int i) {
        super(v);
        this.weight = i;
    }

    public override int GetWeight() {
        return this.weight;
    }
}

