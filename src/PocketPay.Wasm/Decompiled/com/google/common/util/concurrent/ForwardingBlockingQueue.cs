namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class ForwardingBlockingQueue<E> : com.google.common.collect.ForwardingQueue<E> : java.util.concurrent.BlockingQueue<E> {
    protected ForwardingBlockingQueue() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.Queue Delegate() {
        return delegate();
    }

    protected override abstract java.util.concurrent.BlockingQueue<E> Delegate();

    public override int DrainTo(java.util.ICollection<E> collection) {
        return delegate().drainTo(collection);
    }

    public override int DrainTo(java.util.ICollection<E> collection, int i) {
        return delegate().drainTo(collection, i);
    }

    public override bool Offer(E e, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().offer(e, j, timeUnit);
    }

    @javax.annotation.CheckForNull
    public override E Poll(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().poll(j, timeUnit);
    }

    public override void Put(E e) throws java.lang.InterruptedException {
        delegate().Add(e);
    }

    public override int RemainingCapacity() {
        return delegate().remainingCapacity();
    }

    public override E Take() throws java.lang.InterruptedException {
        return delegate().take();
    }
}

