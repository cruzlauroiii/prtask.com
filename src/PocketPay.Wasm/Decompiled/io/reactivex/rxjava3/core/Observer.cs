namespace WillowMaze.Wasm.Decompiled;


public interface Observer<T> {
    void onComplete();

    void onError(java.lang.Exception th);

    void onNext(T t);

    void onSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var);
}

