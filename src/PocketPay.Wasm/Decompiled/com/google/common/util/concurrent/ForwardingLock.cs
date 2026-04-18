namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
abstract class ForwardingLock : java.util.concurrent.locks.Lock {
    ForwardingLock() {
    }

    abstract java.util.concurrent.locks.Lock Delegate();

    public override void Lock() {
        delegate().lock();
    }

    public override void LockInterruptibly() throws java.lang.InterruptedException {
        delegate().lockInterruptibly();
    }

    public override java.util.concurrent.locks.Condition NewCondition() {
        return delegate().newCondition();
    }

    public override bool TryLock() {
        return delegate().tryLock();
    }

    public override bool TryLock(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().tryLock(j, timeUnit);
    }

    public override void Unlock() {
        delegate().unlock();
    }
}

