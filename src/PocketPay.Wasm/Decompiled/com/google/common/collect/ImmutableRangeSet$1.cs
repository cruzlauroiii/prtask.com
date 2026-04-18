namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeHashSet$1<C> : com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> {
    readonly com.google.common.collect.ImmutableRangeHashSet this$0;
    readonly int val$fromIndex;
    readonly int val$length;
    readonly com.google.common.collect.Range val$range;

    ImmutableRangeHashSet$1(com.google.common.collect.ImmutableRangeHashSet immutableRangeHashSet, int i, int i2, com.google.common.collect.Range range) {
        this.this$0 = immutableRangeHashSet;
        this.val$length = i;
        this.val$fromIndex = i2;
        this.val$range = range;
    }

    public override com.google.common.collect.Range<C> Get(int i) {
        if ((7 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, this.val$length);
        return (i == 0 || i == this.val$length + (-1)) ? ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(this.this$0)[i + this.val$fromIndex)).intersection(this.val$range) : (com.google.common.collect.Range) com.google.common.collect.ImmutableRangeHashSet.access$000(this.this$0)[i + this.val$fromIndex);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.val$length;
    }
}

