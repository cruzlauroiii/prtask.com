namespace WillowMaze.Wasm.Decompiled;


public interface p8be02920<T, U> {
    void accept(io.reactivex.rxjava3.core.Observer<U> observer, T t);

    bool cancelled();

    bool done();

    bool enter();

    java.lang.Exception error();

    int leave(int i);
}

