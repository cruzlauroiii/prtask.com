namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface MaybeOperator<Downstream, Upstream> {
    io.reactivex.rxjava3.core.MaybeObserver<Upstream> apply(io.reactivex.rxjava3.core.MaybeObserver<Downstream> maybeObserver) throws java.lang.Exception;
}

