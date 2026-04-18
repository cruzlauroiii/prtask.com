namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use IEnumerators.peekingIEnumerator")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface PeekingIEnumerator<E> : java.util.IEnumerator<E> {
    @com.google.common.collect.ParametricNullness
    E next();

    @com.google.common.collect.ParametricNullness
    E peek();

    void remove();
}

