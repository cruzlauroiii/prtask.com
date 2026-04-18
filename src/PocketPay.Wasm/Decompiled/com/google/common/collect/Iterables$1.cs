namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$1<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$iterable;

    IEnumerables$1(java.lang.IEnumerable iterable) {
        this.val$iterable = iterable;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.cycle(this.val$iterable);
    }

    public override java.lang.string Tostring() {
        return java.lang.string.valueOf(this.val$iterable.tostring()).concat(" (cycled)");
    }
}

