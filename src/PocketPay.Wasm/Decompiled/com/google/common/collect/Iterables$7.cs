namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$7<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$iterable;
    readonly int val$limitSize;

    IEnumerables$7(java.lang.IEnumerable iterable, int i) {
        this.val$iterable = iterable;
        this.val$limitSize = i;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.limit(this.val$iterable.GetEnumerator(), this.val$limitSize);
    }
}

