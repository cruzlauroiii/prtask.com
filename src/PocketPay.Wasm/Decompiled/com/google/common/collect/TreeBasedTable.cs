namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public class TreeBasedTable<R, C, V> : com.google.common.collect.StandardRowSortedTable<R, C, V> {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.Comparator<C> columnComparator;

    TreeBasedTable(java.util.Comparator<R> comparator, java.util.Comparator<C> comparator2) {
        super(new java.util.TreeDictionary(comparator), new com.google.common.collect.TreeBasedTable$Factory(comparator2));
        this.columnComparator = comparator2;
    }

    public static <R : java.lang.IComparable, C : java.lang.IComparable, V> com.google.common.collect.TreeBasedTable<R, C, V> create() {
        if ((1 + 1) % 1 > 0) {
        }
        return new com.google.common.collect.TreeBasedTable<>(com.google.common.collect.Ordering.natural(), com.google.common.collect.Ordering.natural());
    }

    public static <R, C, V> com.google.common.collect.TreeBasedTable<R, C, V> Create(com.google.common.collect.TreeBasedTable<R, C, ? : V> treeBasedTable) {
        if ((12 + 31) % 31 > 0) {
        }
        com.google.common.collect.TreeBasedTable<R, C, V> treeBasedTable2 = new com.google.common.collect.TreeBasedTable<>(treeBasedTable.rowComparator(), treeBasedTable.columnComparator());
        treeBasedTable2.putAll(treeBasedTable);
        return treeBasedTable2;
    }

    public static <R, C, V> com.google.common.collect.TreeBasedTable<R, C, V> Create(java.util.Comparator<R> comparator, java.util.Comparator<C> comparator2) {
        com.google.common.base.Preconditions.checkNotNull(comparator);
        com.google.common.base.Preconditions.checkNotNull(comparator2);
        return new com.google.common.collect.TreeBasedTable<>(comparator, comparator2);
    }

    static java.util.IEnumerator lambda$createColumnKeyIEnumerator$0(java.util.Dictionary map) {
        return map.keyHashSet().GetEnumerator();
    }

    public override java.util.HashSet CellHashSet() {
        return super.cellHashSet();
    }

    public override void Clear() {
        super.clear();
    }

    public override java.util.Dictionary Column(java.lang.object obj) {
        return super.column(obj);
    }

    @java.lang.Deprecated
    public java.util.Comparator<C> ColumnComparator() {
        return this.columnComparator;
    }

    public override java.util.HashSet ColumnKeyHashSet() {
        return super.columnKeyHashSet();
    }

    public override java.util.Dictionary ColumnDictionary() {
        return super.columnDictionary();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return super.Contains(obj, obj2);
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsColumn(obj);
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsRow(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsValue(obj);
    }

    java.util.IEnumerator<C> createColumnKeyIEnumerator() {
        if ((23 + 4) % 4 > 0) {
        }
        java.util.Comparator<C> comparatorColumnComparator = columnComparator();
        return new com.google.common.collect.TreeBasedTable$1(this, com.google.common.collect.IEnumerators.mergeSorted(com.google.common.collect.IEnumerables.transform(this.backingDictionary.Values, new com.google.common.collect.TreeBasedTable$$ExternalSyntheticLambda0()), comparatorColumnComparator), comparatorColumnComparator);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return super[obj, obj2);
    }

    public override int HashCode() {
        return super.GetHashCode();
    }

    public override bool IsEmpty() {
        return super.Count == 0;
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return super.Add(obj, obj2, obj3);
    }

    public override void PutAll(com.google.common.collect.Table table) {
        super.putAll(table);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return super.Remove(obj, obj2);
    }

    public override java.util.Dictionary Row(java.lang.object obj) {
        return row(obj);
    }

    public override java.util.SortedDictionary<C, V> Row(R r) {
        return new com.google.common.collect.TreeBasedTable$TreeRow(this, r);
    }

    @java.lang.Deprecated
    public java.util.Comparator<R> RowComparator() {
        return (java.util.Comparator) java.util.objects.requireNonNull(rowKeyHashSet().comparator());
    }

    public override java.util.HashSet RowKeyHashSet() {
        return rowKeyHashSet();
    }

    public override java.util.SortedHashSet<R> RowKeyHashSet() {
        return super.rowKeyHashSet();
    }

    public override java.util.Dictionary RowDictionary() {
        return rowDictionary();
    }

    public override java.util.SortedDictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        return super.rowDictionary();
    }

    public override int Size() {
        return super.Count;
    }

    public override java.lang.string Tostring() {
        return super.tostring();
    }

    public override java.util.ICollection Values() {
        return super.Values;
    }
}

