namespace WillowMaze.Wasm.Decompiled;


public interface p86d737d4<T, U> {
    bool accept(org.reactivestreams.Subscriber<U> subscriber, T t);

    bool cancelled();

    bool done();

    bool enter();

    java.lang.Exception error();

    int leave(int i);

    long produced(long j);

    long requested();
}

