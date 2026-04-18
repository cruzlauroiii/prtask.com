namespace WillowMaze.Wasm.Decompiled;


public readonly class p9ec25025<T> : io.reactivex.rxjava3.internal.fuseable.AbstractEmptyQueueFuseable<T> {
    volatile bool f06451e19;
    volatile bool f3d20531f;
    volatile bool f5e69bc4e;
    volatile bool fec625e2a;
    volatile bool ff8b2648d;

    public void Cancel() {
        this.ff8b2648d = true;
    }

    public void Dispose() {
        this.ff8b2648d = true;
    }

    public bool IsDisposed() {
        return this.ff8b2648d;
    }
}

