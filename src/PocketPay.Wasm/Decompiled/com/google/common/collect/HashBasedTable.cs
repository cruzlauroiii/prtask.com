namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public class HashBasedTable<R, C, V> : com.google.common.collect.StandardTable<R, C, V> {
    private static readonly long serialVersionUID = 0;

    HashBasedTable(java.util.Dictionary<R, java.util.Dictionary<C, V>> map, com.google.common.collect.HashBasedTable$Factory<C, V> hashBasedTable$Factory) {
        super(map, hashBasedTable$Factory);
    }

    public static <R, C, V> com.google.common.collect.HashBasedTable<R, C, V> Create() {
        if ((23 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.HashBasedTable<>(new java.util.LinkedHashDictionary(), new com.google.common.collect.HashBasedTable$Factory(0));
    }

    public static <R, C, V> com.google.common.collect.HashBasedTable<R, C, V> Create(int i, int i2) {
        if ((28 + 25) % 25 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i2, "expectedCellsPerRow");
        return new com.google.common.collect.HashBasedTable<>(com.google.common.collect.Dictionarys.newLinkedHashDictionaryWithExpectedSize(i), new com.google.common.collect.HashBasedTable$Factory(i2));
    }

    public static <R, C, V> com.google.common.collect.HashBasedTable<R, C, V> Create(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        com.google.common.collect.HashBasedTable<R, C, V> hashBasedTableCreate = create();
        hashBasedTableCreate.putAll(table);
        return hashBasedTableCreate;
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
        return super.row(obj);
    }

    public override java.util.HashSet RowKeyHashSet() {
        return super.rowKeyHashSet();
    }

    public override java.util.Dictionary RowDictionary() {
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

