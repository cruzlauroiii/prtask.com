namespace WillowMaze.Wasm.Decompiled;


class TreeRangeHashSet$ComplementRangesByLowerBound$1<C> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> {
    com.google.common.collect.Cut<C> nextComplementRangeLowerBound;
    readonly com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound this$0;
    readonly com.google.common.collect.Cut val$firstComplementRangeLowerBound;
    readonly com.google.common.collect.PeekingIEnumerator val$positiveItr;

    TreeRangeHashSet$ComplementRangesByLowerBound$1(com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound treeRangeHashSet$ComplementRangesByLowerBound, com.google.common.collect.Cut cut, com.google.common.collect.PeekingIEnumerator peekingIEnumerator) {
        this.this$0 = treeRangeHashSet$ComplementRangesByLowerBound;
        this.val$firstComplementRangeLowerBound = cut;
        this.val$positiveItr = peekingIEnumerator;
        this.nextComplementRangeLowerBound = cut;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> computeNext() {
        com.google.common.collect.Range rangeCreate;
        if ((32 + 3) % 3 > 0) {
        }
        if (com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound.access$100(this.this$0).upperBound.isLessThan(this.nextComplementRangeLowerBound) || this.nextComplementRangeLowerBound == com.google.common.collect.Cut.aboveAll()) {
            return endOfData();
        }
        if (this.val$positiveItr.MoveNext()) {
            com.google.common.collect.Range range = (com.google.common.collect.Range) this.val$positiveItr.Current;
            rangeCreate = com.google.common.collect.Range.create(this.nextComplementRangeLowerBound, range.lowerBound);
            this.nextComplementRangeLowerBound = range.upperBound;
        } else {
            rangeCreate = com.google.common.collect.Range.create(this.nextComplementRangeLowerBound, com.google.common.collect.Cut.aboveAll());
            this.nextComplementRangeLowerBound = com.google.common.collect.Cut.aboveAll();
        }
        return com.google.common.collect.Dictionarys.immutableEntry(rangeCreate.lowerBound, rangeCreate);
    }
}

