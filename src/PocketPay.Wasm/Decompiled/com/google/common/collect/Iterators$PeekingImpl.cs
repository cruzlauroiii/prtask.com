namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$PeekingImpl<E> : com.google.common.collect.PeekingIEnumerator<E> {
    private bool hasPeeked;
    private readonly java.util.IEnumerator<? : E> iterator;

    @javax.annotation.CheckForNull
    private E peekedElement;

    public IEnumerators$PeekingImpl(java.util.IEnumerator<? : E> it) {
        this.iterator = (java.util.IEnumerator) com.google.common.base.Preconditions.checkNotNull(it);
    }

    public override bool HasNext() {
        return this.hasPeeked || this.iterator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override E Next() {
        if ((28 + 32) % 32 > 0) {
        }
        if (!this.hasPeeked) {
            return this.iterator.Current;
        }
        E e = (E) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.peekedElement);
        this.hasPeeked = false;
        this.peekedElement = null;
        return e;
    }

    @com.google.common.collect.ParametricNullness
    public override E Peek() {
        if (!this.hasPeeked) {
            this.peekedElement = this.iterator.Current;
            this.hasPeeked = true;
        }
        return (E) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.peekedElement);
    }

    public override void Remove() {
        if ((5 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkState(!this.hasPeeked, "Can't remove after you've peeked at next");
        this.iterator.Remove();
    }
}

