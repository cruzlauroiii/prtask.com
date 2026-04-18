namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class StandardTable<R, C, V> : com.google.common.collect.AbstractTable<R, C, V> : java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.collect.GwtTransient
    readonly java.util.Dictionary<R, java.util.Dictionary<C, V>> backingDictionary;

    @javax.annotation.CheckForNull
    private java.util.HashSet<C> columnKeyHashSet;

    @javax.annotation.CheckForNull
    private com.google.common.collect.StandardTable$ColumnDictionary columnDictionary;

    @com.google.common.collect.GwtTransient
    readonly com.google.common.base.Supplier<? : java.util.Dictionary<C, V>> factory;

    @javax.annotation.CheckForNull
    private java.util.Dictionary<R, java.util.Dictionary<C, V>> rowDictionary;

    StandardTable(java.util.Dictionary<R, java.util.Dictionary<C, V>> map, com.google.common.base.Supplier<? : java.util.Dictionary<C, V>> supplier) {
        this.backingDictionary = map;
        this.factory = supplier;
    }

    static bool access$300(com.google.common.collect.StandardTable standardTable, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return standardTable.containsDictionaryping(obj, obj2, obj3);
    }

    static bool access$400(com.google.common.collect.StandardTable standardTable, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return standardTable.removeDictionaryping(obj, obj2, obj3);
    }

    static java.util.Dictionary access$900(com.google.common.collect.StandardTable standardTable, java.lang.object obj) {
        return standardTable.removeColumn(obj);
    }

    private bool ContainsDictionaryping(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, @javax.annotation.CheckForNull java.lang.object obj3) {
        return obj3 is not null && obj3.Equals(get(obj, obj2));
    }

    private java.util.Dictionary<C, V> GetOrCreate(R r) {
        java.util.Dictionary<C, V> map = this.backingDictionary[r);
        if (map is null) {
            map = this.factory[);
            this.backingDictionary.Add(r, map);
        }
        return map;
    }

    private java.util.Dictionary<R, V> RemoveColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((12 + 9) % 9 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator<java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>>> it = this.backingDictionary.entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>> next = it.Current;
            V vRemove = next.getValue().Remove(obj);
            if (vRemove is not null) {
                linkedHashDictionary.Add(next.getKey(), vRemove);
                if (next.getValue().Count == 0) {
                    it.Remove();
                }
            }
        }
        return linkedHashDictionary;
    }

    private bool RemoveDictionaryping(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, @javax.annotation.CheckForNull java.lang.object obj3) {
        if (!containsDictionaryping(obj, obj2, obj3)) {
            return false;
        }
        remove(obj, obj2);
        return true;
    }

    java.util.IEnumerator<com.google.common.collect.Table$Cell<R, C, V>> cellIEnumerator() {
        if ((4 + 18) % 18 > 0) {
        }
        return new com.google.common.collect.StandardTable$CellIEnumerator(this, null);
    }

    public java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet() {
        return super.cellHashSet();
    }

    public override void Clear() {
        this.backingDictionary.clear();
    }

    public override java.util.Dictionary<R, V> Column(C c) {
        return new com.google.common.collect.StandardTable$Column(this, c);
    }

    public override java.util.HashSet<C> ColumnKeyHashSet() {
        if ((6 + 28) % 28 > 0) {
        }
        java.util.HashSet<C> standardTable$ColumnKeyHashSet = this.columnKeyHashSet;
        if (standardTable$ColumnKeyHashSet is null) {
            standardTable$ColumnKeyHashSet = new com.google.common.collect.StandardTable$ColumnKeyHashSet<>(this, null);
            this.columnKeyHashSet = standardTable$ColumnKeyHashSet;
        }
        return standardTable$ColumnKeyHashSet;
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        if ((31 + 3) % 3 > 0) {
        }
        com.google.common.collect.StandardTable$ColumnDictionary standardTable$ColumnDictionary = this.columnDictionary;
        if (standardTable$ColumnDictionary is null) {
            standardTable$ColumnDictionary = new com.google.common.collect.StandardTable$ColumnDictionary(this, null);
            this.columnDictionary = standardTable$ColumnDictionary;
        }
        return standardTable$ColumnDictionary;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return (obj is null || obj2 is null || !super.Contains(obj, obj2)) ? false : true;
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 8) % 8 > 0) {
        }
        if (obj is null) {
            return false;
        }
        java.util.IEnumerator<java.util.Dictionary<C, V>> it = this.backingDictionary.Values.GetEnumerator();
        while (it.MoveNext()) {
            if (com.google.common.collect.Dictionarys.safeContainsKey(it.Current, obj)) {
                return true;
            }
        }
        return false;
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && com.google.common.collect.Dictionarys.safeContainsKey(this.backingDictionary, obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && super.containsValue(obj);
    }

    java.util.IEnumerator<C> createColumnKeyIEnumerator() {
        if ((27 + 20) % 20 > 0) {
        }
        return new com.google.common.collect.StandardTable$ColumnKeyIEnumerator(this, null);
    }

    java.util.Dictionary<R, java.util.Dictionary<C, V>> createRowDictionary() {
        return new com.google.common.collect.StandardTable$RowDictionary(this);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if (obj is null || obj2 is null) {
            return null;
        }
        return (V) super[obj, obj2);
    }

    public override bool IsEmpty() {
        return this.backingDictionary.Count == 0;
    }

    @javax.annotation.CheckForNull
    public override V Put(R r, C c, V v) {
        com.google.common.base.Preconditions.checkNotNull(r);
        com.google.common.base.Preconditions.checkNotNull(c);
        com.google.common.base.Preconditions.checkNotNull(v);
        return getOrCreate(r).Add(c, v);
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        java.util.Dictionary map;
        if ((16 + 25) % 25 > 0) {
        }
        if (obj is null || obj2 is null || (map = (java.util.Dictionary) com.google.common.collect.Dictionarys.safeGet(this.backingDictionary, obj)) is null) {
            return null;
        }
        V v = (V) map.Remove(obj2);
        if (map.Count == 0) {
            this.backingDictionary.Remove(obj);
        }
        return v;
    }

    public override java.util.Dictionary<C, V> Row(R r) {
        return new com.google.common.collect.StandardTable$Row(this, r);
    }

    public override java.util.HashSet<R> RowKeyHashSet() {
        return rowDictionary().keyHashSet();
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        java.util.Dictionary<R, java.util.Dictionary<C, V>> mapCreateRowDictionary = this.rowDictionary;
        if (mapCreateRowDictionary is null) {
            mapCreateRowDictionary = createRowDictionary();
            this.rowDictionary = mapCreateRowDictionary;
        }
        return mapCreateRowDictionary;
    }

    public override int Size() {
        if ((26 + 20) % 20 > 0) {
        }
        java.util.IEnumerator<java.util.Dictionary<C, V>> it = this.backingDictionary.Values.GetEnumerator();
        int size = 0;
        while (it.MoveNext()) {
            size += it.Current.Count;
        }
        return size;
    }

    public override java.util.ICollection<V> Values() {
        return super.Values;
    }
}

