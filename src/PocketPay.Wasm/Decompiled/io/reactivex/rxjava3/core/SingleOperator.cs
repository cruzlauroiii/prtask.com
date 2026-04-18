namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface SingleOperator<Downstream, Upstream> {
    io.reactivex.rxjava3.core.SingleObserver<Upstream> apply(io.reactivex.rxjava3.core.SingleObserver<Downstream> singleObserver) throws java.lang.Exception;
}

