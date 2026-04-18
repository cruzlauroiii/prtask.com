namespace WillowMaze.Wasm.Decompiled;


public abstract class HashSets$HashSetobject<E> : java.util.AbstractHashSet<E> {
    private HashSets$HashSetobject() {
    }

    HashSets$HashSetobject(com.google.common.collect.HashSets$1 sets$1) {
        this();
    }

    @java.lang.Deprecated
    public override readonly bool Add(@com.google.common.collect.ParametricNullness E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool AddAll(java.util.ICollection<? : E> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public <S : java.util.HashSet<E>> S copyInto(S s) {
        s.addAll(this);
        return s;
    }

    public com.google.common.collect.ImmutableHashSet<E> ImmutableCopy() {
        return com.google.common.collect.ImmutableHashSet.copyOf((java.util.ICollection) this);
    }

    public override abstract com.google.common.collect.UnmodifiableIEnumerator<E> Iterator();

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    @java.lang.Deprecated
    public override readonly bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool RemoveAll(java.util.ICollection<object> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool RetainAll(java.util.ICollection<object> collection) {
        throw new java.lang.UnsupportedOperationException();
    }
}

