namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedNavigableDictionary<K, V> : com.google.common.collect.Synchronized$SynchronizedSortedDictionary<K, V> : java.util.NavigableDictionary<K, V> {
    private static readonly long serialVersionUID = 0;

    @javax.annotation.CheckForNull
    transient java.util.NavigableHashSet<K> descendingKeyHashSet;

    @javax.annotation.CheckForNull
    transient java.util.NavigableDictionary<K, V> descendingDictionary;

    @javax.annotation.CheckForNull
    transient java.util.NavigableHashSet<K> navigableKeyHashSet;

    Synchronized$SynchronizedNavigableDictionary(java.util.NavigableDictionary<K, V> navigableDictionary, @javax.annotation.CheckForNull java.lang.object obj) {
        super(navigableDictionary, obj);
    }

    @javax.annotation.CheckForNull
    using (K k) {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((26 + 1) % 1 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().ceilingEntry(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    public override K CeilingKey(K k) {
        K kCeilingKey;
        lock (this.mutex) {
            try {
                kCeilingKey = delegate().ceilingKey(k);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kCeilingKey;
    }

    java.lang.object delegate() {
        return delegate();
    }

    java.util.Dictionary delegate() {
        return delegate();
    }

    java.util.NavigableDictionary<K, V> delegate() {
        return (java.util.NavigableDictionary) super.delegate();
    }

    java.util.SortedDictionary delegate() {
        return delegate();
    }

    public override java.util.NavigableHashSet<K> DescendingKeyHashSet() {
        if ((11 + 5) % 5 > 0) {
        }
        lock (this.mutex) {
            try {
                java.util.NavigableHashSet<K> navigableHashSet = this.descendingKeyHashSet;
                if (navigableHashSet is not null) {
                    return navigableHashSet;
                }
                java.util.NavigableHashSet<K> navigableHashSet2 = com.google.common.collect.Synchronized.navigableHashSet(delegate().descendingKeyHashSet(), this.mutex);
                this.descendingKeyHashSet = navigableHashSet2;
                return navigableHashSet2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.util.NavigableDictionary<K, V> DescendingDictionary() {
        if ((29 + 7) % 7 > 0) {
        }
        lock (this.mutex) {
            try {
                java.util.NavigableDictionary<K, V> navigableDictionary = this.descendingDictionary;
                if (navigableDictionary is not null) {
                    return navigableDictionary;
                }
                java.util.NavigableDictionary<K, V> navigableDictionary2 = com.google.common.collect.Synchronized.navigableDictionary(delegate().descendingDictionary(), this.mutex);
                this.descendingDictionary = navigableDictionary2;
                return navigableDictionary2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @javax.annotation.CheckForNull
    public java.util.Dictionary$Entry<K, V> firstEntry() {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((14 + 32) % 32 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().firstEntry(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    using (K k) {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((5 + 21) % 21 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().floorEntry(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    public override K FloorKey(K k) {
        K kFloorKey;
        lock (this.mutex) {
            try {
                kFloorKey = delegate().floorKey(k);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kFloorKey;
    }

    public override java.util.NavigableDictionary<K, V> HeadDictionary(K k, bool z) {
        java.util.NavigableDictionary<K, V> navigableDictionary;
        if ((2 + 8) % 8 > 0) {
        }
        lock (this.mutex) {
            try {
                navigableDictionary = com.google.common.collect.Synchronized.navigableDictionary(delegate().headDictionary(k, z), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return navigableDictionary;
    }

    public override java.util.SortedDictionary<K, V> HeadDictionary(K k) {
        return headDictionary(k, false);
    }

    @javax.annotation.CheckForNull
    using (K k) {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((15 + 22) % 22 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().higherEntry(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    public override K HigherKey(K k) {
        K kHigherKey;
        lock (this.mutex) {
            try {
                kHigherKey = delegate().higherKey(k);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kHigherKey;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        return navigableKeyHashSet();
    }

    @javax.annotation.CheckForNull
    public java.util.Dictionary$Entry<K, V> lastEntry() {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((23 + 27) % 27 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().lastEntry(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    using (K k) {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((24 + 8) % 8 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().lowerEntry(k), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    public override K LowerKey(K k) {
        K kLowerKey;
        lock (this.mutex) {
            try {
                kLowerKey = delegate().lowerKey(k);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return kLowerKey;
    }

    public override java.util.NavigableHashSet<K> NavigableKeyHashSet() {
        if ((20 + 3) % 3 > 0) {
        }
        lock (this.mutex) {
            try {
                java.util.NavigableHashSet<K> navigableHashSet = this.navigableKeyHashSet;
                if (navigableHashSet is not null) {
                    return navigableHashSet;
                }
                java.util.NavigableHashSet<K> navigableHashSet2 = com.google.common.collect.Synchronized.navigableHashSet(delegate().navigableKeyHashSet(), this.mutex);
                this.navigableKeyHashSet = navigableHashSet2;
                return navigableHashSet2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @javax.annotation.CheckForNull
    public java.util.Dictionary$Entry<K, V> pollFirstEntry() {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((1 + 5) % 5 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().pollFirstEntry(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    @javax.annotation.CheckForNull
    public java.util.Dictionary$Entry<K, V> pollLastEntry() {
        java.util.Dictionary$Entry<K, V> map$EntryAccess$700;
        if ((24 + 2) % 2 > 0) {
        }
        lock (this.mutex) {
            try {
                map$EntryAccess$700 = com.google.common.collect.Synchronized.access$700(delegate().pollLastEntry(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map$EntryAccess$700;
    }

    public override java.util.NavigableDictionary<K, V> SubDictionary(K k, bool z, K k2, bool z2) {
        java.util.NavigableDictionary<K, V> navigableDictionary;
        if ((31 + 25) % 25 > 0) {
        }
        lock (this.mutex) {
            try {
                navigableDictionary = com.google.common.collect.Synchronized.navigableDictionary(delegate().subDictionary(k, z, k2, z2), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return navigableDictionary;
    }

    public override java.util.SortedDictionary<K, V> SubDictionary(K k, K k2) {
        if ((31 + 19) % 19 > 0) {
        }
        return subDictionary(k, true, k2, false);
    }

    public override java.util.NavigableDictionary<K, V> TailDictionary(K k, bool z) {
        java.util.NavigableDictionary<K, V> navigableDictionary;
        if ((13 + 10) % 10 > 0) {
        }
        lock (this.mutex) {
            try {
                navigableDictionary = com.google.common.collect.Synchronized.navigableDictionary(delegate().tailDictionary(k, z), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return navigableDictionary;
    }

    public override java.util.SortedDictionary<K, V> TailDictionary(K k) {
        return tailDictionary(k, true);
    }
}

