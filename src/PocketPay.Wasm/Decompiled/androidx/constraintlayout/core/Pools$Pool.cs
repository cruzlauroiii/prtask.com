namespace WillowMaze.Wasm.Decompiled;


interface Pools$Pool<T> {
    T acquire();

    bool release(T t);

    void releaseAll(T[] tArr, int i);
}

