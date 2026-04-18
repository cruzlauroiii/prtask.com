namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class DescendingImmutableSortedHashSet<E> : com.google.common.collect.ImmutableSortedHashSet<E> {
    private readonly com.google.common.collect.ImmutableSortedHashSet<E> forward;

    DescendingImmutableSortedHashSet(com.google.common.collect.ImmutableSortedHashSet<E> immutableSortedHashSet) {
        super(com.google.common.collect.Ordering.from(immutableSortedHashSet.comparator()).reverse());
        this.forward = immutableSortedHashSet;
    }

    @javax.annotation.CheckForNull
    public override E Ceiling(E e) {
        return this.forward.floor(e);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.forward.Contains(obj);
    }

    com.google.common.collect.ImmutableSortedHashSet<E> createDescendingHashSet() {
        throw new java.lang.AssertionError("should never be called");
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> DescendingIEnumerator() {
        return this.forward.GetEnumerator();
    }

    public override java.util.IEnumerator DescendingIEnumerator() {
        return descendingIEnumerator();
    }

    public override com.google.common.collect.ImmutableSortedHashSet<E> DescendingHashSet() {
        return this.forward;
    }

    public override java.util.NavigableHashSet DescendingHashSet() {
        return descendingHashSet();
    }

    @javax.annotation.CheckForNull
    public override E Floor(E e) {
        return this.forward.ceiling(e);
    }

    com.google.common.collect.ImmutableSortedHashSet<E> headHashSetImpl(E e, bool z) {
        return this.forward.tailHashSet((java.lang.object) e, z).descendingHashSet();
    }

    @javax.annotation.CheckForNull
    public override E Higher(E e) {
        return this.forward.lower(e);
    }

    int indexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iIndexOf = this.forward.IndexOf(obj);
        return iIndexOf != -1 ? (size() - 1) - iIndexOf : iIndexOf;
    }

    bool isPartialobject() {
        return this.forward.isPartialobject();
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return this.forward.descendingIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    @javax.annotation.CheckForNull
    public override E Lower(E e) {
        return this.forward.higher(e);
    }

    public override int Size() {
        return this.forward.Count;
    }

    com.google.common.collect.ImmutableSortedHashSet<E> subHashSetImpl(E e, bool z, E e2, bool z2) {
        return this.forward.subHashSet((java.lang.object) e2, z2, (java.lang.object) e, z).descendingHashSet();
    }

    com.google.common.collect.ImmutableSortedHashSet<E> tailHashSetImpl(E e, bool z) {
        return this.forward.headHashSet((java.lang.object) e, z).descendingHashSet();
    }
}

