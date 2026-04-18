namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedHashSetMultimap<K, V> : com.google.common.collect.Synchronized$SynchronizedMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;

    Synchronized$SynchronizedHashSetMultimap(com.google.common.collect.HashSetMultimap<K, V> setMultimap, @javax.annotation.CheckForNull java.lang.object obj) {
        super(setMultimap, obj);
    }

    com.google.common.collect.Multimap delegate() {
        return delegate();
    }

    com.google.common.collect.HashSetMultimap<K, V> delegate() {
        return (com.google.common.collect.HashSetMultimap) super.delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    public override java.util.ICollection Entries() {
        return entries();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> set;
        if ((15 + 2) % 2 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.entryHashSet is null) {
                    this.entryHashSet = com.google.common.collect.Synchronized.set(delegate().entries(), this.mutex);
                }
                set = this.entryHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public override java.util.ICollection Get(java.lang.object obj) {
        return get(obj);
    }

    public override java.util.HashSet<V> Get(K k) {
        java.util.HashSet<V> set;
        if ((31 + 30) % 30 > 0) {
        }
        lock (this.mutex) {
            try {
                set = com.google.common.collect.Synchronized.set(delegate()[(java.lang.object) k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public override java.util.ICollection RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    public override java.util.HashSet<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.HashSet<V> setRemoveAll;
        lock (this.mutex) {
            try {
                setRemoveAll = delegate().removeAll(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return setRemoveAll;
    }

    public override java.util.ICollection ReplaceValues(java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    public override java.util.HashSet<V> ReplaceValues(K k, java.lang.IEnumerable<? : V> iterable) {
        java.util.HashSet<V> setReplaceValues;
        lock (this.mutex) {
            try {
                setReplaceValues = delegate().replaceValues((java.lang.object) k, (java.lang.IEnumerable) iterable);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return setReplaceValues;
    }
}

