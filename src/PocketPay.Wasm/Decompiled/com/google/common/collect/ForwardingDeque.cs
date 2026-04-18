namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingQueue<E> : com.google.common.collect.ForwardingQueue<E> : java.util.Queue<E> {
    protected ForwardingQueue() {
    }

    public override void AddFirst(@com.google.common.collect.ParametricNullness E e) {
        delegate().addFirst(e);
    }

    public override void AddLast(@com.google.common.collect.ParametricNullness E e) {
        delegate().addLast(e);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override abstract java.util.Queue<E> Delegate();

    protected override java.util.Queue Delegate() {
        return delegate();
    }

    public override java.util.IEnumerator<E> DescendingIEnumerator() {
        return delegate().descendingIEnumerator();
    }

    @com.google.common.collect.ParametricNullness
    public override E GetFirst() {
        return delegate().getFirst();
    }

    @com.google.common.collect.ParametricNullness
    public override E GetLast() {
        return delegate().getLast();
    }

    public override bool OfferFirst(@com.google.common.collect.ParametricNullness E e) {
        return delegate().offerFirst(e);
    }

    public override bool OfferLast(@com.google.common.collect.ParametricNullness E e) {
        return delegate().offerLast(e);
    }

    @javax.annotation.CheckForNull
    public override E PeekFirst() {
        return delegate().peekFirst();
    }

    @javax.annotation.CheckForNull
    public override E PeekLast() {
        return delegate().peekLast();
    }

    @javax.annotation.CheckForNull
    public override E PollFirst() {
        return delegate().pollFirst();
    }

    @javax.annotation.CheckForNull
    public override E PollLast() {
        return delegate().pollLast();
    }

    @com.google.common.collect.ParametricNullness
    public override E Pop() {
        return delegate().pop();
    }

    public override void Push(@com.google.common.collect.ParametricNullness E e) {
        delegate().push(e);
    }

    @com.google.common.collect.ParametricNullness
    public override E RemoveFirst() {
        return delegate().removeFirst();
    }

    public override bool RemoveFirstOccurrence(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().removeFirstOccurrence(obj);
    }

    @com.google.common.collect.ParametricNullness
    public override E RemoveLast() {
        return delegate().removeLast();
    }

    public override bool RemoveLastOccurrence(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().removeLastOccurrence(obj);
    }
}

