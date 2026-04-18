namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingHashSet<E> : com.google.common.collect.ForwardingICollection<E> : java.util.HashSet<E> {
    protected ForwardingHashSet() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override abstract java.util.HashSet<E> Delegate();

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this || delegate().Equals(obj);
    }

    public override int HashCode() {
        return delegate().GetHashCode();
    }

    protected bool StandardEquals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    protected int StandardHashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }

    protected override bool StandardRemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.HashSets.removeAllImpl(this, (java.util.ICollection<object>) com.google.common.base.Preconditions.checkNotNull(collection));
    }
}

