namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface FlowableConverter<T, R> {
    R apply(io.reactivex.rxjava3.core.Flowable<T> flowable);
}

