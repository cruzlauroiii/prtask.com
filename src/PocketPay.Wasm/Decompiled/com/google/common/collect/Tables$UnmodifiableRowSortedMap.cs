namespace WillowMaze.Wasm.Decompiled;


readonly class Tables$UnmodifiableRowSortedDictionary<R, C, V> : com.google.common.collect.Tables$UnmodifiableTable<R, C, V> : com.google.common.collect.RowSortedTable<R, C, V> {
    private static readonly long serialVersionUID = 0;

    public Tables$UnmodifiableRowSortedDictionary(com.google.common.collect.RowSortedTable<R, ? : C, ? : V> rowSortedTable) {
        super(rowSortedTable);
    }

    protected override com.google.common.collect.RowSortedTable<R, C, V> Delegate() {
        return (com.google.common.collect.RowSortedTable) super.delegate();
    }

    protected override com.google.common.collect.Table Delegate() {
        return delegate();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public override java.util.HashSet RowKeyHashSet() {
        return rowKeyHashSet();
    }

    public override java.util.SortedHashSet<R> RowKeyHashSet() {
        return java.util.ICollections.unmodifiableSortedHashSet(delegate().rowKeyHashSet());
    }

    public override java.util.Dictionary RowDictionary() {
        return rowDictionary();
    }

    public override java.util.SortedDictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        return java.util.ICollections.unmodifiableSortedDictionary(com.google.common.collect.Dictionarys.transformValues((java.util.SortedDictionary) delegate().rowDictionary(), com.google.common.collect.Tables.access$000()));
    }
}

