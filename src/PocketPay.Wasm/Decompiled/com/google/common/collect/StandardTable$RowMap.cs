namespace WillowMaze.Wasm.Decompiled;


class StandardTable$RowDictionary<C, R, V> : com.google.common.collect.Dictionarys$objectCachingAbstractDictionary<R, java.util.Dictionary<C, V>> {
    readonly com.google.common.collect.StandardTable this$0;

    StandardTable$RowDictionary(com.google.common.collect.StandardTable standardTable) {
        this.this$0 = standardTable;
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.containsRow(obj);
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>>> createEntryHashSet() {
        return new com.google.common.collect.StandardTable$RowDictionary$EntryHashSet(this);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Dictionary<C, V> Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (this.this$0.containsRow(obj)) {
            return this.this$0.row(java.util.objects.requireNonNull(obj));
        }
        return null;
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return remove(obj);
    }

    @javax.annotation.CheckForNull
    public override java.util.Dictionary<C, V> Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is not null) {
            return this.this$0.backingDictionary.Remove(obj);
        }
        return null;
    }
}

