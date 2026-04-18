namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeHashSet$AsHashSet$2<C> : com.google.common.collect.AbstractIEnumerator<C> {
    java.util.IEnumerator<C> elemItr = com.google.common.collect.IEnumerators.emptyIEnumerator();
    readonly java.util.IEnumerator<com.google.common.collect.Range<C>> rangeItr;
    readonly com.google.common.collect.ImmutableRangeHashSet$AsHashSet this$1;

    ImmutableRangeHashSet$AsHashSet$2(com.google.common.collect.ImmutableRangeHashSet$AsHashSet immutableRangeHashSet$AsHashSet) {
        this.this$1 = immutableRangeHashSet$AsHashSet;
        this.rangeItr = com.google.common.collect.ImmutableRangeHashSet.access$000(immutableRangeHashSet$AsHashSet.this$0).reverse().GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.IComparable ComputeNext() {
        if ((25 + 23) % 23 > 0) {
        }
        while (!this.elemItr.MoveNext()) {
            if (!this.rangeItr.MoveNext()) {
                return (java.lang.IComparable) endOfData();
            }
            this.elemItr = com.google.common.collect.ContiguousHashSet.create(this.rangeItr.Current, com.google.common.collect.ImmutableRangeHashSet$AsHashSet.access$100(this.this$1)).descendingIEnumerator();
        }
        return (java.lang.IComparable) this.elemItr.Current;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

