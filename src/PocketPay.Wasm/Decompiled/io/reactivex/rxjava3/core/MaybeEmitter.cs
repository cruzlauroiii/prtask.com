namespace WillowMaze.Wasm.Decompiled;


public interface MaybeEmitter<T> {
    bool isDisposed();

    void onComplete();

    void onError(java.lang.Exception th);

    void onSuccess(T t);

    void setCancellable(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p9fba8e73 p9fba8e73Var);

    void setDisposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var);

    bool tryOnError(java.lang.Exception th);
}

