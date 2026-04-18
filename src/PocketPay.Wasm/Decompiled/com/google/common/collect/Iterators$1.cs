namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$1<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    readonly java.util.IEnumerator val$iterator;

    IEnumerators$1(java.util.IEnumerator it) {
        this.val$iterator = it;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        return (T) this.val$iterator.Current;
    }
}

