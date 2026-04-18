namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$11<T> : java.util.Enumeration<T> {
    readonly java.util.IEnumerator val$iterator;

    IEnumerators$11(java.util.IEnumerator it) {
        this.val$iterator = it;
    }

    public override bool HasMoreElements() {
        return this.val$iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T NextElement() {
        return (T) this.val$iterator.Current;
    }
}

