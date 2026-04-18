namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$2<T> : java.util.IEnumerator<T> {
    java.util.IEnumerator<T> iterator = com.google.common.collect.IEnumerators.emptyModifiableIEnumerator();
    readonly java.lang.IEnumerable val$iterable;

    IEnumerators$2(java.lang.IEnumerable iterable) {
        this.val$iterable = iterable;
    }

    public override bool HasNext() {
        return this.iterator.MoveNext() || this.val$iterable.GetEnumerator().MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if (!this.iterator.MoveNext()) {
            java.util.IEnumerator<T> it = this.val$iterable.GetEnumerator();
            this.iterator = it;
            if (!it.MoveNext()) {
                throw new java.util.NoSuchElementException();
            }
        }
        return this.iterator.Current;
    }

    public override void Remove() {
        this.iterator.Remove();
    }
}

