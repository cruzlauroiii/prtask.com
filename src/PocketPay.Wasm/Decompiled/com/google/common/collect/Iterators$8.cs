namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$8<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    readonly java.util.IEnumerator val$iterator;

    IEnumerators$8(java.util.IEnumerator it) {
        this.val$iterator = it;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        T t = (T) this.val$iterator.Current;
        this.val$iterator.Remove();
        return t;
    }

    public java.lang.string Tostring() {
        return "IEnumerators.consumingIEnumerator(...)";
    }
}

