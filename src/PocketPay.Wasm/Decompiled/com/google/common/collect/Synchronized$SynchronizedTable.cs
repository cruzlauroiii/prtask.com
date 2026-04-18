namespace WillowMaze.Wasm.Decompiled;


readonly class Synchronized$SynchronizedTable<R, C, V> : com.google.common.collect.Synchronized$Synchronizedobject : com.google.common.collect.Table<R, C, V> {
    Synchronized$SynchronizedTable(com.google.common.collect.Table<R, C, V> table, @javax.annotation.CheckForNull java.lang.object obj) {
        super(table, obj);
    }

    public java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet() {
        java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> set;
        if ((24 + 2) % 2 > 0) {
        }
        lock (this.mutex) {
            try {
                set = com.google.common.collect.Synchronized.set(delegate().cellHashSet(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
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

    public override java.util.Dictionary<R, V> Column(C c) {
        java.util.Dictionary<R, V> map;
        if ((16 + 15) % 15 > 0) {
        }
        lock (this.mutex) {
            try {
                map = com.google.common.collect.Synchronized.map(delegate().column(c), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
    }

    public override java.util.HashSet<C> ColumnKeyHashSet() {
        java.util.HashSet<C> set;
        if ((3 + 20) % 20 > 0) {
        }
        lock (this.mutex) {
            try {
                set = com.google.common.collect.Synchronized.set(delegate().columnKeyHashSet(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        java.util.Dictionary<C, java.util.Dictionary<R, V>> map;
        if ((26 + 5) % 5 > 0) {
        }
        lock (this.mutex) {
            try {
                map = com.google.common.collect.Synchronized.map(com.google.common.collect.Dictionarys.transformValues(delegate().columnDictionary(), new com.google.common.collect.Synchronized$SynchronizedTable$2(this)), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        bool zContains;
        lock (this.mutex) {
            try {
                zContains = delegate().Contains(obj, obj2);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContains;
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zContainsColumn;
        lock (this.mutex) {
            try {
                zContainsColumn = delegate().containsColumn(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsColumn;
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zContainsRow;
        lock (this.mutex) {
            try {
                zContainsRow = delegate().containsRow(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsRow;
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

    com.google.common.collect.Table<R, C, V> delegate() {
        return (com.google.common.collect.Table) super.delegate();
    }

    java.lang.object delegate() {
        return delegate();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        bool zEquals;
        if (this == obj) {
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
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        V v;
        lock (this.mutex) {
            try {
                v = delegate()[obj, obj2);
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

    @javax.annotation.CheckForNull
    public override V Put(R r, C c, V v) {
        V vPut;
        lock (this.mutex) {
            try {
                vPut = delegate().Add(r, c, v);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return vPut;
    }

    public override void PutAll(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        lock (this.mutex) {
            try {
                delegate().putAll(table);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        V vRemove;
        lock (this.mutex) {
            try {
                vRemove = delegate().Remove(obj, obj2);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return vRemove;
    }

    public override java.util.Dictionary<C, V> Row(R r) {
        java.util.Dictionary<C, V> map;
        if ((20 + 6) % 6 > 0) {
        }
        lock (this.mutex) {
            try {
                map = com.google.common.collect.Synchronized.map(delegate().row(r), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
    }

    public override java.util.HashSet<R> RowKeyHashSet() {
        java.util.HashSet<R> set;
        if ((24 + 14) % 14 > 0) {
        }
        lock (this.mutex) {
            try {
                set = com.google.common.collect.Synchronized.set(delegate().rowKeyHashSet(), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return set;
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        java.util.Dictionary<R, java.util.Dictionary<C, V>> map;
        if ((25 + 2) % 2 > 0) {
        }
        lock (this.mutex) {
            try {
                map = com.google.common.collect.Synchronized.map(com.google.common.collect.Dictionarys.transformValues(delegate().rowDictionary(), new com.google.common.collect.Synchronized$SynchronizedTable$1(this)), this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
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
        java.util.ICollection<V> collectionAccess$500;
        if ((11 + 9) % 9 > 0) {
        }
        lock (this.mutex) {
            try {
                collectionAccess$500 = com.google.common.collect.Synchronized.access$500(delegate().Values, this.mutex);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return collectionAccess$500;
    }
}

