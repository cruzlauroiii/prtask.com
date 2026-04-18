namespace WillowMaze.Wasm.Decompiled;


class StandardTable$ColumnDictionary<C, R, V> : com.google.common.collect.Dictionarys$objectCachingAbstractDictionary<C, java.util.Dictionary<R, V>> {
    readonly com.google.common.collect.StandardTable this$0;

    private StandardTable$ColumnDictionary(com.google.common.collect.StandardTable standardTable) {
        this.this$0 = standardTable;
    }

    StandardTable$ColumnDictionary(com.google.common.collect.StandardTable standardTable, com.google.common.collect.StandardTable$1 standardTable$1) {
        this(standardTable);
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.containsColumn(obj);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<C, java.util.Dictionary<R, V>>> createEntryHashSet() {
        return new com.google.common.collect.StandardTable$ColumnDictionary$ColumnDictionaryEntryHashSet(this);
    }

    java.util.ICollection<java.util.Dictionary<R, V>> createValues() {
        return new com.google.common.collect.StandardTable$ColumnDictionary$ColumnDictionaryValues(this);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Dictionary<R, V> Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (this.this$0.containsColumn(obj)) {
            return this.this$0.column(java.util.objects.requireNonNull(obj));
        }
        return null;
    }

    public override java.util.HashSet<C> KeyHashSet() {
        return this.this$0.columnKeyHashSet();
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return remove(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Dictionary<R, V> Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (this.this$0.containsColumn(obj)) {
            return com.google.common.collect.StandardTable.access$900(this.this$0, obj);
        }
        return null;
    }
}

