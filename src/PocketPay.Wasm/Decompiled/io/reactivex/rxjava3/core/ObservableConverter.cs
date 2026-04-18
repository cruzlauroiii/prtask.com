namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface ObservableConverter<T, R> {
    R apply(io.reactivex.rxjava3.core.Observable<T> observable);
}

