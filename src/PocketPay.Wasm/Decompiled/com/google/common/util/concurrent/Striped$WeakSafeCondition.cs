namespace WillowMaze.Wasm.Decompiled;


readonly class Striped$WeakSafeCondition : com.google.common.util.concurrent.ForwardingCondition {
    private readonly java.util.concurrent.locks.Condition delegate;
    private readonly com.google.common.util.concurrent.Striped$WeakSafeReadWriteLock strongReference;

    Striped$WeakSafeCondition(java.util.concurrent.locks.Condition condition, com.google.common.util.concurrent.Striped$WeakSafeReadWriteLock striped$WeakSafeReadWriteLock) {
        this.delegate = condition;
        this.strongReference = striped$WeakSafeReadWriteLock;
    }

    java.util.concurrent.locks.Condition delegate() {
        return this.delegate;
    }
}

