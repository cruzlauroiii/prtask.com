namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use Interners.new*Interner")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface Interner<E> {
    E intern(E e);
}

