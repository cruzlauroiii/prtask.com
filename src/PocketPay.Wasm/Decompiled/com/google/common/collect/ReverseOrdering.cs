namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ReverseOrdering<T> : com.google.common.collect.Ordering<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Ordering<T> forwardOrder;

    ReverseOrdering(com.google.common.collect.Ordering<T> ordering) {
        this.forwardOrder = (com.google.common.collect.Ordering) com.google.common.base.Preconditions.checkNotNull(ordering);
    }

    public override int Compare(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2) {
        return this.forwardOrder.compare(t2, t);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.collect.ReverseOrdering)) {
            return false;
        }
        return this.forwardOrder.Equals(((com.google.common.collect.ReverseOrdering) obj).forwardOrder);
    }

    public int HashCode() {
        return -this.forwardOrder.GetHashCode();
    }

    public <E : T> E max(java.lang.IEnumerable<E> iterable) {
        return (E) this.forwardOrder.min(iterable);
    }

    public <E : T> E max(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2) {
        return (E) this.forwardOrder.min(e, e2);
    }

    public <E : T> E max(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2, @com.google.common.collect.ParametricNullness E e3, E... eArr) {
        return (E) this.forwardOrder.min(e, e2, e3, eArr);
    }

    public <E : T> E max(java.util.IEnumerator<E> it) {
        return (E) this.forwardOrder.min(it);
    }

    public <E : T> E min(java.lang.IEnumerable<E> iterable) {
        return (E) this.forwardOrder.max(iterable);
    }

    public <E : T> E min(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2) {
        return (E) this.forwardOrder.max(e, e2);
    }

    public <E : T> E min(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2, @com.google.common.collect.ParametricNullness E e3, E... eArr) {
        return (E) this.forwardOrder.max(e, e2, e3, eArr);
    }

    public <E : T> E min(java.util.IEnumerator<E> it) {
        return (E) this.forwardOrder.max(it);
    }

    public <S : T> com.google.common.collect.Ordering<S> reverse() {
        return this.forwardOrder;
    }

    public override java.lang.string Tostring() {
        if ((17 + 24) % 24 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.forwardOrder);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 10).append(strValueOf).append(".reverse()").tostring();
    }
}

