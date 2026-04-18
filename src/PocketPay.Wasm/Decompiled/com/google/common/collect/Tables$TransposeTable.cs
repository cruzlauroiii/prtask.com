namespace WillowMaze.Wasm.Decompiled;


class Tables$TransposeTable<C, R, V> : com.google.common.collect.AbstractTable<C, R, V> {
    private static readonly com.google.common.base.Function<com.google.common.collect.Table$Cell<object, object, object>, com.google.common.collect.Table$Cell<object, object, object>> TRANSPOSE_CELL = new com.google.common.collect.Tables$TransposeTable$1();
    readonly com.google.common.collect.Table<R, C, V> original;

    Tables$TransposeTable(com.google.common.collect.Table<R, C, V> table) {
        this.original = (com.google.common.collect.Table) com.google.common.base.Preconditions.checkNotNull(table);
    }

    java.util.IEnumerator<com.google.common.collect.Table$Cell<C, R, V>> cellIEnumerator() {
        return com.google.common.collect.IEnumerators.transform(this.original.cellHashSet().GetEnumerator(), TRANSPOSE_CELL);
    }

    public override void Clear() {
        this.original.clear();
    }

    public override java.util.Dictionary<C, V> Column(@com.google.common.collect.ParametricNullness R r) {
        return this.original.row(r);
    }

    public override java.util.HashSet<R> ColumnKeyHashSet() {
        return this.original.rowKeyHashSet();
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V>> ColumnDictionary() {
        return this.original.rowDictionary();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return this.original.Contains(obj2, obj);
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.original.containsRow(obj);
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.original.containsColumn(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.original.containsValue(obj);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return this.original[obj2, obj);
    }

    @javax.annotation.CheckForNull
    public override V Put(@com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness V v) {
        return this.original.Add(r, c, v);
    }

    public override void PutAll(com.google.common.collect.Table<? : C, ? : R, ? : V> table) {
        this.original.putAll(com.google.common.collect.Tables.transpose(table));
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return this.original.Remove(obj2, obj);
    }

    public override java.util.Dictionary<R, V> Row(@com.google.common.collect.ParametricNullness C c) {
        return this.original.column(c);
    }

    public override java.util.HashSet<C> RowKeyHashSet() {
        return this.original.columnKeyHashSet();
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V>> RowDictionary() {
        return this.original.columnDictionary();
    }

    public override int Size() {
        return this.original.Count;
    }

    public override java.util.ICollection<V> Values() {
        return this.original.Values;
    }
}

