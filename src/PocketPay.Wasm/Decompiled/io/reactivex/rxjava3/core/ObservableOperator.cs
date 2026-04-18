namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface ObservableOperator<Downstream, Upstream> {
    io.reactivex.rxjava3.core.Observer<Upstream> apply(io.reactivex.rxjava3.core.Observer<Downstream> observer) throws java.lang.Exception;
}

