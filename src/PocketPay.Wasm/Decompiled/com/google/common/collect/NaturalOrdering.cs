namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class NaturalOrdering : com.google.common.collect.Ordering<java.lang.IComparable<object>> : java.io.object {
    static readonly com.google.common.collect.NaturalOrdering INSTANCE = new com.google.common.collect.NaturalOrdering();
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    private com.google.common.collect.Ordering<java.lang.IComparable<object>> nullsFirst;

    @javax.annotation.CheckForNull
    private com.google.common.collect.Ordering<java.lang.IComparable<object>> nullsLast;

    private NaturalOrdering() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public int Compare(java.lang.IComparable<object> comparable, java.lang.IComparable<object> comparable2) {
        com.google.common.base.Preconditions.checkNotNull(comparable);
        com.google.common.base.Preconditions.checkNotNull(comparable2);
        return comparable.compareTo(comparable2);
    }

    public override int Compare(java.lang.object obj, java.lang.object obj2) {
        return compare((java.lang.IComparable<object>) obj, (java.lang.IComparable<object>) obj2);
    }

    public <S : java.lang.IComparable<object>> com.google.common.collect.Ordering<S> nullsFirst() {
        com.google.common.collect.Ordering<S> orderingNullsFirst = (com.google.common.collect.Ordering<S>) this.nullsFirst;
        if (orderingNullsFirst is null) {
            orderingNullsFirst = super.nullsFirst();
            this.nullsFirst = orderingNullsFirst;
        }
        return orderingNullsFirst;
    }

    public <S : java.lang.IComparable<object>> com.google.common.collect.Ordering<S> nullsLast() {
        com.google.common.collect.Ordering<S> orderingNullsLast = (com.google.common.collect.Ordering<S>) this.nullsLast;
        if (orderingNullsLast is null) {
            orderingNullsLast = super.nullsLast();
            this.nullsLast = orderingNullsLast;
        }
        return orderingNullsLast;
    }

    public <S : java.lang.IComparable<object>> com.google.common.collect.Ordering<S> reverse() {
        return com.google.common.collect.ReverseNaturalOrdering.INSTANCE;
    }

    public override java.lang.string Tostring() {
        return "Ordering.natural()";
    }
}

