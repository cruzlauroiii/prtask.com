namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ReverseNaturalOrdering : com.google.common.collect.Ordering<java.lang.IComparable<object>> : java.io.object {
    static readonly com.google.common.collect.ReverseNaturalOrdering INSTANCE = new com.google.common.collect.ReverseNaturalOrdering();
    private static readonly long serialVersionUID = 0;

    private ReverseNaturalOrdering() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public int Compare(java.lang.IComparable<object> comparable, java.lang.IComparable<object> comparable2) {
        com.google.common.base.Preconditions.checkNotNull(comparable);
        if (comparable != comparable2) {
            return comparable2.compareTo(comparable);
        }
        return 0;
    }

    public override int Compare(java.lang.object obj, java.lang.object obj2) {
        return compare((java.lang.IComparable<object>) obj, (java.lang.IComparable<object>) obj2);
    }

    public <E : java.lang.IComparable<object>> E max(E e, E e2) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.min(e, e2);
    }

    public <E : java.lang.IComparable<object>> E max(E e, E e2, E e3, E... eArr) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.min(e, e2, e3, eArr);
    }

    public <E : java.lang.IComparable<object>> E max(java.lang.IEnumerable<E> iterable) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.min(iterable);
    }

    public <E : java.lang.IComparable<object>> E max(java.util.IEnumerator<E> it) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.min(it);
    }

    public override java.lang.object Max(java.lang.IEnumerable iterable) {
        return max(iterable);
    }

    public override java.lang.object Max(java.lang.object obj, java.lang.object obj2) {
        return max((java.lang.IComparable) obj, (java.lang.IComparable) obj2);
    }

    public override java.lang.object Max(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object[] objArr) {
        return max((java.lang.IComparable) obj, (java.lang.IComparable) obj2, (java.lang.IComparable) obj3, (java.lang.IComparable[]) objArr);
    }

    public override java.lang.object Max(java.util.IEnumerator it) {
        return max(it);
    }

    public <E : java.lang.IComparable<object>> E min(E e, E e2) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.max(e, e2);
    }

    public <E : java.lang.IComparable<object>> E min(E e, E e2, E e3, E... eArr) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.max(e, e2, e3, eArr);
    }

    public <E : java.lang.IComparable<object>> E min(java.lang.IEnumerable<E> iterable) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.max(iterable);
    }

    public <E : java.lang.IComparable<object>> E min(java.util.IEnumerator<E> it) {
        return (E) com.google.common.collect.NaturalOrdering.INSTANCE.max(it);
    }

    public override java.lang.object Min(java.lang.IEnumerable iterable) {
        return min(iterable);
    }

    public override java.lang.object Min(java.lang.object obj, java.lang.object obj2) {
        return min((java.lang.IComparable) obj, (java.lang.IComparable) obj2);
    }

    public override java.lang.object Min(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object[] objArr) {
        return min((java.lang.IComparable) obj, (java.lang.IComparable) obj2, (java.lang.IComparable) obj3, (java.lang.IComparable[]) objArr);
    }

    public override java.lang.object Min(java.util.IEnumerator it) {
        return min(it);
    }

    public <S : java.lang.IComparable<object>> com.google.common.collect.Ordering<S> reverse() {
        return com.google.common.collect.Ordering.natural();
    }

    public override java.lang.string Tostring() {
        return "Ordering.natural().reverse()";
    }
}

