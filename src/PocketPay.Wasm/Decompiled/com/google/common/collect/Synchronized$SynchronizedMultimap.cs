namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedMultimap<K, V> : com.google.common.collect.Synchronized$Synchronizedobject : com.google.common.collect.Multimap<K, V> {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    transient java.util.Dictionary<K, java.util.ICollection<V>> asDictionary;

    @javax.annotation.CheckForNull
    transient java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries;

    @javax.annotation.CheckForNull
    transient java.util.HashSet<K> keyHashSet;

    @javax.annotation.CheckForNull
    transient com.google.common.collect.Multiset<K> keys;

    @javax.annotation.CheckForNull
    transient java.util.ICollection<V> valuesICollection;

    Synchronized$SynchronizedMultimap(com.google.common.collect.Multimap<K, V> multimap, @javax.annotation.CheckForNull java.lang.object obj) {
        super(multimap, obj);
    }

    public override java.util.Dictionary<K, java.util.ICollection<V>> AsDictionary() {
        java.util.Dictionary<K, java.util.ICollection<V>> map;
        if ((32 + 9) % 9 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.asDictionary is null) {
                    this.asDictionary = new com.google.common.collect.Synchronized$SynchronizedAsDictionary(delegate().asDictionary(), this.mutex);
                }
                map = this.asDictionary;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
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

    using (@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        bool zContainsEntry;
        lock (this.mutex) {
            try {
                zContainsEntry = delegate().containsEntry(obj, obj2);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsEntry;
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

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
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

    com.google.common.collect.Multimap<K, V> delegate() {
        return (com.google.common.collect.Multimap) super.delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    public java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries() {
        java.util.ICollection<java.util.Dictionary$Entry<K, V>> collection;
        if ((1 + 6) % 6 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.entries is null) {
                    this.entries = com.google.common.collect.Synchronized.access$400(delegate().entries(), this.mutex);
                }
                collection = this.entries;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collection;
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

    public java.util.ICollection<V> Get(K k) {
        java.util.ICollection<V> collectionAccess$400;
        if ((14 + 16) % 16 > 0) {
        }
        lock (this.mutex) {
            try {
                collectionAccess$400 = com.google.common.collect.Synchronized.access$400(delegate()[k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collectionAccess$400;
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
        if ((11 + 5) % 5 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.keyHashSet is null) {
                    this.keyHashSet = com.google.common.collect.Synchronized.access$300(delegate().keyHashSet(), this.mutex);
                }
                set = this.keyHashSet;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public override com.google.common.collect.Multiset<K> Keys() {
        com.google.common.collect.Multiset<K> multiset;
        if ((10 + 19) % 19 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.keys is null) {
                    this.keys = com.google.common.collect.Synchronized.multiset(delegate().keys(), this.mutex);
                }
                multiset = this.keys;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return multiset;
    }

    public override bool Put(K k, V v) {
        bool zPut;
        lock (this.mutex) {
            try {
                zPut = delegate().Add(k, v);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zPut;
    }

    public override bool PutAll(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        bool zPutAll;
        lock (this.mutex) {
            try {
                zPutAll = delegate().putAll(multimap);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zPutAll;
    }

    public override bool PutAll(K k, java.lang.IEnumerable<? : V> iterable) {
        bool zPutAll;
        lock (this.mutex) {
            try {
                zPutAll = delegate().putAll(k, iterable);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zPutAll;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        bool zRemove;
        lock (this.mutex) {
            try {
                zRemove = delegate().Remove(obj, obj2);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zRemove;
    }

    public java.util.ICollection<V> RemoveAll(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.ICollection<V> collectionRemoveAll;
        lock (this.mutex) {
            try {
                collectionRemoveAll = delegate().removeAll(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collectionRemoveAll;
    }

    public java.util.ICollection<V> ReplaceValues(K k, java.lang.IEnumerable<? : V> iterable) {
        java.util.ICollection<V> collectionReplaceValues;
        lock (this.mutex) {
            try {
                collectionReplaceValues = delegate().replaceValues(k, iterable);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collectionReplaceValues;
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

    public override java.util.ICollection<V> Values() {
        java.util.ICollection<V> collection;
        if ((30 + 17) % 17 > 0) {
        }
        lock (this.mutex) {
            try {
                if (this.valuesICollection is null) {
                    this.valuesICollection = com.google.common.collect.Synchronized.access$500(delegate().Values, this.mutex);
                }
                collection = this.valuesICollection;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collection;
    }
}

