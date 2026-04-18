namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$4<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly com.google.common.base.Predicate val$retainIfTrue;
    readonly java.lang.IEnumerable val$unfiltered;

    IEnumerables$4(java.lang.IEnumerable iterable, com.google.common.base.Predicate predicate) {
        this.val$unfiltered = iterable;
        this.val$retainIfTrue = predicate;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.filter(this.val$unfiltered.GetEnumerator(), this.val$retainIfTrue);
    }
}

