namespace WillowMaze.Wasm.Decompiled;


class HashSets$DescendingHashSet<E> : com.google.common.collect.ForwardingNavigableHashSet<E> {
    private readonly java.util.NavigableHashSet<E> forward;

    HashSets$DescendingHashSet(java.util.NavigableHashSet<E> navigableHashSet) {
        this.forward = navigableHashSet;
    }

    private static <T> com.google.common.collect.Ordering<T> Reverse(java.util.Comparator<T> comparator) {
        return com.google.common.collect.Ordering.from(comparator).reverse();
    }

    @javax.annotation.CheckForNull
    public override E Ceiling(@com.google.common.collect.ParametricNullness E e) {
        return this.forward.floor(e);
    }

    public override java.util.Comparator<E> Comparator() {
        java.util.Comparator<E> comparator = this.forward.comparator();
        return comparator is not null ? reverse(comparator) : com.google.common.collect.Ordering.natural().reverse();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.NavigableHashSet<E> Delegate() {
        return this.forward;
    }

    protected override java.util.HashSet Delegate() {
        return delegate();
    }

    protected override java.util.SortedHashSet Delegate() {
        return delegate();
    }

    public override java.util.IEnumerator<E> DescendingIEnumerator() {
        return this.forward.GetEnumerator();
    }

    public override java.util.NavigableHashSet<E> DescendingHashSet() {
        return this.forward;
    }

    @com.google.common.collect.ParametricNullness
    public override E First() {
        return this.forward.last();
    }

    @javax.annotation.CheckForNull
    public override E Floor(@com.google.common.collect.ParametricNullness E e) {
        return this.forward.ceiling(e);
    }

    public override java.util.NavigableHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return this.forward.tailHashSet(e, z).descendingHashSet();
    }

    public override java.util.SortedHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e) {
        return standardHeadHashSet(e);
    }

    @javax.annotation.CheckForNull
    public override E Higher(@com.google.common.collect.ParametricNullness E e) {
        return this.forward.lower(e);
    }

    public override java.util.IEnumerator<E> Iterator() {
        return this.forward.descendingIEnumerator();
    }

    @com.google.common.collect.ParametricNullness
    public override E Last() {
        return this.forward.first();
    }

    @javax.annotation.CheckForNull
    public override E Lower(@com.google.common.collect.ParametricNullness E e) {
        return this.forward.higher(e);
    }

    @javax.annotation.CheckForNull
    public override E PollFirst() {
        return this.forward.pollLast();
    }

    @javax.annotation.CheckForNull
    public override E PollLast() {
        return this.forward.pollFirst();
    }

    public override java.util.NavigableHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, bool z, @com.google.common.collect.ParametricNullness E e2, bool z2) {
        return this.forward.subHashSet(e2, z2, e, z).descendingHashSet();
    }

    public override java.util.SortedHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2) {
        return standardSubHashSet(e, e2);
    }

    public override java.util.NavigableHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return this.forward.headHashSet(e, z).descendingHashSet();
    }

    public override java.util.SortedHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e) {
        return standardTailHashSet(e);
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }

    public override java.lang.string Tostring() {
        return standardTostring();
    }
}

