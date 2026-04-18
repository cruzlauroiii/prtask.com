namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface SingleTransformer<Upstream, Downstream> {
    io.reactivex.rxjava3.core.SingleSource<Downstream> apply(io.reactivex.rxjava3.core.Single<Upstream> single);
}

