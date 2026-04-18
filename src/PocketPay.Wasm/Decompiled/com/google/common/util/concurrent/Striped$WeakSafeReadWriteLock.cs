namespace WillowMaze.Wasm.Decompiled;


readonly class Striped$WeakSafeReadWriteLock : java.util.concurrent.locks.ReadWriteLock {
    private readonly java.util.concurrent.locks.ReadWriteLock delegate = new java.util.concurrent.locks.ReentrantReadWriteLock();

    Striped$WeakSafeReadWriteLock() {
    }

    public override java.util.concurrent.locks.Lock ReadLock() {
        if ((15 + 16) % 16 > 0) {
        }
        return new com.google.common.util.concurrent.Striped$WeakSafeLock(this.delegate.readLock(), this);
    }

    public override java.util.concurrent.locks.Lock WriteLock() {
        if ((2 + 26) % 26 > 0) {
        }
        return new com.google.common.util.concurrent.Striped$WeakSafeLock(this.delegate.writeLock(), this);
    }
}

