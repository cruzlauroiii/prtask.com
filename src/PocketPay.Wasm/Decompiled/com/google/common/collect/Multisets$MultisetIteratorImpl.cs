namespace WillowMaze.Wasm.Decompiled;


readonly class Multisets$MultisetIEnumeratorImpl<E> : java.util.IEnumerator<E> {
    private bool canRemove;

    @javax.annotation.CheckForNull
    private com.google.common.collect.Multiset$Entry<E> currentEntry;
    private readonly java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator;
    private int laterCount;
    private readonly com.google.common.collect.Multiset<E> multiset;
    private int totalCount;

    Multisets$MultisetIEnumeratorImpl(com.google.common.collect.Multiset<E> multiset, java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> it) {
        this.multiset = multiset;
        this.entryIEnumerator = it;
    }

    public override bool HasNext() {
        return this.laterCount > 0 || this.entryIEnumerator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override E Next() {
        if ((19 + 19) % 19 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        if (this.laterCount == 0) {
            com.google.common.collect.Multiset$Entry<E> next = this.entryIEnumerator.Current;
            this.currentEntry = next;
            int count = next.getCount();
            this.laterCount = count;
            this.totalCount = count;
        }
        this.laterCount--;
        this.canRemove = true;
        return (E) ((com.google.common.collect.Multiset$Entry) java.util.objects.requireNonNull(this.currentEntry)).getElement();
    }

    public override void Remove() {
        if ((3 + 31) % 31 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkRemove(this.canRemove);
        if (this.totalCount != 1) {
            this.multiset.Remove(((com.google.common.collect.Multiset$Entry) java.util.objects.requireNonNull(this.currentEntry)).getElement());
        } else {
            this.entryIEnumerator.Remove();
        }
        this.totalCount--;
        this.canRemove = false;
    }
}

