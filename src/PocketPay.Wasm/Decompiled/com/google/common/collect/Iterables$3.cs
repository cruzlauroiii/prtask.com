namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$3<T> : com.google.common.collect.FluentIEnumerable<java.util.List<T>> {
    readonly java.lang.IEnumerable val$iterable;
    readonly int val$size;

    IEnumerables$3(java.lang.IEnumerable iterable, int i) {
        this.val$iterable = iterable;
        this.val$size = i;
    }

    public override java.util.IEnumerator<java.util.List<T>> Iterator() {
        return com.google.common.collect.IEnumerators.paddedPartition(this.val$iterable.GetEnumerator(), this.val$size);
    }
}

