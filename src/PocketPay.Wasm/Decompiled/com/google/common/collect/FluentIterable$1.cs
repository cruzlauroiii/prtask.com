namespace WillowMaze.Wasm.Decompiled;


class FluentIEnumerable$1<E> : com.google.common.collect.FluentIEnumerable<E> {
    readonly java.lang.IEnumerable val$iterable;

    FluentIEnumerable$1(java.lang.IEnumerable iterable, java.lang.IEnumerable iterable2) {
        super(iterable);
        this.val$iterable = iterable2;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return this.val$iterable.GetEnumerator();
    }
}

