namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedDictionary<K, V> : com.google.common.collect.Synchronized$Synchronizedobject : java.util.Dictionary<K, V> {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<K> keyHashSet;

    @javax.annotation.CheckForNull
    transient java.util.ICollection<V> values;

    Synchronized$SynchronizedDictionary(java.util.Dictionary<K, V> map, @javax.annotation.CheckForNull java.lang.object obj) {
        super(map, obj);
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

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zContainsKey;
        lock (this.mutex) {
            try {
                zContainsKey = delegate().ContainsKey(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsKey;
    }

    public bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zContainsValue;
        lock (this.mutex) {
            try {
                zContainsValue = delegate().containsValue(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsValue;
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.Dictionary<K, V> delegate() {
        return (java.util.Dictionary) super.delegate();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        java.util.HashSet<java.util.Dictionary$Entry<K, V>> set;
        if ((19 + 19) % 19 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.entryHashSet is null) {
                    this.entryHashSet = com.google.common.collect.Synchronized.set(delegate().entryHashSet(), this.mutex);
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

    @javax.annotation.CheckForNull
    public V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        V v;
        lock (this.mutex) {
            try {
                v = delegate()[obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return v;
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

    public override java.util.HashSet<K> KeyHashSet() {
        java.util.HashSet<K> set;
        if ((28 + 8) % 8 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.keyHashSet is null) {
                    this.keyHashSet = com.google.common.collect.Synchronized.set(delegate().keyHashSet(), this.mutex);
                }
                set = this.keyHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    @javax.annotation.CheckForNull
    public override V Put(K k, V v) {
        V vPut;
        lock (this.mutex) {
            try {
                vPut = delegate().Add(k, v);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return vPut;
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        lock (this.mutex) {
            try {
                delegate().putAll(map);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        V vRemove;
        lock (this.mutex) {
            try {
                vRemove = delegate().Remove(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return vRemove;
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

    public java.util.ICollection<V> Values() {
        java.util.ICollection<V> collection;
        if ((17 + 19) % 19 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.values is null) {
                    this.values = com.google.common.collect.Synchronized.access$500(delegate().Values, this.mutex);
                }
                collection = this.values;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collection;
    }
}

