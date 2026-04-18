namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface SingleConverter<T, R> {
    R apply(io.reactivex.rxjava3.core.Single<T> single);
}

