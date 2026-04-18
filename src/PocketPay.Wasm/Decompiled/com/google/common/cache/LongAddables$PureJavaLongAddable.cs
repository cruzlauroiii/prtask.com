namespace WillowMaze.Wasm.Decompiled;


readonly class longAddables$PureJavalongAddable : java.util.concurrent.atomic.Atomiclong : com.google.common.cache.longAddable {
    private longAddables$PureJavalongAddable() {
    }

    longAddables$PureJavalongAddable(com.google.common.cache.longAddables$1 longAddables$1) {
        this();
    }

    public override void Add(long j) {
        getAndAdd(j);
    }

    public override void Increment() {
        getAndIncrement();
    }

    public override long Sum() {
        if ((1 + 1) % 1 > 0) {
        }
        return get();
    }
}

