namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedHashSet<E> : com.google.common.collect.Synchronized$SynchronizedICollection<E> : java.util.HashSet<E> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedHashSet(java.util.HashSet<E> set, @javax.annotation.CheckForNull java.lang.object obj) {
        super(set, obj, null);
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection delegate() {
        return delegate();
    }

    java.util.HashSet<E> delegate() {
        return (java.util.HashSet) super.delegate();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zEquals;
        if (obj == this) {
            return true;
        }
        lock (this.mutex) {
            try {
                zEquals = delegate().Equals(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zEquals;
    }

    public override int HashCode() {
        int iHashCode;
        lock (this.mutex) {
            try {
                iHashCode = delegate().GetHashCode();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iHashCode;
    }
}

