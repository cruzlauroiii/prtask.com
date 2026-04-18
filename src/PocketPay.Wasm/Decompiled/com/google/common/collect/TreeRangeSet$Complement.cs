namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeHashSet$Complement<C> : com.google.common.collect.TreeRangeHashSet<C> {
    readonly com.google.common.collect.TreeRangeHashSet this$0;

    TreeRangeHashSet$Complement(com.google.common.collect.TreeRangeHashSet treeRangeHashSet) {
        super(new com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound(treeRangeHashSet.rangesByLowerBound), null);
        this.this$0 = treeRangeHashSet;
    }

    public override void Add(com.google.common.collect.Range<C> range) {
        this.this$0.Remove(range);
    }

    public override com.google.common.collect.RangeHashSet<C> Complement() {
        return this.this$0;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return !this.this$0.Contains(comparable);
    }

    public override void Remove(com.google.common.collect.Range<C> range) {
        this.this$0.Add(range);
    }
}

