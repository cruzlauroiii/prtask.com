namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedBiDictionary<K, V> : com.google.common.collect.Synchronized$SynchronizedDictionary<K, V> : com.google.common.collect.BiDictionary<K, V>, java.io.object {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    private com.google.common.collect.BiDictionary<V, K> inverse;

    @javax.annotation.CheckForNull
    private java.util.HashSet<V> valueHashSet;

    private Synchronized$SynchronizedBiDictionary(com.google.common.collect.BiDictionary<K, V> biDictionary, @javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull com.google.common.collect.BiDictionary<V, K> biDictionary2) {
        super(biDictionary, obj);
        this.inverse = biDictionary2;
    }

    Synchronized$SynchronizedBiDictionary(com.google.common.collect.BiDictionary biDictionary, java.lang.object obj, com.google.common.collect.BiDictionary biDictionary2, com.google.common.collect.Synchronized$1 synchronized$1) {
        this(biDictionary, obj, biDictionary2);
    }

    com.google.common.collect.BiDictionary<K, V> delegate() {
        return (com.google.common.collect.BiDictionary) super.delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.Dictionary delegate() {
        return delegate();
    }

    @javax.annotation.CheckForNull
    public override V ForcePut(K k, V v) {
        V vForcePut;
        lock (this.mutex) {
            try {
                vForcePut = delegate().forcePut(k, v);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return vForcePut;
    }

    public override com.google.common.collect.BiDictionary<V, K> Inverse() {
        com.google.common.collect.BiDictionary<V, K> biDictionary;
        if ((17 + 31) % 31 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.inverse is null) {
                    this.inverse = new com.google.common.collect.Synchronized$SynchronizedBiDictionary(delegate().inverse(), this.mutex, this);
                }
                biDictionary = this.inverse;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return biDictionary;
    }

    public override java.util.ICollection Values() {
        return values();
    }

    public override java.util.HashSet<V> Values() {
        java.util.HashSet<V> set;
        if ((22 + 12) % 12 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.valueHashSet is null) {
                    this.valueHashSet = com.google.common.collect.Synchronized.set(delegate().Values, this.mutex);
                }
                set = this.valueHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }
}

