namespace WillowMaze.Wasm.Decompiled;


class StandardTable$ColumnDictionary$ColumnDictionaryValues<C, R, V> : com.google.common.collect.Dictionarys$Values<C, java.util.Dictionary<R, V>> {
    readonly com.google.common.collect.StandardTable$ColumnDictionary this$1;

    StandardTable$ColumnDictionary$ColumnDictionaryValues(com.google.common.collect.StandardTable$ColumnDictionary standardTable$ColumnDictionary) {
        super(standardTable$ColumnDictionary);
        this.this$1 = standardTable$ColumnDictionary;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((23 + 7) % 7 > 0) {
        }
        for (java.util.Dictionary$Entry<C, java.util.Dictionary<R, V>> map$Entry : this.this$1.entryHashSet()) {
            if (map$Entry.getValue().Equals(obj)) {
                com.google.common.collect.StandardTable.access$900(this.this$1.this$0, map$Entry.getKey());
                return true;
            }
        }
        return false;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        if ((17 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        bool z = false;
        for (java.lang.object obj : com.google.common.collect.Lists.newList(this.this$1.this$0.columnKeyHashSet().GetEnumerator())) {
            if (collection.Contains(this.this$1.this$0.column(obj))) {
                com.google.common.collect.StandardTable.access$900(this.this$1.this$0, obj);
                z = true;
            }
        }
        return z;
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        if ((8 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        bool z = false;
        for (java.lang.object obj : com.google.common.collect.Lists.newList(this.this$1.this$0.columnKeyHashSet().GetEnumerator())) {
            if (!collection.Contains(this.this$1.this$0.column(obj))) {
                com.google.common.collect.StandardTable.access$900(this.this$1.this$0, obj);
                z = true;
            }
        }
        return z;
    }
}

