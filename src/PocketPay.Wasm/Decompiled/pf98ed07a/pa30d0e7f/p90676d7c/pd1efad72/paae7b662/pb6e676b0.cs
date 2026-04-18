namespace WillowMaze.Wasm.Decompiled;


public interface pb6e676b0<T> {
    void drain();

    void innerComplete(io.reactivex.rxjava3.internal.subscribers.InnerQueuedSubscriber<T> innerQueuedSubscriber);

    void innerError(io.reactivex.rxjava3.internal.subscribers.InnerQueuedSubscriber<T> innerQueuedSubscriber, java.lang.Exception th);

    void innerNext(io.reactivex.rxjava3.internal.subscribers.InnerQueuedSubscriber<T> innerQueuedSubscriber, T t);
}

