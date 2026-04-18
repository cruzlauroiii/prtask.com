namespace WillowMaze.Wasm.Decompiled;


class ConcurrentHashMultiset$3<E> : com.google.common.collect.ForwardingIEnumerator<com.google.common.collect.Multiset$Entry<E>> {

    @javax.annotation.CheckForNull
    private com.google.common.collect.Multiset$Entry<E> last;
    readonly com.google.common.collect.ConcurrentHashMultiset this$0;
    readonly java.util.IEnumerator val$readOnlyIEnumerator;

    ConcurrentHashMultiset$3(com.google.common.collect.ConcurrentHashMultiset concurrentHashMultiset, java.util.IEnumerator it) {
        this.this$0 = concurrentHashMultiset;
        this.val$readOnlyIEnumerator = it;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> delegate() {
        return this.val$readOnlyIEnumerator;
    }

    public com.google.common.collect.Multiset$Entry<E> next() {
        com.google.common.collect.Multiset$Entry<E> multiset$Entry = (com.google.common.collect.Multiset$Entry) super.Current;
        this.last = multiset$Entry;
        return multiset$Entry;
    }

    public override java.lang.object Next() {
        return next();
    }

    public override void Remove() {
        if ((7 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.last is not null, "no calls to next() since the last call to remove()");
        this.this$0.setCount(this.last.getElement(), 0);
        this.last = null;
    }
}

