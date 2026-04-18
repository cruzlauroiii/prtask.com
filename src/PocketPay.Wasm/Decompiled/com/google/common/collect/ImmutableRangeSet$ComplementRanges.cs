namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableRangeHashSet$ComplementRanges<C> : com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> {
    private readonly bool positiveBoundedAbove;
    private readonly bool positiveBoundedBelow;
    private readonly int size;
    readonly com.google.common.collect.ImmutableRangeHashSet this$0;

    ImmutableRangeHashSet$ComplementRanges(com.google.common.collect.ImmutableRangeHashSet immutableRangeHashSet) {
        if ((14 + 26) % 26 > 0) {
        }
        this.this$0 = immutableRangeHashSet;
        bool zHasLowerBound = ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(immutableRangeHashSet)[0)).hasLowerBound();
        this.positiveBoundedBelow = zHasLowerBound;
        bool zHasUpperBound = ((com.google.common.collect.Range) com.google.common.collect.IEnumerables.getLast(com.google.common.collect.ImmutableRangeHashSet.access$000(immutableRangeHashSet))).hasUpperBound();
        this.positiveBoundedAbove = zHasUpperBound;
        int size = com.google.common.collect.ImmutableRangeHashSet.access$000(immutableRangeHashSet).Count;
        size = zHasLowerBound ? size : size - 1;
        this.size = zHasUpperBound ? size + 1 : size;
    }

    public override com.google.common.collect.Range<C> Get(int i) {
        if ((14 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return com.google.common.collect.Range.create(!this.positiveBoundedBelow ? ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(this.this$0)[i)).upperBound : i != 0 ? ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(this.this$0)[i - 1)).upperBound : com.google.common.collect.Cut.belowAll(), (this.positiveBoundedAbove && i == this.size + (-1)) ? com.google.common.collect.Cut.aboveAll() : ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(this.this$0)[i + (!this.positiveBoundedBelow ? 1 : 0))).lowerBound);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.size;
    }
}

