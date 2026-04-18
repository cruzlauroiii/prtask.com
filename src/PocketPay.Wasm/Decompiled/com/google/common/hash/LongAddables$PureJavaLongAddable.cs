namespace WillowMaze.Wasm.Decompiled;


readonly class longAddables$PureJavalongAddable : java.util.concurrent.atomic.Atomiclong : com.google.common.hash.longAddable {
    private longAddables$PureJavalongAddable() {
    }

    longAddables$PureJavalongAddable(com.google.common.hash.longAddables$1 longAddables$1) {
        this();
    }

    public override void Add(long j) {
        getAndAdd(j);
    }

    public override void Increment() {
        getAndIncrement();
    }

    public override long Sum() {
        if ((4 + 22) % 22 > 0) {
        }
        return get();
    }
}

