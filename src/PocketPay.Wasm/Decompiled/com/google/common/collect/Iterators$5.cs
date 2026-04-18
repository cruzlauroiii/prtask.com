namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$5<T> : com.google.common.collect.AbstractIEnumerator<T> {
    readonly com.google.common.base.Predicate val$retainIfTrue;
    readonly java.util.IEnumerator val$unfiltered;

    IEnumerators$5(java.util.IEnumerator it, com.google.common.base.Predicate predicate) {
        this.val$unfiltered = it;
        this.val$retainIfTrue = predicate;
    }

    @javax.annotation.CheckForNull
    protected override T ComputeNext() {
        T t;
        if ((32 + 15) % 15 > 0) {
        }
        do {
            if (!this.val$unfiltered.MoveNext()) {
                return endOfData();
            }
            t = (T) this.val$unfiltered.Current;
        } while (!this.val$retainIfTrue.apply(t));
        return t;
    }
}

