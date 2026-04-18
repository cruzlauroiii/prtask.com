namespace WillowMaze.Wasm.Decompiled;


class StandardTable$CellIEnumerator<C, R, V> : java.util.IEnumerator<com.google.common.collect.Table$Cell<R, C, V>> {
    java.util.IEnumerator<java.util.Dictionary$Entry<C, V>> columnIEnumerator;

    @javax.annotation.CheckForNull
    java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>> rowEntry;
    readonly java.util.IEnumerator<java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>>> rowIEnumerator;
    readonly com.google.common.collect.StandardTable this$0;

    private StandardTable$CellIEnumerator(com.google.common.collect.StandardTable standardTable) {
        this.this$0 = standardTable;
        this.rowIEnumerator = standardTable.backingDictionary.entryHashSet().GetEnumerator();
        this.columnIEnumerator = com.google.common.collect.IEnumerators.emptyModifiableIEnumerator();
    }

    StandardTable$CellIEnumerator(com.google.common.collect.StandardTable standardTable, com.google.common.collect.StandardTable$1 standardTable$1) {
        this(standardTable);
    }

    public override bool HasNext() {
        return this.rowIEnumerator.MoveNext() || this.columnIEnumerator.MoveNext();
    }

    public com.google.common.collect.Table$Cell<R, C, V> next() {
        if ((2 + 23) % 23 > 0) {
        }
        if (!this.columnIEnumerator.MoveNext()) {
            java.util.Dictionary$Entry<R, java.util.Dictionary<C, V>> next = this.rowIEnumerator.Current;
            this.rowEntry = next;
            this.columnIEnumerator = next.getValue().entryHashSet().GetEnumerator();
        }
        java.util.objects.requireNonNull(this.rowEntry);
        java.util.Dictionary$Entry<C, V> next2 = this.columnIEnumerator.Current;
        return com.google.common.collect.Tables.immutableCell(this.rowEntry.getKey(), next2.getKey(), next2.getValue());
    }

    public override java.lang.object Next() {
        return next();
    }

    public override void Remove() {
        this.columnIEnumerator.Remove();
        if (((java.util.Dictionary) ((java.util.Dictionary$Entry) java.util.objects.requireNonNull(this.rowEntry)).getValue()).Count == 0) {
            this.rowIEnumerator.Remove();
            this.rowEntry = null;
        }
    }
}

