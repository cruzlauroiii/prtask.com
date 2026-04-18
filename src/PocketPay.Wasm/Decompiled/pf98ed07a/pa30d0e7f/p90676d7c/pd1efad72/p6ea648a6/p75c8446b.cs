namespace WillowMaze.Wasm.Decompiled;


public interface p75c8446b<T> {
    void drain();

    void innerComplete(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<T> innerQueuedObserver);

    void innerError(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<T> innerQueuedObserver, java.lang.Exception th);

    void innerNext(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<T> innerQueuedObserver, T t);
}

