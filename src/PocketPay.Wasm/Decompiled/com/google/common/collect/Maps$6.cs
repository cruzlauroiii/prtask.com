namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$6<E> : com.google.common.collect.ForwardingNavigableHashSet<E> {
    readonly java.util.NavigableHashSet val$set;

    Dictionarys$6(java.util.NavigableHashSet navigableHashSet) {
        this.val$set = navigableHashSet;
    }

    public override bool Add(@com.google.common.collect.ParametricNullness E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.NavigableHashSet<E> Delegate() {
        return this.val$set;
    }

    protected override java.util.HashSet Delegate() {
        return delegate();
    }

    protected override java.util.SortedHashSet Delegate() {
        return delegate();
    }

    public override java.util.NavigableHashSet<E> DescendingHashSet() {
        return com.google.common.collect.Dictionarys.access$400(super.descendingHashSet());
    }

    public override java.util.NavigableHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return com.google.common.collect.Dictionarys.access$400(super.headHashSet(e, z));
    }

    public override java.util.SortedHashSet<E> HeadHashSet(@com.google.common.collect.ParametricNullness E e) {
        return com.google.common.collect.Dictionarys.access$300(super.headHashSet(e));
    }

    public override java.util.NavigableHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, bool z, @com.google.common.collect.ParametricNullness E e2, bool z2) {
        return com.google.common.collect.Dictionarys.access$400(super.subHashSet(e, z, e2, z2));
    }

    public override java.util.SortedHashSet<E> SubHashSet(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2) {
        return com.google.common.collect.Dictionarys.access$300(super.subHashSet(e, e2));
    }

    public override java.util.NavigableHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e, bool z) {
        return com.google.common.collect.Dictionarys.access$400(super.tailHashSet(e, z));
    }

    public override java.util.SortedHashSet<E> TailHashSet(@com.google.common.collect.ParametricNullness E e) {
        return com.google.common.collect.Dictionarys.access$300(super.tailHashSet(e));
    }
}

