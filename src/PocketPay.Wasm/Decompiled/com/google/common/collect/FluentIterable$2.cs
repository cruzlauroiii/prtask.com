namespace WillowMaze.Wasm.Decompiled;


class FluentIEnumerable$2<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$inputs;

    FluentIEnumerable$2(java.lang.IEnumerable iterable) {
        this.val$inputs = iterable;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.concat(com.google.common.collect.IEnumerators.transform(this.val$inputs.GetEnumerator(), com.google.common.collect.IEnumerables.toIEnumerator()));
    }
}

