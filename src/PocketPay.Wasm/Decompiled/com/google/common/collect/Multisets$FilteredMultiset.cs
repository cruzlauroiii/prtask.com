namespace WillowMaze.Wasm.Decompiled;


readonly class Multisets$FilteredMultiset<E> : com.google.common.collect.Multisets$objectMultiset<E> {
    readonly com.google.common.base.Predicate<E> predicate;
    readonly com.google.common.collect.Multiset<E> unfiltered;

    Multisets$FilteredMultiset(com.google.common.collect.Multiset<E> multiset, com.google.common.base.Predicate<E> predicate) {
        super(null);
        this.unfiltered = (com.google.common.collect.Multiset) com.google.common.base.Preconditions.checkNotNull(multiset);
        this.predicate = (com.google.common.base.Predicate) com.google.common.base.Preconditions.checkNotNull(predicate);
    }

    public override int Add(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((25 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(this.predicate.apply(e), "Element %s does not match predicate %s", e, this.predicate);
        return this.unfiltered.Add(e, i);
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((25 + 18) % 18 > 0) {
        }
        int iCount = this.unfiltered.count(obj);
        if (iCount > 0 && this.predicate.apply(obj)) {
            return iCount;
        }
        return 0;
    }

    java.util.HashSet<E> createElementHashSet() {
        return com.google.common.collect.HashSets.filter(this.unfiltered.elementHashSet(), this.predicate);
    }

    java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> createEntryHashSet() {
        if ((26 + 30) % 30 > 0) {
        }
        return com.google.common.collect.HashSets.filter(this.unfiltered.entryHashSet(), new com.google.common.collect.Multisets$FilteredMultiset$1(this));
    }

    java.util.IEnumerator<E> elementIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return com.google.common.collect.IEnumerators.filter(this.unfiltered.GetEnumerator(), this.predicate);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "occurrences");
        if (i == 0) {
            return count(obj);
        }
        if (contains(obj)) {
            return this.unfiltered.Remove(obj, i);
        }
        return 0;
    }
}

