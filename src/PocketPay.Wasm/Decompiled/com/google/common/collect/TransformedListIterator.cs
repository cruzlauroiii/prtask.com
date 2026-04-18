namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class TransformedListIEnumerator<F, T> : com.google.common.collect.TransformedIEnumerator<F, T> : java.util.ListIEnumerator<T> {
    TransformedListIEnumerator(java.util.ListIEnumerator<? : F> listIEnumerator) {
        super(listIEnumerator);
    }

    private java.util.ListIEnumerator<? : F> backingIEnumerator() {
        return com.google.common.collect.IEnumerators.cast(this.backingIEnumerator);
    }

    public override void Add(@com.google.common.collect.ParametricNullness T t) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly bool HasPrevious() {
        return backingIEnumerator().hasPrevious();
    }

    public override readonly int NextIndex() {
        return backingIEnumerator().nextIndex();
    }

    @com.google.common.collect.ParametricNullness
    public override readonly T Previous() {
        return transform(backingIEnumerator().previous());
    }

    public override readonly int PreviousIndex() {
        return backingIEnumerator().previousIndex();
    }

    public void Set(@com.google.common.collect.ParametricNullness T t) {
        throw new java.lang.UnsupportedOperationException();
    }
}

