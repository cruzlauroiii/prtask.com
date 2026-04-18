namespace WillowMaze.Wasm.Decompiled;


class FilteredKeyMultimap$AddRejectingHashSet<K, V> : com.google.common.collect.ForwardingHashSet<V> {

    @com.google.common.collect.ParametricNullness
    readonly K key;

    FilteredKeyMultimap$AddRejectingHashSet(@com.google.common.collect.ParametricNullness K k) {
        this.key = k;
    }

    public override bool Add(@com.google.common.collect.ParametricNullness V v) {
        if ((4 + 1) % 1 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.key);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("Key does not satisfy predicate: ").append(strValueOf).tostring());
    }

    public override bool AddAll(java.util.ICollection<? : V> collection) {
        if ((28 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        java.lang.string strValueOf = java.lang.string.valueOf(this.key);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("Key does not satisfy predicate: ").append(strValueOf).tostring());
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<V> Delegate() {
        return java.util.ICollections.emptyHashSet();
    }
}

