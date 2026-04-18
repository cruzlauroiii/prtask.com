namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeHashSet$AsRanges<C> : com.google.common.collect.ForwardingICollection<com.google.common.collect.Range<C>> : java.util.HashSet<com.google.common.collect.Range<C>> {
    readonly java.util.ICollection<com.google.common.collect.Range<C>> delegate;

    TreeRangeHashSet$AsRanges(com.google.common.collect.TreeRangeHashSet treeRangeHashSet, java.util.ICollection<com.google.common.collect.Range<C>> collection) {
        this.delegate = collection;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection<com.google.common.collect.Range<C>> Delegate() {
        return this.delegate;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }
}

