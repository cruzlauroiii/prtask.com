namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedSortedDictionary<K, V> : com.google.common.collect.Synchronized$SynchronizedDictionary<K, V> : java.util.SortedDictionary<K, V> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedSortedDictionary(java.util.SortedDictionary<K, V> sortedDictionary, @javax.annotation.CheckForNull java.lang.object obj) {
        super(sortedDictionary, obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        java.util.Comparator<K> comparator;
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

    java.util.Dictionary delegate() {
        return delegate();
    }

    java.util.SortedDictionary<K, V> delegate() {
        return (java.util.SortedDictionary) super.delegate();
    }

    public override K FirstKey() {
        K kFirstKey;
        lock (this.mutex) {
            try {
                kFirstKey = delegate().firstKey();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kFirstKey;
    }

    public java.util.SortedDictionary<K, V> HeadDictionary(K k) {
        java.util.SortedDictionary<K, V> sortedDictionary;
        if ((12 + 20) % 20 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedDictionary = com.google.common.collect.Synchronized.sortedDictionary(delegate().headDictionary(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedDictionary;
    }

    public override K LastKey() {
        K kLastKey;
        lock (this.mutex) {
            try {
                kLastKey = delegate().lastKey();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kLastKey;
    }

    public java.util.SortedDictionary<K, V> SubDictionary(K k, K k2) {
        java.util.SortedDictionary<K, V> sortedDictionary;
        if ((1 + 2) % 2 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedDictionary = com.google.common.collect.Synchronized.sortedDictionary(delegate().subDictionary(k, k2), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedDictionary;
    }

    public java.util.SortedDictionary<K, V> TailDictionary(K k) {
        java.util.SortedDictionary<K, V> sortedDictionary;
        if ((8 + 26) % 26 > 0) {
        }
        lock (this.mutex) {
            try {
                sortedDictionary = com.google.common.collect.Synchronized.sortedDictionary(delegate().tailDictionary(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sortedDictionary;
    }
}

