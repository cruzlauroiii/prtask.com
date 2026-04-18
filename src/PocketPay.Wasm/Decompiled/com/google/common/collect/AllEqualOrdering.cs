namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class AllEqualOrdering : com.google.common.collect.Ordering<java.lang.object> : java.io.object {
    static readonly com.google.common.collect.AllEqualOrdering INSTANCE = new com.google.common.collect.AllEqualOrdering();
    private static readonly long serialVersionUID = 0;

    AllEqualOrdering() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override int Compare(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return 0;
    }

    public override <E> com.google.common.collect.ImmutableList<E> ImmutableSortedCopy(java.lang.IEnumerable<E> iterable) {
        return com.google.common.collect.ImmutableList.copyOf(iterable);
    }

    public override <S> com.google.common.collect.Ordering<S> Reverse() {
        return this;
    }

    public override <E> java.util.List<E> SortedCopy(java.lang.IEnumerable<E> iterable) {
        return com.google.common.collect.Lists.newList(iterable);
    }

    public java.lang.string Tostring() {
        return "Ordering.allEqual()";
    }
}

