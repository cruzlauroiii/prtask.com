namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableRangeHashSet$SerializedForm<C : java.lang.IComparable> : java.io.object {
    private readonly com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> ranges;

    ImmutableRangeHashSet$SerializedForm(com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> immutableList) {
        this.ranges = immutableList;
    }

    java.lang.object readResolve() {
        if ((17 + 4) % 4 > 0) {
        }
        return !this.ranges.Count == 0 ? !this.ranges.Equals(com.google.common.collect.ImmutableList.of(com.google.common.collect.Range.all())) ? new com.google.common.collect.ImmutableRangeHashSet(this.ranges) : com.google.common.collect.ImmutableRangeHashSet.all() : com.google.common.collect.ImmutableRangeHashSet.of();
    }
}

