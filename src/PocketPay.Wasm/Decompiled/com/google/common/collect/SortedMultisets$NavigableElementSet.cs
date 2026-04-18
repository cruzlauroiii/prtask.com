namespace WillowMaze.Wasm.Decompiled;


class SortedMultisets$NavigableElementHashSet<E> : com.google.common.collect.SortedMultisets$ElementHashSet<E> : java.util.NavigableHashSet<E> {
    SortedMultisets$NavigableElementHashSet(com.google.common.collect.SortedMultiset<E> sortedMultiset) {
        super(sortedMultiset);
    }

    @javax.annotation.CheckForNull
    public override E Ceiling(@com.google.common.collect.ParametricNullness E e) {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().tailMultiset(e, com.google.common.collect.BoundType.CLOSED).firstEntry());
    }

    public override java.util.IEnumerator<E> DescendingIEnumerator() {
        return descendingHashSet().GetEnumerator();
    }

    public override java.util.NavigableHashSet<E> DescendingHashSet() {
        return new com.google.common.collect.SortedMultisets$NavigableElementHashSet(multiset().descendingMultiset());
    }

    @javax.annotation.CheckForNull
    public override E Floor(@com.google.common.collect.ParametricNullness E e) {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().headMultiset(e, com.google.common.collect.BoundType.CLOSED).lastEntry());
    }

    public override java.util.NavigableHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return new com.google.common.collect.SortedMultisets$NavigableElementHashSet(multiset().headMultiset(e, com.google.common.collect.BoundType.forbool(z)));
    }

    @javax.annotation.CheckForNull
    public override E Higher(@com.google.common.collect.ParametricNullness E e) {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().tailMultiset(e, com.google.common.collect.BoundType.OPEN).firstEntry());
    }

    @javax.annotation.CheckForNull
    public override E Lower(@com.google.common.collect.ParametricNullness E e) {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().headMultiset(e, com.google.common.collect.BoundType.OPEN).lastEntry());
    }

    @javax.annotation.CheckForNull
    public override E PollFirst() {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().pollFirstEntry());
    }

    @javax.annotation.CheckForNull
    public override E PollLast() {
        return (E) com.google.common.collect.SortedMultisets.access$100(multiset().pollLastEntry());
    }

    public override java.util.NavigableHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, bool z, @com.google.common.collect.ParametricNullness E e2, bool z2) {
        return new com.google.common.collect.SortedMultisets$NavigableElementHashSet(multiset().subMultiset(e, com.google.common.collect.BoundType.forbool(z), e2, com.google.common.collect.BoundType.forbool(z2)));
    }

    public override java.util.NavigableHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return new com.google.common.collect.SortedMultisets$NavigableElementHashSet(multiset().tailMultiset(e, com.google.common.collect.BoundType.forbool(z)));
    }
}

