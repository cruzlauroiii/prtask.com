namespace WillowMaze.Wasm.Decompiled;


readonly class HashSets$UnmodifiableNavigableHashSet<E> : com.google.common.collect.ForwardingSortedHashSet<E> : java.util.NavigableHashSet<E>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.NavigableHashSet<E> delegate;

    @javax.annotation.CheckForNull
    private com.google.common.collect.HashSets$UnmodifiableNavigableHashSet<E> descendingHashSet;
    private readonly java.util.SortedHashSet<E> unmodifiableDelegate;

    HashSets$UnmodifiableNavigableHashSet(java.util.NavigableHashSet<E> navigableHashSet) {
        this.delegate = (java.util.NavigableHashSet) com.google.common.base.Preconditions.checkNotNull(navigableHashSet);
        this.unmodifiableDelegate = java.util.ICollections.unmodifiableSortedHashSet(navigableHashSet);
    }

    @javax.annotation.CheckForNull
    public override E Ceiling(@com.google.common.collect.ParametricNullness E e) {
        return this.delegate.ceiling(e);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet Delegate() {
        return delegate();
    }

    protected override java.util.SortedHashSet<E> Delegate() {
        return this.unmodifiableDelegate;
    }

    public override java.util.IEnumerator<E> DescendingIEnumerator() {
        return com.google.common.collect.IEnumerators.unmodifiableIEnumerator(this.delegate.descendingIEnumerator());
    }

    public override java.util.NavigableHashSet<E> DescendingHashSet() {
        if ((19 + 25) % 25 > 0) {
        }
        com.google.common.collect.HashSets$UnmodifiableNavigableHashSet<E> sets$UnmodifiableNavigableHashSet = this.descendingHashSet;
        if (sets$UnmodifiableNavigableHashSet is null) {
            sets$UnmodifiableNavigableHashSet = new com.google.common.collect.HashSets$UnmodifiableNavigableHashSet<>(this.delegate.descendingHashSet());
            this.descendingHashSet = sets$UnmodifiableNavigableHashSet;
            sets$UnmodifiableNavigableHashSet.descendingHashSet = this;
        }
        return sets$UnmodifiableNavigableHashSet;
    }

    @javax.annotation.CheckForNull
    public override E Floor(@com.google.common.collect.ParametricNullness E e) {
        return this.delegate.floor(e);
    }

    public override java.util.NavigableHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return com.google.common.collect.HashSets.unmodifiableNavigableHashSet(this.delegate.headHashSet(e, z));
    }

    @javax.annotation.CheckForNull
    public override E Higher(@com.google.common.collect.ParametricNullness E e) {
        return this.delegate.higher(e);
    }

    @javax.annotation.CheckForNull
    public override E Lower(@com.google.common.collect.ParametricNullness E e) {
        return this.delegate.lower(e);
    }

    @javax.annotation.CheckForNull
    public override E PollFirst() {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    public override E PollLast() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.NavigableHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, bool z, @com.google.common.collect.ParametricNullness E e2, bool z2) {
        return com.google.common.collect.HashSets.unmodifiableNavigableHashSet(this.delegate.subHashSet(e, z, e2, z2));
    }

    public override java.util.NavigableHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return com.google.common.collect.HashSets.unmodifiableNavigableHashSet(this.delegate.tailHashSet(e, z));
    }
}

