namespace WillowMaze.Wasm.Decompiled;


class Multisets$ImmutableEntry<E> : com.google.common.collect.Multisets$AbstractEntry<E> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly int count;

    @com.google.common.collect.ParametricNullness
    private readonly E element;

    using (@com.google.common.collect.ParametricNullness E e, int i) {
        this.element = e;
        this.count = i;
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "count");
    }

    public override readonly int GetCount() {
        return this.count;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly E GetElement() {
        return this.element;
    }

    @javax.annotation.CheckForNull
    public com.google.common.collect.Multisets$ImmutableEntry<E> nextInBucket() {
        return null;
    }
}

