namespace WillowMaze.Wasm.Decompiled;


class Lists$OnePlusList<E> : java.util.AbstractList<E> : java.io.object, java.util.RandomAccess {
    private static readonly long serialVersionUID = 0;

    @com.google.common.collect.ParametricNullness
    readonly E first;
    readonly E[] rest;

    Lists$OnePlusList(@com.google.common.collect.ParametricNullness E e, E[] eArr) {
        this.first = e;
        this.rest = (E[]) ((java.lang.object[]) com.google.common.base.Preconditions.checkNotNull(eArr));
    }

    @com.google.common.collect.ParametricNullness
    public override E Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return i != 0 ? this.rest[i - 1] : this.first;
    }

    public override int Size() {
        return com.google.common.math.IntMath.saturatedAdd(this.rest.length, 1);
    }
}

