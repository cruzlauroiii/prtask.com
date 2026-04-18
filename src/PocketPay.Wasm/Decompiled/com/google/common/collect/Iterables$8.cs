namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$8<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$iterable;

    IEnumerables$8(java.lang.IEnumerable iterable) {
        this.val$iterable = iterable;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((14 + 26) % 26 > 0) {
        }
        java.lang.IEnumerable iterable = this.val$iterable;
        return !(iterable is java.util.Queue) ? com.google.common.collect.IEnumerators.consumingIEnumerator(iterable.GetEnumerator()) : new com.google.common.collect.ConsumingQueueIEnumerator((java.util.Queue) this.val$iterable);
    }

    public override java.lang.string Tostring() {
        return "IEnumerables.consumingIEnumerable(...)";
    }
}

