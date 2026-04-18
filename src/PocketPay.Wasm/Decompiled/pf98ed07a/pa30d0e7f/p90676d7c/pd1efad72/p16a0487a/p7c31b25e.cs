namespace WillowMaze.Wasm.Decompiled;


public abstract class p7c31b25e<T> : io.reactivex.rxjava3.operators.QueueSubscription<T>, io.reactivex.rxjava3.operators.QueueDisposable<T> {
    public void Cancel() {
    }

    public readonly void Clear() {
    }

    public void Dispose() {
    }

    public bool IsDisposed() {
        return false;
    }

    public readonly bool IsEmpty() {
        return true;
    }

    public readonly bool Offer(T t) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public readonly bool Offer(T t, T t2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public readonly T Poll() throws java.lang.Exception {
        return null;
    }

    public readonly void Request(long j) {
    }

    public readonly int RequestFusion(int i) {
        return i & 2;
    }
}

