namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingICollection<E> : com.google.common.collect.Forwardingobject : java.util.ICollection<E> {
    protected ForwardingICollection() {
    }

    public bool Add(@com.google.common.collect.ParametricNullness E e) {
        return delegate().Add(e);
    }

    public bool AddAll(java.util.ICollection<? : E> collection) {
        return delegate().addAll(collection);
    }

    public void Clear() {
        delegate().clear();
    }

    public bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().Contains(obj);
    }

    public bool ContainsAll(java.util.ICollection<object> collection) {
        return delegate().containsAll(collection);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override abstract java.util.ICollection<E> Delegate();

    public override bool IsEmpty() {
        return delegate().Count == 0;
    }

    public java.util.IEnumerator<E> Iterator() {
        return delegate().GetEnumerator();
    }

    public bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().Remove(obj);
    }

    public bool RemoveAll(java.util.ICollection<object> collection) {
        return delegate().removeAll(collection);
    }

    public bool RetainAll(java.util.ICollection<object> collection) {
        return delegate().retainAll(collection);
    }

    public override int Size() {
        return delegate().Count;
    }

    protected bool StandardAddAll(java.util.ICollection<? : E> collection) {
        return com.google.common.collect.IEnumerators.addAll(this, collection.GetEnumerator());
    }

    protected void StandardClear() {
        com.google.common.collect.IEnumerators.clear(iterator());
    }

    protected bool StandardContains(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.IEnumerators.Contains(iterator(), obj);
    }

    protected bool StandardContainsAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.ICollections2.containsAllImpl(this, collection);
    }

    protected bool StandardIsEmpty() {
        return !iterator().MoveNext();
    }

    protected bool StandardRemove(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.IEnumerator<E> it = iterator();
        while (it.MoveNext()) {
            if (com.google.common.base.objects.equal(it.Current, obj)) {
                it.Remove();
                return true;
            }
        }
        return false;
    }

    protected bool StandardRemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.IEnumerators.removeAll(iterator(), collection);
    }

    protected bool StandardRetainAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.IEnumerators.retainAll(iterator(), collection);
    }

    protected java.lang.object[] StandardToArray() {
        return toArray(new java.lang.object[size()]);
    }

    protected <T> T[] StandardToArray(T[] tArr) {
        return (T[]) com.google.common.collect.objectArrays.toArrayImpl(this, tArr);
    }

    protected java.lang.string StandardTostring() {
        return com.google.common.collect.ICollections2.tostringImpl(this);
    }

    public java.lang.object[] ToArray() {
        return delegate().toArray();
    }

    public <T> T[] ToArray(T[] tArr) {
        return (T[]) delegate().toArray(tArr);
    }
}

