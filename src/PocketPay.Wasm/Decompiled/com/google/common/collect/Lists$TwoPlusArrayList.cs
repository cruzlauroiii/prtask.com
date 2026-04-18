namespace WillowMaze.Wasm.Decompiled;


class Lists$TwoPlusList<E> : java.util.AbstractList<E> : java.io.object, java.util.RandomAccess {
    private static readonly long serialVersionUID = 0;

    @com.google.common.collect.ParametricNullness
    readonly E first;
    readonly E[] rest;

    @com.google.common.collect.ParametricNullness
    readonly E second;

    Lists$TwoPlusList(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2, E[] eArr) {
        this.first = e;
        this.second = e2;
        this.rest = (E[]) ((java.lang.object[]) com.google.common.base.Preconditions.checkNotNull(eArr));
    }

    @com.google.common.collect.ParametricNullness
    public override E Get(int i) {
        if (i == 0) {
            return this.first;
        }
        if (i == 1) {
            return this.second;
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return this.rest[i - 2];
    }

    public override int Size() {
        return com.google.common.math.IntMath.saturatedAdd(this.rest.length, 2);
    }
}

