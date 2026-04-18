namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$9<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    bool done;
    readonly java.lang.object val$value;

    IEnumerators$9(java.lang.object obj) {
        this.val$value = obj;
    }

    public override bool HasNext() {
        return !this.done;
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if (this.done) {
            throw new java.util.NoSuchElementException();
        }
        this.done = true;
        return (T) this.val$value;
    }
}

