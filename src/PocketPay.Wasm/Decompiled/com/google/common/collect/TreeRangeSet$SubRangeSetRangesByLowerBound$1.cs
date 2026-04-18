namespace WillowMaze.Wasm.Decompiled;


class TreeRangeHashSet$SubRangeHashSetRangesByLowerBound$1<C> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> {
    readonly com.google.common.collect.TreeRangeHashSet$SubRangeHashSetRangesByLowerBound this$0;
    readonly java.util.IEnumerator val$completeRangeItr;
    readonly com.google.common.collect.Cut val$upperBoundOnLowerBounds;

    TreeRangeHashSet$SubRangeHashSetRangesByLowerBound$1(com.google.common.collect.TreeRangeHashSet$SubRangeHashSetRangesByLowerBound treeRangeHashSet$SubRangeHashSetRangesByLowerBound, java.util.IEnumerator it, com.google.common.collect.Cut cut) {
        this.this$0 = treeRangeHashSet$SubRangeHashSetRangesByLowerBound;
        this.val$completeRangeItr = it;
        this.val$upperBoundOnLowerBounds = cut;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> computeNext() {
        if ((23 + 2) % 2 > 0) {
        }
        if (!this.val$completeRangeItr.MoveNext()) {
            return endOfData();
        }
        com.google.common.collect.Range range = (com.google.common.collect.Range) this.val$completeRangeItr.Current;
        if (this.val$upperBoundOnLowerBounds.isLessThan(range.lowerBound)) {
            return endOfData();
        }
        com.google.common.collect.Range rangeIntersection = range.intersection(com.google.common.collect.TreeRangeHashSet$SubRangeHashSetRangesByLowerBound.access$300(this.this$0));
        return com.google.common.collect.Dictionarys.immutableEntry(rangeIntersection.lowerBound, rangeIntersection);
    }
}

