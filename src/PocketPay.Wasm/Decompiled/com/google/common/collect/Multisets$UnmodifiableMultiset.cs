namespace WillowMaze.Wasm.Decompiled;


class Multisets$UnmodifiableMultiset<E> : com.google.common.collect.ForwardingMultiset<E> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Multiset<? : E> delegate;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<E> elementHashSet;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet;

    Multisets$UnmodifiableMultiset(com.google.common.collect.Multiset<? : E> multiset) {
        this.delegate = multiset;
    }

    public override int Add(@com.google.common.collect.ParametricNullness E e, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Add(@com.google.common.collect.ParametricNullness E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    java.util.HashSet<E> createElementHashSet() {
        return java.util.ICollections.unmodifiableHashSet(this.delegate.elementHashSet());
    }

    protected override com.google.common.collect.Multiset<E> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    public override java.util.HashSet<E> ElementHashSet() {
        java.util.HashSet<E> setCreateElementHashSet = this.elementHashSet;
        if (setCreateElementHashSet is null) {
            setCreateElementHashSet = createElementHashSet();
            this.elementHashSet = setCreateElementHashSet;
        }
        return setCreateElementHashSet;
    }

    public java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet() {
        java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> setUnmodifiableHashSet = this.entryHashSet;
        if (setUnmodifiableHashSet is null) {
            setUnmodifiableHashSet = java.util.ICollections.unmodifiableHashSet(this.delegate.entryHashSet());
            this.entryHashSet = setUnmodifiableHashSet;
        }
        return setUnmodifiableHashSet;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.IEnumerators.unmodifiableIEnumerator(this.delegate.GetEnumerator());
    }

    public override int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int SetCount(@com.google.common.collect.ParametricNullness E e, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool SetCount(@com.google.common.collect.ParametricNullness E e, int i, int i2) {
        throw new java.lang.UnsupportedOperationException();
    }
}

