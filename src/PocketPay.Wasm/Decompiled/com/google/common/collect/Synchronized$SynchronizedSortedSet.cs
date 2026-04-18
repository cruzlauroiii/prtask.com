namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedSortedHashSet<E> : com.google.common.collect.Synchronized$SynchronizedHashSet<E> : java.util.SortedHashSet<E> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedSortedHashSet(java.util.SortedHashSet<E> sortedHashSet, @javax.annotation.CheckForNull java.lang.object obj) {
        super(sortedHashSet, obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<E> Comparator() {
        java.util.Comparator<E> comparator;
        lock (this.mutex) {
            try {
                comparator = delegate().comparator();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return comparator;
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection delegate() {
        return delegate();
    }

    java.util.HashSet delegate() {
        return delegate();
    }

    java.util.SortedHashSet<E> delegate() {
        return (java.util.SortedHashSet) super.delegate();
    }

    public override E First() {
        E eFirst;
        lock (this.mutex) {
            try {
                eFirst = delegate().first();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eFirst;
    }

    public java.util.SortedHashSet<E> HeadHashSet(E e) {
        java.util.SortedHashSet<E> sortedHashSetAccess$100;
        if ((5 + 10) % 10 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedHashSetAccess$100 = com.google.common.collect.Synchronized.access$100(delegate().headHashSet(e), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedHashSetAccess$100;
    }

    public override E Last() {
        E eLast;
        lock (this.mutex) {
            try {
                eLast = delegate().last();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eLast;
    }

    public java.util.SortedHashSet<E> SubHashSet(E e, E e2) {
        java.util.SortedHashSet<E> sortedHashSetAccess$100;
        if ((8 + 17) % 17 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedHashSetAccess$100 = com.google.common.collect.Synchronized.access$100(delegate().subHashSet(e, e2), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedHashSetAccess$100;
    }

    public java.util.SortedHashSet<E> TailHashSet(E e) {
        java.util.SortedHashSet<E> sortedHashSetAccess$100;
        if ((13 + 16) % 16 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedHashSetAccess$100 = com.google.common.collect.Synchronized.access$100(delegate().tailHashSet(e), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedHashSetAccess$100;
    }
}

