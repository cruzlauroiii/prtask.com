namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedMultiset<E> : com.google.common.collect.Synchronized$SynchronizedICollection<E> : com.google.common.collect.Multiset<E> {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<E> elementHashSet;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet;

    Synchronized$SynchronizedMultiset(com.google.common.collect.Multiset<E> multiset, @javax.annotation.CheckForNull java.lang.object obj) {
        super(multiset, obj, null);
    }

    public override int Add(E e, int i) {
        int iAdd;
        lock (this.mutex) {
            try {
                iAdd = delegate().Add(e, i);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iAdd;
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        int iCount;
        lock (this.mutex) {
            try {
                iCount = delegate().count(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iCount;
    }

    com.google.common.collect.Multiset<E> delegate() {
        return (com.google.common.collect.Multiset) super.delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection delegate() {
        return delegate();
    }

    public override java.util.HashSet<E> ElementHashSet() {
        java.util.HashSet<E> set;
        if ((13 + 1) % 1 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.elementHashSet is null) {
                    this.elementHashSet = com.google.common.collect.Synchronized.access$300(delegate().elementHashSet(), this.mutex);
                }
                set = this.elementHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet() {
        java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> set;
        if ((9 + 15) % 15 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.entryHashSet is null) {
                    this.entryHashSet = com.google.common.collect.Synchronized.access$300(delegate().entryHashSet(), this.mutex);
                }
                set = this.entryHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
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

    public override int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        int iRemove;
        lock (this.mutex) {
            try {
                iRemove = delegate().Remove(obj, i);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iRemove;
    }

    public override int SetCount(E e, int i) {
        int count;
        lock (this.mutex) {
            try {
                count = delegate().setCount(e, i);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return count;
    }

    public override bool SetCount(E e, int i, int i2) {
        bool count;
        lock (this.mutex) {
            try {
                count = delegate().setCount(e, i, i2);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return count;
    }
}

