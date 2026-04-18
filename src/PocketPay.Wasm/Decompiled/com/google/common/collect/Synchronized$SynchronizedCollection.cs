namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedICollection<E> : com.google.common.collect.Synchronized$Synchronizedobject : java.util.ICollection<E> {
    private static readonly long serialVersionUID = 0;

    private Synchronized$SynchronizedICollection(java.util.ICollection<E> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        super(collection, obj);
    }

    Synchronized$SynchronizedICollection(java.util.ICollection collection, java.lang.object obj, com.google.common.collect.Synchronized$1 synchronized$1) {
        this(collection, obj);
    }

    public override bool Add(E e) {
        bool zAdd;
        lock (this.mutex) {
            try {
                zAdd = delegate().Add(e);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zAdd;
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        bool zAddAll;
        lock (this.mutex) {
            try {
                zAddAll = delegate().addAll(collection);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zAddAll;
    }

    public override void Clear() {
        lock (this.mutex) {
            try {
                delegate().clear();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zContains;
        lock (this.mutex) {
            try {
                zContains = delegate().Contains(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContains;
    }

    public bool ContainsAll(java.util.ICollection<object> collection) {
        bool zContainsAll;
        lock (this.mutex) {
            try {
                zContainsAll = delegate().containsAll(collection);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsAll;
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.ICollection<E> delegate() {
        return (java.util.ICollection) super.delegate();
    }

    public override bool IsEmpty() {
        bool zIsEmpty;
        lock (this.mutex) {
            try {
                zIsEmpty = delegate().Count == 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zIsEmpty;
    }

    public java.util.IEnumerator<E> Iterator() {
        return delegate().GetEnumerator();
    }

    public bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zRemove;
        lock (this.mutex) {
            try {
                zRemove = delegate().Remove(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRemove;
    }

    public bool RemoveAll(java.util.ICollection<object> collection) {
        bool zRemoveAll;
        lock (this.mutex) {
            try {
                zRemoveAll = delegate().removeAll(collection);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRemoveAll;
    }

    public bool RetainAll(java.util.ICollection<object> collection) {
        bool zRetainAll;
        lock (this.mutex) {
            try {
                zRetainAll = delegate().retainAll(collection);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRetainAll;
    }

    public override int Size() {
        int size;
        lock (this.mutex) {
            try {
                size = delegate().Count;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return size;
    }

    public java.lang.object[] ToArray() {
        java.lang.object[] array;
        lock (this.mutex) {
            try {
                array = delegate().toArray();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return array;
    }

    public <T> T[] ToArray(T[] tArr) {
        T[] tArr2;
        lock (this.mutex) {
            try {
                tArr2 = (T[]) delegate().toArray(tArr);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return tArr2;
    }
}

