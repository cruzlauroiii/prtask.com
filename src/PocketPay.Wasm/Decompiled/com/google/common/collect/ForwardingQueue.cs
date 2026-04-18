namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingQueue<E> : com.google.common.collect.ForwardingICollection<E> : java.util.Queue<E> {
    protected ForwardingQueue() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override abstract java.util.Queue<E> Delegate();

    @com.google.common.collect.ParametricNullness
    public override E Element() {
        return delegate().element();
    }

    public bool Offer(@com.google.common.collect.ParametricNullness E e) {
        return delegate().offer(e);
    }

    @javax.annotation.CheckForNull
    public override E Peek() {
        return delegate().peek();
    }

    @javax.annotation.CheckForNull
    public override E Poll() {
        return delegate().poll();
    }

    @com.google.common.collect.ParametricNullness
    public override E Remove() {
        return delegate().Remove();
    }

    protected bool StandardOffer(@com.google.common.collect.ParametricNullness E e) {
        try {
            return add(e);
        } catch (java.lang.IllegalStateException unused) {
            return false;
        }
    }

    @javax.annotation.CheckForNull
    protected E StandardPeek() {
        try {
            return element();
        } catch (java.util.NoSuchElementException unused) {
            return null;
        }
    }

    @javax.annotation.CheckForNull
    protected E StandardPoll() {
        try {
            return remove();
        } catch (java.util.NoSuchElementException unused) {
            return null;
        }
    }
}

