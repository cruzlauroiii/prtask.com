namespace WillowMaze.Wasm.Decompiled;


readonly class IEnumerables$UnmodifiableIEnumerable<T> : com.google.common.collect.FluentIEnumerable<T> {
    private readonly java.lang.IEnumerable<? : T> iterable;

    private IEnumerables$UnmodifiableIEnumerable(java.lang.IEnumerable<? : T> iterable) {
        this.iterable = iterable;
    }

    IEnumerables$UnmodifiableIEnumerable(java.lang.IEnumerable iterable, com.google.common.collect.IEnumerables$1 iterables$1) {
        this(iterable);
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.unmodifiableIEnumerator(this.iterable.GetEnumerator());
    }

    public override java.lang.string Tostring() {
        return this.iterable.tostring();
    }
}

