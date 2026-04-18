namespace WillowMaze.Wasm.Decompiled;


class ConcurrentHashMultiset$1<E> : com.google.common.collect.ForwardingHashSet<E> {
    readonly java.util.HashSet val$delegate;

    ConcurrentHashMultiset$1(com.google.common.collect.ConcurrentHashMultiset concurrentHashMultiset, java.util.HashSet set) {
        this.val$delegate = set;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && com.google.common.collect.ICollections2.safeContains(this.val$delegate, obj);
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return standardContainsAll(collection);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<E> Delegate() {
        return this.val$delegate;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && com.google.common.collect.ICollections2.safeRemove(this.val$delegate, obj);
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return standardRemoveAll(collection);
    }
}

