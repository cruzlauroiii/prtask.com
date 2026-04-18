namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface MaybeConverter<T, R> {
    R apply(io.reactivex.rxjava3.core.Maybe<T> maybe);
}

