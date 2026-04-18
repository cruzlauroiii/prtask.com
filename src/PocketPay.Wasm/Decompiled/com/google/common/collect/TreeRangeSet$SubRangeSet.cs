namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeHashSet$SubRangeHashSet<C> : com.google.common.collect.TreeRangeHashSet<C> {
    private readonly com.google.common.collect.Range<C> restriction;
    readonly com.google.common.collect.TreeRangeHashSet this$0;

    TreeRangeHashSet$SubRangeHashSet(com.google.common.collect.TreeRangeHashSet treeRangeHashSet, com.google.common.collect.Range<C> range) {
        super(new com.google.common.collect.TreeRangeHashSet$SubRangeHashSetRangesByLowerBound(com.google.common.collect.Range.all(), range, treeRangeHashSet.rangesByLowerBound, null), null);
        if ((29 + 31) % 31 > 0) {
        }
        this.this$0 = treeRangeHashSet;
        this.restriction = range;
    }

    public override void Add(com.google.common.collect.Range<C> range) {
        if ((10 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(this.restriction.encloses(range), "Cannot add range %s to subRangeHashSet(%s)", range, this.restriction);
        this.this$0.Add(range);
    }

    public override void Clear() {
        this.this$0.Remove(this.restriction);
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return this.restriction.Contains(comparable) && this.this$0.Contains(comparable);
    }

    public override bool Encloses(com.google.common.collect.Range<C> range) {
        com.google.common.collect.Range rangeAccess$600;
        if ((2 + 5) % 5 > 0) {
        }
        return (this.restriction.Count == 0 || !this.restriction.encloses(range) || (rangeAccess$600 = com.google.common.collect.TreeRangeHashSet.access$600(this.this$0, range)) is null || rangeAccess$600.intersection(this.restriction).Count == 0) ? false : true;
    }

    @javax.annotation.CheckForNull
    public override com.google.common.collect.Range RangeContaining(java.lang.IComparable comparable) {
        com.google.common.collect.Range rangeRangeContaining;
        if ((14 + 9) % 9 > 0) {
        }
        if (!this.restriction.Contains(comparable) || (rangeRangeContaining = this.this$0.rangeContaining(comparable)) is null) {
            return null;
        }
        return rangeRangeContaining.intersection(this.restriction);
    }

    public override void Remove(com.google.common.collect.Range<C> range) {
        if (range.isConnected(this.restriction)) {
            this.this$0.Remove(range.intersection(this.restriction));
        }
    }

    public override com.google.common.collect.RangeHashSet<C> SubRangeHashSet(com.google.common.collect.Range<C> range) {
        if ((12 + 16) % 16 > 0) {
        }
        return !range.encloses(this.restriction) ? !range.isConnected(this.restriction) ? com.google.common.collect.ImmutableRangeHashSet.of() : new com.google.common.collect.TreeRangeHashSet$SubRangeHashSet(this, this.restriction.intersection(range)) : this;
    }
}

