namespace WillowMaze.Wasm.Decompiled;


class RegularContiguousHashSet$1<C> : com.google.common.collect.AbstractSequentialIEnumerator<C> {

    readonly java.lang.IComparable last;
    readonly com.google.common.collect.RegularContiguousHashSet this$0;

    RegularContiguousHashSet$1(com.google.common.collect.RegularContiguousHashSet regularContiguousHashSet, java.lang.IComparable comparable) {
        super(comparable);
        this.this$0 = regularContiguousHashSet;
        this.last = regularContiguousHashSet.last();
    }

    @javax.annotation.CheckForNull
    protected java.lang.IComparable ComputeNext(java.lang.IComparable comparable) {
        if (com.google.common.collect.RegularContiguousHashSet.access$000(comparable, this.last)) {
            return null;
        }
        return this.this$0.domain.next(comparable);
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext(java.lang.object obj) {
        return computeNext((java.lang.IComparable) obj);
    }
}

