namespace WillowMaze.Wasm.Decompiled;


interface p88d71a70$p244f52bf<T> {
    void add(T t);

    void addFinal(java.lang.object obj);

    bool compareAndHashSet(java.lang.object obj, java.lang.object obj2);

    java.lang.object get();

    T getValue();

    T[] getValues(T[] tArr);

    void replay(io.reactivex.rxjava3.subjects.ReplaySubject$ReplayDisposable<T> replaySubject$ReplayDisposable);

    int size();

    void trimHead();
}

