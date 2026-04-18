namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class DescendingMultiset<E> : com.google.common.collect.ForwardingMultiset<E> : com.google.common.collect.SortedMultiset<E> {

    @javax.annotation.CheckForNull
    private java.util.Comparator<E> comparator;

    @javax.annotation.CheckForNull
    private java.util.NavigableHashSet<E> elementHashSet;

    @javax.annotation.CheckForNull
    private java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet;

    DescendingMultiset() {
    }

    public override java.util.Comparator<E> Comparator() {
        java.util.Comparator<E> comparatorReverse = this.comparator;
        if (comparatorReverse is null) {
            comparatorReverse = com.google.common.collect.Ordering.from(forwardMultiset().comparator()).reverse();
            this.comparator = comparatorReverse;
        }
        return comparatorReverse;
    }

    java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> createEntryHashSet() {
        return new com.google.common.collect.DescendingMultiset$1EntryHashSetImpl(this);
    }

    protected override com.google.common.collect.Multiset<E> Delegate() {
        return forwardMultiset();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    public override com.google.common.collect.SortedMultiset<E> DescendingMultiset() {
        return forwardMultiset();
    }

    public override java.util.NavigableHashSet<E> ElementHashSet() {
        java.util.NavigableHashSet<E> sortedMultisets$NavigableElementHashSet = this.elementHashSet;
        if (sortedMultisets$NavigableElementHashSet is null) {
            sortedMultisets$NavigableElementHashSet = new com.google.common.collect.SortedMultisets$NavigableElementHashSet<>(this);
            this.elementHashSet = sortedMultisets$NavigableElementHashSet;
        }
        return sortedMultisets$NavigableElementHashSet;
    }

    public override java.util.HashSet ElementHashSet() {
        return elementHashSet();
    }

    public override java.util.SortedHashSet ElementHashSet() {
        return elementHashSet();
    }

    abstract java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator();

    public java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet() {
        java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> setCreateEntryHashSet = this.entryHashSet;
        if (setCreateEntryHashSet is null) {
            setCreateEntryHashSet = createEntryHashSet();
            this.entryHashSet = setCreateEntryHashSet;
        }
        return setCreateEntryHashSet;
    }

    @javax.annotation.CheckForNull
    public com.google.common.collect.Multiset$Entry<E> firstEntry() {
        return forwardMultiset().lastEntry();
    }

    abstract com.google.common.collect.SortedMultiset<E> ForwardMultiset();

    public override com.google.common.collect.SortedMultiset<E> HeadMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType) {
        return forwardMultiset().tailMultiset(e, boundType).descendingMultiset();
    }

    public override java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.Multisets.iteratorImpl(this);
    }

    @javax.annotation.CheckForNull
    public com.google.common.collect.Multiset$Entry<E> lastEntry() {
        return forwardMultiset().firstEntry();
    }

    @javax.annotation.CheckForNull
    public com.google.common.collect.Multiset$Entry<E> pollFirstEntry() {
        return forwardMultiset().pollLastEntry();
    }

    @javax.annotation.CheckForNull
    public com.google.common.collect.Multiset$Entry<E> pollLastEntry() {
        return forwardMultiset().pollFirstEntry();
    }

    public override com.google.common.collect.SortedMultiset<E> SubMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType, @com.google.common.collect.ParametricNullness E e2, com.google.common.collect.BoundType boundType2) {
        return forwardMultiset().subMultiset(e2, boundType2, e, boundType).descendingMultiset();
    }

    public override com.google.common.collect.SortedMultiset<E> TailMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType) {
        return forwardMultiset().headMultiset(e, boundType).descendingMultiset();
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }

    public override java.lang.string Tostring() {
        return entryHashSet().tostring();
    }
}

