namespace WillowMaze.Wasm.Decompiled;


class FilteredKeyMultimap$AddRejectingList<K, V> : com.google.common.collect.ForwardingList<V> {

    @com.google.common.collect.ParametricNullness
    readonly K key;

    FilteredKeyMultimap$AddRejectingList(@com.google.common.collect.ParametricNullness K k) {
        this.key = k;
    }

    public override void Add(int i, @com.google.common.collect.ParametricNullness V v) {
        com.google.common.base.Preconditions.checkPositionIndex(i, 0);
        java.lang.string strValueOf = java.lang.string.valueOf(this.key);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("Key does not satisfy predicate: ").append(strValueOf).tostring());
    }

    public override bool Add(@com.google.common.collect.ParametricNullness V v) {
        add(0, v);
        return true;
    }

    public override bool AddAll(int i, java.util.ICollection<? : V> collection) {
        com.google.common.base.Preconditions.checkNotNull(collection);
        com.google.common.base.Preconditions.checkPositionIndex(i, 0);
        java.lang.string strValueOf = java.lang.string.valueOf(this.key);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 32).append("Key does not satisfy predicate: ").append(strValueOf).tostring());
    }

    public override bool AddAll(java.util.ICollection<? : V> collection) {
        addAll(0, collection);
        return true;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.List<V> Delegate() {
        return java.util.ICollections.emptyList();
    }
}

