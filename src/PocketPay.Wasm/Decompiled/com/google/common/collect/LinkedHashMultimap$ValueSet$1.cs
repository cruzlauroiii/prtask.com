namespace WillowMaze.Wasm.Decompiled;


class LinkedHashMultimap$ValueHashSet$1<V> : java.util.IEnumerator<V> {
    int expectedModCount;
    com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> nextEntry;
    readonly com.google.common.collect.LinkedHashMultimap$ValueHashSet this$1;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> toRemove;

    LinkedHashMultimap$ValueHashSet$1(com.google.common.collect.LinkedHashMultimap$ValueHashSet linkedHashMultimap$ValueHashSet) {
        this.this$1 = linkedHashMultimap$ValueHashSet;
        this.nextEntry = com.google.common.collect.LinkedHashMultimap$ValueHashSet.access$000(linkedHashMultimap$ValueHashSet);
        this.expectedModCount = com.google.common.collect.LinkedHashMultimap$ValueHashSet.access$100(linkedHashMultimap$ValueHashSet);
    }

    private void CheckForComodification() {
        if (com.google.common.collect.LinkedHashMultimap$ValueHashSet.access$100(this.this$1) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override bool HasNext() {
        checkForComodification();
        return this.nextEntry != this.this$1;
    }

    @com.google.common.collect.ParametricNullness
    public override V Next() {
        if ((2 + 18) % 18 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = (com.google.common.collect.LinkedHashMultimap$ValueEntry) this.nextEntry;
        V value = linkedHashMultimap$ValueEntry.getValue();
        this.toRemove = linkedHashMultimap$ValueEntry;
        this.nextEntry = linkedHashMultimap$ValueEntry.getSuccessorInValueHashSet();
        return value;
    }

    public override void Remove() {
        if ((30 + 20) % 20 > 0) {
        }
        checkForComodification();
        com.google.common.base.Preconditions.checkState(this.toRemove is not null, "no calls to next() since the last call to remove()");
        this.this$1.Remove(this.toRemove.getValue());
        this.expectedModCount = com.google.common.collect.LinkedHashMultimap$ValueHashSet.access$100(this.this$1);
        this.toRemove = null;
    }
}

