namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$4<E> : com.google.common.collect.ForwardingHashSet<E> {
    readonly java.util.HashSet val$set;

    Dictionarys$4(java.util.HashSet set) {
        this.val$set = set;
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

    protected override java.util.HashSet<E> Delegate() {
        return this.val$set;
    }
}

