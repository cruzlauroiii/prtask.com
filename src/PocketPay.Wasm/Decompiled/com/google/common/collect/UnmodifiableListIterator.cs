namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class UnmodifiableListIEnumerator<E> : com.google.common.collect.UnmodifiableIEnumerator<E> : java.util.ListIEnumerator<E> {
    protected UnmodifiableListIEnumerator() {
    }

    @java.lang.Deprecated
    public override readonly void Add(@com.google.common.collect.ParametricNullness E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void Set(@com.google.common.collect.ParametricNullness E e) {
        throw new java.lang.UnsupportedOperationException();
    }
}

