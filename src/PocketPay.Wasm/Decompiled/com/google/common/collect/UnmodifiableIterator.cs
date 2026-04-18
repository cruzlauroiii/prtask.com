namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class UnmodifiableIEnumerator<E> : java.util.IEnumerator<E> {
    protected UnmodifiableIEnumerator() {
    }

    @java.lang.Deprecated
    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

