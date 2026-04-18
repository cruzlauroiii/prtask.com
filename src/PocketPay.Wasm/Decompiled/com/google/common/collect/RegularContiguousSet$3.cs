namespace WillowMaze.Wasm.Decompiled;


class RegularContiguousHashSet$3<C> : com.google.common.collect.ImmutableAsList<C> {
    readonly com.google.common.collect.RegularContiguousHashSet this$0;

    RegularContiguousHashSet$3(com.google.common.collect.RegularContiguousHashSet regularContiguousHashSet) {
        this.this$0 = regularContiguousHashSet;
    }

    com.google.common.collect.ImmutableICollection delegateICollection() {
        return delegateICollection();
    }

    com.google.common.collect.ImmutableSortedHashSet<C> delegateICollection() {
        return this.this$0;
    }

    public override java.lang.IComparable Get(int i) {
        if ((9 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return this.this$0.domain.offset(this.this$0.first(), i);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }
}

