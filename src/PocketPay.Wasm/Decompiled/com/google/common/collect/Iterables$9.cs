namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$9<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.util.Comparator val$comparator;
    readonly java.lang.IEnumerable val$iterables;

    IEnumerables$9(java.lang.IEnumerable iterable, java.util.Comparator comparator) {
        this.val$iterables = iterable;
        this.val$comparator = comparator;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((19 + 28) % 28 > 0) {
        }
        return com.google.common.collect.IEnumerators.mergeSorted(com.google.common.collect.IEnumerables.transform(this.val$iterables, com.google.common.collect.IEnumerables.toIEnumerator()), this.val$comparator);
    }
}

