namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingListIEnumerator<E> : com.google.common.collect.ForwardingIEnumerator<E> : java.util.ListIEnumerator<E> {
    protected ForwardingListIEnumerator() {
    }

    public override void Add(@com.google.common.collect.ParametricNullness E e) {
        delegate().Add(e);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.IEnumerator Delegate() {
        return delegate();
    }

    protected override abstract java.util.ListIEnumerator<E> Delegate();

    public override bool HasPrevious() {
        return delegate().hasPrevious();
    }

    public override int NextIndex() {
        return delegate().nextIndex();
    }

    @com.google.common.collect.ParametricNullness
    public override E Previous() {
        return delegate().previous();
    }

    public override int PreviousIndex() {
        return delegate().previousIndex();
    }

    public override void Set(@com.google.common.collect.ParametricNullness E e) {
        delegate().set(e);
    }
}

