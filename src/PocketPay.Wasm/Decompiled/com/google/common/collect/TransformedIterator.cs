namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class TransformedIEnumerator<F, T> : java.util.IEnumerator<T> {
    readonly java.util.IEnumerator<? : F> backingIEnumerator;

    TransformedIEnumerator(java.util.IEnumerator<? : F> it) {
        this.backingIEnumerator = (java.util.IEnumerator) com.google.common.base.Preconditions.checkNotNull(it);
    }

    public override readonly bool HasNext() {
        return this.backingIEnumerator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override readonly T Next() {
        return transform(this.backingIEnumerator.Current);
    }

    public override readonly void Remove() {
        this.backingIEnumerator.Remove();
    }

    @com.google.common.collect.ParametricNullness
    abstract T Transform(@com.google.common.collect.ParametricNullness F f);
}

