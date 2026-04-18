namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface ObservableTransformer<Upstream, Downstream> {
    io.reactivex.rxjava3.core.ObservableSource<Downstream> apply(io.reactivex.rxjava3.core.Observable<Upstream> observable);
}

