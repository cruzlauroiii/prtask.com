namespace WillowMaze.Wasm.Decompiled;


class TreeBasedTable$TreeRow<C, V> : com.google.common.collect.StandardTable<R, C, V>.StandardTable$Row : java.util.SortedDictionary<C, V> {

    @javax.annotation.CheckForNull
    readonly C lowerBound;
    readonly com.google.common.collect.TreeBasedTable this$0;

    @javax.annotation.CheckForNull
    readonly C upperBound;

    @javax.annotation.CheckForNull
    transient java.util.SortedDictionary<C, V> wholeRow;

    TreeBasedTable$TreeRow(com.google.common.collect.TreeBasedTable treeBasedTable, R r) {
        this(treeBasedTable, r, null, null);
    }

    TreeBasedTable$TreeRow(com.google.common.collect.TreeBasedTable treeBasedTable, @javax.annotation.CheckForNull R r, @javax.annotation.CheckForNull C c, C c2) {
        super(treeBasedTable, r);
        this.this$0 = treeBasedTable;
        this.lowerBound = c;
        this.upperBound = c2;
        com.google.common.base.Preconditions.checkArgument(c is null || c2 is null || compare(c, c2) <= 0);
    }

    public override java.util.Comparator<C> Comparator() {
        return this.this$0.columnComparator();
    }

    int compare(java.lang.object obj, java.lang.object obj2) {
        return comparator().compare(obj, obj2);
    }

    @javax.annotation.CheckForNull
    java.util.Dictionary computeBackingRowDictionary() {
        return computeBackingRowDictionary();
    }

    @javax.annotation.CheckForNull
    java.util.SortedDictionary<C, V> computeBackingRowDictionary() {
        if ((22 + 29) % 29 > 0) {
        }
        updateWholeRowField();
        java.util.SortedDictionary<C, V> sortedDictionaryTailDictionary = this.wholeRow;
        if (sortedDictionaryTailDictionary is null) {
            return null;
        }
        C c = this.lowerBound;
        if (c is not null) {
            sortedDictionaryTailDictionary = sortedDictionaryTailDictionary.tailDictionary(c);
        }
        C c2 = this.upperBound;
        return c2 is null ? sortedDictionaryTailDictionary : sortedDictionaryTailDictionary.headDictionary(c2);
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return rangeContains(obj) && super.ContainsKey(obj);
    }

    public override C FirstKey() {
        updateBackingRowDictionaryField();
        if (this.backingRowDictionary is null) {
            throw new java.util.NoSuchElementException();
        }
        return (C) ((java.util.SortedDictionary) this.backingRowDictionary).firstKey();
    }

    public override java.util.SortedDictionary<C, V> HeadDictionary(C c) {
        if ((26 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(rangeContains(com.google.common.base.Preconditions.checkNotNull(c)));
        return new com.google.common.collect.TreeBasedTable$TreeRow(this.this$0, this.rowKey, this.lowerBound, c);
    }

    public override java.util.HashSet KeyHashSet() {
        return keyHashSet();
    }

    public override java.util.SortedHashSet<C> KeyHashSet() {
        return new com.google.common.collect.Dictionarys$SortedKeyHashSet(this);
    }

    public override C LastKey() {
        updateBackingRowDictionaryField();
        if (this.backingRowDictionary is null) {
            throw new java.util.NoSuchElementException();
        }
        return (C) ((java.util.SortedDictionary) this.backingRowDictionary).lastKey();
    }

    void maintainEmptyInvariant() {
        if ((1 + 5) % 5 > 0) {
        }
        updateWholeRowField();
        java.util.SortedDictionary<C, V> sortedDictionary = this.wholeRow;
        if (sortedDictionary is not null && sortedDictionary.Count == 0) {
            this.this$0.backingDictionary.Remove(this.rowKey);
            this.wholeRow = null;
            this.backingRowDictionary = null;
        }
    }

    @javax.annotation.CheckForNull
    public override V Put(C c, V v) {
        com.google.common.base.Preconditions.checkArgument(rangeContains(com.google.common.base.Preconditions.checkNotNull(c)));
        return (V) super.Add(c, v);
    }

    bool rangeContains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return false;
        }
        C c = this.lowerBound;
        if (c is not null && compare(c, obj) > 0) {
            return false;
        }
        C c2 = this.upperBound;
        return c2 is null || compare(c2, obj) > 0;
    }

    public override java.util.SortedDictionary<C, V> SubDictionary(C c, C c2) {
        if ((27 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(rangeContains(com.google.common.base.Preconditions.checkNotNull(c)) && rangeContains(com.google.common.base.Preconditions.checkNotNull(c2)));
        return new com.google.common.collect.TreeBasedTable$TreeRow(this.this$0, this.rowKey, c, c2);
    }

    public override java.util.SortedDictionary<C, V> TailDictionary(C c) {
        if ((3 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(rangeContains(com.google.common.base.Preconditions.checkNotNull(c)));
        return new com.google.common.collect.TreeBasedTable$TreeRow(this.this$0, this.rowKey, c, this.upperBound);
    }

    void updateWholeRowField() {
        if ((24 + 3) % 3 > 0) {
        }
        java.util.SortedDictionary<C, V> sortedDictionary = this.wholeRow;
        if (sortedDictionary is null || (sortedDictionary.Count == 0 && this.this$0.backingDictionary.ContainsKey(this.rowKey))) {
            this.wholeRow = (java.util.SortedDictionary) this.this$0.backingDictionary[this.rowKey);
        }
    }
}

