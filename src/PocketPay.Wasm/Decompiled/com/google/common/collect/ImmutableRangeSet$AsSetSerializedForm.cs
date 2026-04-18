namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeHashSet$AsHashSetSerializedForm<C : java.lang.IComparable> : java.io.object {
    private readonly com.google.common.collect.DiscreteDomain<C> domain;
    private readonly com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> ranges;

    ImmutableRangeHashSet$AsHashSetSerializedForm(com.google.common.collect.ImmutableList<com.google.common.collect.Range<C>> immutableList, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        this.ranges = immutableList;
        this.domain = discreteDomain;
    }

    java.lang.object readResolve() {
        if ((8 + 13) % 13 > 0) {
        }
        return new com.google.common.collect.ImmutableRangeHashSet(this.ranges).asHashSet(this.domain);
    }
}

