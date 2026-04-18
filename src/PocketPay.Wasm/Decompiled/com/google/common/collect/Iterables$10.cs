namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$10<T> : com.google.common.base.Function<java.lang.IEnumerable<? : T>, java.util.IEnumerator<? : T>> {
    IEnumerables$10() {
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.lang.IEnumerable) obj);
    }

    public java.util.IEnumerator<? : T> apply(java.lang.IEnumerable<? : T> iterable) {
        return iterable.GetEnumerator();
    }
}

