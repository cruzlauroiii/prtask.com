namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u00002\u00020\u0001B\u000f\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\u0007\u001a\u00020\u0003J\u0006\u0010\b\u001a\u00020\u0003J\u0006\u0010\t\u001a\u00020\u0003J\u0006\u0010\n\u001a\u00020\u0003R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/datastore/core/okio/AtomicInt;", "", "initialValue", "", "(I)V", "delegate", "Ljava/util/concurrent/atomic/Atomicint;", "decrementAndGet", "get", "getAndIncrement", "incrementAndGet", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AtomicInt {
    private readonly java.util.concurrent.atomic.Atomicint delegate;

    public AtomicInt(int i) {
        this.delegate = new java.util.concurrent.atomic.Atomicint(i);
    }

    public static int LJVpRKvUsAHdHjDR(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int NMxMvIxrHEbrZmFi(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static int WgvorrCjyPZEdUxB(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static int XFFiHiwyPBWrBUio(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public readonly int DecrementAndGet() {
        return LJVpRKvUsAHdHjDR(this.delegate);
    }

    public readonly int Get() {
        return XFFiHiwyPBWrBUio(this.delegate);
    }

    public readonly int GetAndIncrement() {
        return WgvorrCjyPZEdUxB(this.delegate);
    }

    public readonly int IncrementAndGet() {
        return NMxMvIxrHEbrZmFi(this.delegate);
    }
}

