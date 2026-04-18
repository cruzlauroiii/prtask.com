namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedListMultimap<K, V> : com.google.common.collect.Synchronized$SynchronizedMultimap<K, V> : com.google.common.collect.ListMultimap<K, V> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedListMultimap(com.google.common.collect.ListMultimap<K, V> listMultimap, @javax.annotation.CheckForNull java.lang.object obj) {
        super(listMultimap, obj);
    }

    com.google.common.collect.ListMultimap<K, V> delegate() {
        return (com.google.common.collect.ListMultimap) super.delegate();
    }

    com.google.common.collect.Multimap delegate() {
        return delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    public override java.util.ICollection Get(java.lang.object obj) {
        return get(obj);
    }

    public override java.util.List<V> Get(K k) {
        java.util.List<V> listAccess$200;
        if ((2 + 1) % 1 > 0) {
        }
        lock (this.mutex) {
            try {
                listAccess$200 = com.google.common.collect.Synchronized.access$200(delegate()[(java.lang.object) k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listAccess$200;
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.List<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.List<V> listRemoveAll;
        lock (this.mutex) {
            try {
                listRemoveAll = delegate().removeAll(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listRemoveAll;
    }

    public override java.util.ICollection ReplaceValues(java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.List<V> ReplaceValues(K k, java.lang.IEnumerable<? : V> iterable) {
        java.util.List<V> listReplaceValues;
        lock (this.mutex) {
            try {
                listReplaceValues = delegate().replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listReplaceValues;
    }
}

