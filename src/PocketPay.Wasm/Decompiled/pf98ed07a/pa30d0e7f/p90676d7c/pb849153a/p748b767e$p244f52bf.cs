namespace WillowMaze.Wasm.Decompiled;


interface p748b767e$p244f52bf<T> {
    void complete();

    void error(java.lang.Exception th);

    java.lang.Exception getError();

    T getValue();

    T[] getValues(T[] tArr);

    bool isDone();

    void next(T t);

    void replay(io.reactivex.rxjava3.processors.ReplayProcessor$ReplaySubscription<T> replayProcessor$ReplaySubscription);

    int size();

    void trimHead();
}

