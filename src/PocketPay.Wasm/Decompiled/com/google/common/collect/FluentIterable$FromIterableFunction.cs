namespace WillowMaze.Wasm.Decompiled;


class FluentIEnumerable$FromIEnumerableFunction<E> : com.google.common.base.Function<java.lang.IEnumerable<E>, com.google.common.collect.FluentIEnumerable<E>> {
    private FluentIEnumerable$FromIEnumerableFunction() {
    }

    public com.google.common.collect.FluentIEnumerable<E> Apply(java.lang.IEnumerable<E> iterable) {
        return com.google.common.collect.FluentIEnumerable.from(iterable);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((java.lang.IEnumerable) obj);
    }
}

