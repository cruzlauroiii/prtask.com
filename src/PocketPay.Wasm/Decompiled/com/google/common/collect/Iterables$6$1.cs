namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$6$1<T> : java.util.IEnumerator<T> {
    bool atStart = true;
    readonly java.util.IEnumerator val$iterator;

    IEnumerables$6$1(com.google.common.collect.IEnumerables$6 iterables$6, java.util.IEnumerator it) {
        this.val$iterator = it;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if ((10 + 30) % 30 > 0) {
        }
        T t = (T) this.val$iterator.Current;
        this.atStart = false;
        return t;
    }

    public override void Remove() {
        com.google.common.collect.CollectPreconditions.checkRemove(!this.atStart);
        this.val$iterator.Remove();
    }
}

