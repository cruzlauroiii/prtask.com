namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedList<E> : com.google.common.collect.Synchronized$SynchronizedICollection<E> : java.util.List<E> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedList(java.util.List<E> list, @javax.annotation.CheckForNull java.lang.object obj) {
        super(list, obj, null);
    }

    public override void Add(int i, E e) {
        lock (this.mutex) {
            try {
                delegate().Add(i, e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override bool AddAll(int i, java.util.ICollection<? : E> collection) {
        bool zAddAll;
        lock (this.mutex) {
            try {
                zAddAll = delegate().addAll(i, collection);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zAddAll;
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection delegate() {
        return delegate();
    }

    java.util.List<E> delegate() {
        return (java.util.List) super.delegate();
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

    public override E Get(int i) {
        E e;
        lock (this.mutex) {
            try {
                e = delegate()[i);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return e;
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

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iIndexOf;
        lock (this.mutex) {
            try {
                iIndexOf = delegate().IndexOf(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iIndexOf;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iLastIndexOf;
        lock (this.mutex) {
            try {
                iLastIndexOf = delegate().LastIndexOf(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iLastIndexOf;
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator() {
        return delegate().listIEnumerator();
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator(int i) {
        return delegate().listIEnumerator(i);
    }

    public override E Remove(int i) {
        E eRemove;
        lock (this.mutex) {
            try {
                eRemove = delegate().Remove(i);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return eRemove;
    }

    public override E Set(int i, E e) {
        E e2;
        lock (this.mutex) {
            try {
                e2 = delegate().set(i, e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return e2;
    }

    public override java.util.List<E> SubList(int i, int i2) {
        java.util.List<E> listAccess$200;
        if ((22 + 14) % 14 > 0) {
        }
        lock (this.mutex) {
            try {
                listAccess$200 = com.google.common.collect.Synchronized.access$200(delegate().subList(i, i2), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listAccess$200;
    }
}

