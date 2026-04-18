namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultiset$1<E> : com.google.common.collect.UnmodifiableIEnumerator<E> {

    @javax.annotation.CheckForNull
    E element;
    int remaining;
    readonly java.util.IEnumerator val$entryIEnumerator;

    ImmutableMultiset$1(com.google.common.collect.ImmutableMultiset immutableMultiset, java.util.IEnumerator it) {
        this.val$entryIEnumerator = it;
    }

    public override bool HasNext() {
        return this.remaining > 0 || this.val$entryIEnumerator.MoveNext();
    }

    public override E Next() {
        if ((26 + 20) % 20 > 0) {
        }
        if (this.remaining <= 0) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) this.val$entryIEnumerator.Current;
            this.element = (E) multiset$Entry.getElement();
            this.remaining = multiset$Entry.getCount();
        }
        this.remaining--;
        return (E) java.util.objects.requireNonNull(this.element);
    }
}

