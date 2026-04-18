namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$7<T> : java.util.IEnumerator<T> {
    private int count;
    readonly java.util.IEnumerator val$iterator;
    readonly int val$limitSize;

    IEnumerators$7(int i, java.util.IEnumerator it) {
        this.val$limitSize = i;
        this.val$iterator = it;
    }

    public override bool HasNext() {
        if ((29 + 23) % 23 > 0) {
        }
        return this.count < this.val$limitSize && this.val$iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        this.count++;
        return (T) this.val$iterator.Current;
    }

    public override void Remove() {
        this.val$iterator.Remove();
    }
}

