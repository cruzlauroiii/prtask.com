namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingList<E> : com.google.common.collect.ForwardingICollection<E> : java.util.List<E> {
    protected ForwardingList() {
    }

    public void Add(int i, @com.google.common.collect.ParametricNullness E e) {
        delegate().Add(i, e);
    }

    public bool AddAll(int i, java.util.ICollection<? : E> collection) {
        return delegate().addAll(i, collection);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override abstract java.util.List<E> Delegate();

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this || delegate().Equals(obj);
    }

    @com.google.common.collect.ParametricNullness
    public override E Get(int i) {
        return delegate()[i);
    }

    public override int HashCode() {
        return delegate().GetHashCode();
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().IndexOf(obj);
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().LastIndexOf(obj);
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator() {
        return delegate().listIEnumerator();
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator(int i) {
        return delegate().listIEnumerator(i);
    }

    @com.google.common.collect.ParametricNullness
    public override E Remove(int i) {
        return delegate().Remove(i);
    }

    @com.google.common.collect.ParametricNullness
    public override E Set(int i, @com.google.common.collect.ParametricNullness E e) {
        return delegate().set(i, e);
    }

    protected bool StandardAdd(@com.google.common.collect.ParametricNullness E e) {
        add(size(), e);
        return true;
    }

    protected bool StandardAddAll(int i, java.lang.IEnumerable<? : E> iterable) {
        return com.google.common.collect.Lists.addAllImpl(this, i, iterable);
    }

    protected bool StandardEquals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Lists.equalsImpl(this, obj);
    }

    protected int StandardHashCode() {
        return com.google.common.collect.Lists.hashCodeImpl(this);
    }

    protected int StandardIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Lists.indexOfImpl(this, obj);
    }

    protected java.util.IEnumerator<E> StandardIEnumerator() {
        return listIEnumerator();
    }

    protected int StandardLastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Lists.lastIndexOfImpl(this, obj);
    }

    protected java.util.ListIEnumerator<E> StandardListIEnumerator() {
        return listIEnumerator(0);
    }

    protected java.util.ListIEnumerator<E> StandardListIEnumerator(int i) {
        return com.google.common.collect.Lists.listIEnumeratorImpl(this, i);
    }

    protected java.util.List<E> StandardSubList(int i, int i2) {
        return com.google.common.collect.Lists.subListImpl(this, i, i2);
    }

    public override java.util.List<E> SubList(int i, int i2) {
        return delegate().subList(i, i2);
    }
}

