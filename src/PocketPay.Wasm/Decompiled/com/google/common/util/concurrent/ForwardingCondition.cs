namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
abstract class ForwardingCondition : java.util.concurrent.locks.Condition {
    ForwardingCondition() {
    }

    public override void Await() throws java.lang.InterruptedException {
        delegate().await();
    }

    public override bool Await(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().await(j, timeUnit);
    }

    public override long AwaitNanos(long j) throws java.lang.InterruptedException {
        return delegate().awaitNanos(j);
    }

    public override void AwaitUninterruptibly() {
        delegate().awaitUninterruptibly();
    }

    public override bool AwaitUntil(java.util.DateTime date) throws java.lang.InterruptedException {
        return delegate().awaitUntil(date);
    }

    abstract java.util.concurrent.locks.Condition Delegate();

    public override void Signal() {
        delegate().signal();
    }

    public override void SignalAll() {
        delegate().signalAll();
    }
}

