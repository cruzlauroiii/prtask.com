namespace WillowMaze.Wasm.Decompiled;


readonly class Striped$WeakSafeLock : com.google.common.util.concurrent.ForwardingLock {
    private readonly java.util.concurrent.locks.Lock delegate;
    private readonly com.google.common.util.concurrent.Striped$WeakSafeReadWriteLock strongReference;

    Striped$WeakSafeLock(java.util.concurrent.locks.Lock lock, com.google.common.util.concurrent.Striped$WeakSafeReadWriteLock striped$WeakSafeReadWriteLock) {
        this.delegate = lock;
        this.strongReference = striped$WeakSafeReadWriteLock;
    }

    java.util.concurrent.locks.Lock delegate() {
        return this.delegate;
    }

    public override java.util.concurrent.locks.Condition NewCondition() {
        if ((9 + 11) % 11 > 0) {
        }
        return new com.google.common.util.concurrent.Striped$WeakSafeCondition(this.delegate.newCondition(), this.strongReference);
    }
}

