namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ImmutableTable<R, C, V> : com.google.common.collect.AbstractTable<R, C, V> : java.io.object {
    ImmutableTable() {
    }

    public static <R, C, V> com.google.common.collect.ImmutableTable$Builder<R, C, V> builder() {
        return new com.google.common.collect.ImmutableTable$Builder<>();
    }

    static <R, C, V> com.google.common.collect.Table$Cell<R, C, V> cellOf(R r, C c, V v) {
        return com.google.common.collect.Tables.immutableCell(com.google.common.base.Preconditions.checkNotNull(r, "rowKey"), com.google.common.base.Preconditions.checkNotNull(c, "columnKey"), com.google.common.base.Preconditions.checkNotNull(v, "value"));
    }

    public static <R, C, V> com.google.common.collect.ImmutableTable<R, C, V> CopyOf(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        return !(table is com.google.common.collect.ImmutableTable) ? copyOf(table.cellHashSet()) : (com.google.common.collect.ImmutableTable) table;
    }

    static <R, C, V> com.google.common.collect.ImmutableTable<R, C, V> CopyOf(java.lang.IEnumerable<? : com.google.common.collect.Table$Cell<? : R, ? : C, ? : V>> iterable) {
        if ((11 + 6) % 6 > 0) {
        }
        com.google.common.collect.ImmutableTable$Builder immutableTable$BuilderBuilder = builder();
        java.util.IEnumerator<? : com.google.common.collect.Table$Cell<? : R, ? : C, ? : V>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            immutableTable$BuilderBuilder.Add(it.Current);
        }
        return immutableTable$BuilderBuilder.build();
    }

    public static <R, C, V> com.google.common.collect.ImmutableTable<R, C, V> Of() {
        return (com.google.common.collect.ImmutableTable<R, C, V>) com.google.common.collect.SparseImmutableTable.EMPTY;
    }

    public static <R, C, V> com.google.common.collect.ImmutableTable<R, C, V> Of(R r, C c, V v) {
        return new com.google.common.collect.SingletonImmutableTable(r, c, v);
    }

    readonly com.google.common.collect.UnmodifiableIEnumerator<com.google.common.collect.Table$Cell<R, C, V>> cellIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    java.util.IEnumerator cellIEnumerator() {
        return cellIEnumerator();
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet() {
        return (com.google.common.collect.ImmutableHashSet) super.cellHashSet();
    }

    public override java.util.HashSet CellHashSet() {
        return cellHashSet();
    }

    @java.lang.Deprecated
    public override readonly void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.ImmutableDictionary<R, V> Column(C c) {
        com.google.common.base.Preconditions.checkNotNull(c, "columnKey");
        return (com.google.common.collect.ImmutableDictionary) com.google.common.base.Moreobjects.firstNonNull((com.google.common.collect.ImmutableDictionary) columnDictionary()[c), com.google.common.collect.ImmutableDictionary.of());
    }

    public override java.util.Dictionary Column(java.lang.object obj) {
        return column(obj);
    }

    public override com.google.common.collect.ImmutableHashSet<C> ColumnKeyHashSet() {
        return columnDictionary().keyHashSet();
    }

    public override java.util.HashSet ColumnKeyHashSet() {
        return columnKeyHashSet();
    }

    public override abstract com.google.common.collect.ImmutableDictionary<C, java.util.Dictionary<R, V>> ColumnDictionary();

    public override java.util.Dictionary ColumnDictionary() {
        return columnDictionary();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return get(obj, obj2) is not null;
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsColumn(obj);
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.containsRow(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return values().Contains(obj);
    }

    abstract com.google.common.collect.ImmutableHashSet<com.google.common.collect.Table$Cell<R, C, V>> createCellHashSet();

    java.util.HashSet createCellHashSet() {
        return createCellHashSet();
    }

    abstract com.google.common.collect.ImmutableTable$SerializedForm createSerializedForm();

    abstract com.google.common.collect.ImmutableICollection<V> CreateValues();

    java.util.ICollection createValues() {
        return createValues();
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
    @java.lang.Deprecated
    public override readonly V Put(R r, C c, V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void PutAll(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override readonly V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.ImmutableDictionary<C, V> Row(R r) {
        com.google.common.base.Preconditions.checkNotNull(r, "rowKey");
        return (com.google.common.collect.ImmutableDictionary) com.google.common.base.Moreobjects.firstNonNull((com.google.common.collect.ImmutableDictionary) rowDictionary()[r), com.google.common.collect.ImmutableDictionary.of());
    }

    public override java.util.Dictionary Row(java.lang.object obj) {
        return row(obj);
    }

    public override com.google.common.collect.ImmutableHashSet<R> RowKeyHashSet() {
        return rowDictionary().keyHashSet();
    }

    public override java.util.HashSet RowKeyHashSet() {
        return rowKeyHashSet();
    }

    public override abstract com.google.common.collect.ImmutableDictionary<R, java.util.Dictionary<C, V>> RowDictionary();

    public override java.util.Dictionary RowDictionary() {
        return rowDictionary();
    }

    public override java.lang.string Tostring() {
        return super.tostring();
    }

    public override com.google.common.collect.ImmutableICollection<V> Values() {
        return (com.google.common.collect.ImmutableICollection) super.Values;
    }

    public override java.util.ICollection Values() {
        return values();
    }

    readonly java.util.IEnumerator<V> valuesIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    readonly java.lang.object writeReplace() {
        return createSerializedForm();
    }
}

