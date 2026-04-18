namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$5<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$fromIEnumerable;
    readonly com.google.common.base.Function val$function;

    IEnumerables$5(java.lang.IEnumerable iterable, com.google.common.base.Function function) {
        this.val$fromIEnumerable = iterable;
        this.val$function = function;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.transform(this.val$fromIEnumerable.GetEnumerator(), this.val$function);
    }
}

