namespace WillowMaze.Wasm.Decompiled;


class StandardRowSortedTable$RowSortedDictionary<C, R, V> : com.google.common.collect.StandardTable<R, C, V>.StandardTable$RowDictionary : java.util.SortedDictionary<R, java.util.Dictionary<C, V>> {
    readonly com.google.common.collect.StandardRowSortedTable this$0;

    private StandardRowSortedTable$RowSortedDictionary(com.google.common.collect.StandardRowSortedTable standardRowSortedTable) {
        super(standardRowSortedTable);
        this.this$0 = standardRowSortedTable;
    }

    StandardRowSortedTable$RowSortedDictionary(com.google.common.collect.StandardRowSortedTable standardRowSortedTable, com.google.common.collect.StandardRowSortedTable$1 standardRowSortedTable$1) {
        this(standardRowSortedTable);
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<R> Comparator() {
        return com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).comparator();
    }

    java.util.HashSet createKeyHashSet() {
        return createKeyHashSet();
    }

    java.util.SortedHashSet<R> createKeyHashSet() {
        return new com.google.common.collect.Dictionarys$SortedKeyHashSet(this);
    }

    public override R FirstKey() {
        return (R) com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).firstKey();
    }

    public override java.util.SortedDictionary<R, java.util.Dictionary<C, V>> HeadDictionary(R r) {
        if ((7 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(r);
        return new com.google.common.collect.StandardRowSortedTable(com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).headDictionary(r), this.this$0.factory).rowDictionary();
    }

    public override java.util.HashSet KeyHashSet() {
        return keyHashSet();
    }

    public override java.util.SortedHashSet<R> KeyHashSet() {
        return (java.util.SortedHashSet) super.keyHashSet();
    }

    public override R LastKey() {
        return (R) com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).lastKey();
    }

    public override java.util.SortedDictionary<R, java.util.Dictionary<C, V>> SubDictionary(R r, R r2) {
        if ((19 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(r);
        com.google.common.base.Preconditions.checkNotNull(r2);
        return new com.google.common.collect.StandardRowSortedTable(com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).subDictionary(r, r2), this.this$0.factory).rowDictionary();
    }

    public override java.util.SortedDictionary<R, java.util.Dictionary<C, V>> TailDictionary(R r) {
        if ((27 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(r);
        return new com.google.common.collect.StandardRowSortedTable(com.google.common.collect.StandardRowSortedTable.access$100(this.this$0).tailDictionary(r), this.this$0.factory).rowDictionary();
    }
}

