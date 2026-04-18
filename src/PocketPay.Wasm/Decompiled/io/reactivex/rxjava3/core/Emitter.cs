namespace WillowMaze.Wasm.Decompiled;


public interface Emitter<T> {
    void onComplete();

    void onError(java.lang.Exception th);

    void onNext(T t);
}

