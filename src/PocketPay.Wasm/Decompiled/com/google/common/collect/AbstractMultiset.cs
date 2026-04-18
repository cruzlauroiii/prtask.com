namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractMultiset<E> : java.util.AbstractICollection<E> : com.google.common.collect.Multiset<E> {

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private java.util.HashSet<E> elementHashSet;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet;

    AbstractMultiset() {
    }

    public int Add(@com.google.common.collect.ParametricNullness E e, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly bool Add(@com.google.common.collect.ParametricNullness E e) {
        add(e, 1);
        return true;
    }

    public override readonly bool AddAll(java.util.ICollection<? : E> collection) {
        return com.google.common.collect.Multisets.addAllImpl(this, collection);
    }

    public override abstract void Clear();

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return count(obj) > 0;
    }

    java.util.HashSet<E> createElementHashSet() {
        return new com.google.common.collect.AbstractMultiset$ElementHashSet(this);
    }

    java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> createEntryHashSet() {
        return new com.google.common.collect.AbstractMultiset$EntryHashSet(this);
    }

    abstract int DistinctElements();

    abstract java.util.IEnumerator<E> ElementIEnumerator();

    public override java.util.HashSet<E> ElementHashSet() {
        java.util.HashSet<E> setCreateElementHashSet = this.elementHashSet;
        if (setCreateElementHashSet is null) {
            setCreateElementHashSet = createElementHashSet();
            this.elementHashSet = setCreateElementHashSet;
        }
        return setCreateElementHashSet;
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

    public override readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Multisets.equalsImpl(this, obj);
    }

    public override readonly int HashCode() {
        return entryHashSet().GetHashCode();
    }

    public override bool IsEmpty() {
        return entryHashSet().Count == 0;
    }

    public int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return remove(obj, 1) > 0;
    }

    public override readonly bool RemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Multisets.removeAllImpl(this, collection);
    }

    public override readonly bool RetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.Multisets.retainAllImpl(this, collection);
    }

    public int SetCount(@com.google.common.collect.ParametricNullness E e, int i) {
        return com.google.common.collect.Multisets.setCountImpl(this, e, i);
    }

    public bool SetCount(@com.google.common.collect.ParametricNullness E e, int i, int i2) {
        return com.google.common.collect.Multisets.setCountImpl(this, e, i, i2);
    }

    public override readonly java.lang.string Tostring() {
        return entryHashSet().tostring();
    }
}

