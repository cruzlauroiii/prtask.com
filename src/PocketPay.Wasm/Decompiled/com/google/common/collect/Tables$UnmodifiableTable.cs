namespace WillowMaze.Wasm.Decompiled;


class Tables$UnmodifiableTable<R, C, V> : com.google.common.collect.ForwardingTable<R, C, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Table<? : R, ? : C, ? : V> delegate;

    Tables$UnmodifiableTable(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        this.delegate = (com.google.common.collect.Table) com.google.common.base.Preconditions.checkNotNull(table);
    }

    public java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet() {
        return java.util.ICollections.unmodifiableHashSet(super.cellHashSet());
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.Dictionary<R, V> Column(@com.google.common.collect.ParametricNullness C c) {
        return java.util.ICollections.unmodifiableDictionary(super.column(c));
    }

    public override java.util.HashSet<C> ColumnKeyHashSet() {
        return java.util.ICollections.unmodifiableHashSet(super.columnKeyHashSet());
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        return java.util.ICollections.unmodifiableDictionary(com.google.common.collect.Dictionarys.transformValues(super.columnDictionary(), com.google.common.collect.Tables.access$000()));
    }

    protected override com.google.common.collect.Table<R, C, V> Delegate() {
        return this.delegate;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    @javax.annotation.CheckForNull
    public override V Put(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void PutAll(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.Dictionary<C, V> Row(@com.google.common.collect.ParametricNullness R r) {
        return java.util.ICollections.unmodifiableDictionary(super.row(r));
    }

    public override java.util.HashSet<R> RowKeyHashSet() {
        return java.util.ICollections.unmodifiableHashSet(super.rowKeyHashSet());
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        return java.util.ICollections.unmodifiableDictionary(com.google.common.collect.Dictionarys.transformValues(super.rowDictionary(), com.google.common.collect.Tables.access$000()));
    }

    public override java.util.ICollection<V> Values() {
        return java.util.ICollections.unmodifiableICollection(super.Values);
    }
}

