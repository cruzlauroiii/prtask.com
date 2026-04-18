namespace WillowMaze.Wasm.Decompiled;


interface pd65cfad6$pd008f1d8<T> : io.reactivex.rxjava3.operators.SimpleQueue<T> {
    int consumerIndex();

    void drop();

    T peek();

    T poll();

    int producerIndex();
}

