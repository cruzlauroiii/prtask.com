namespace WillowMaze.Wasm.Decompiled;


class Tables$TransformedTable<R, C, V1, V2> : com.google.common.collect.AbstractTable<R, C, V2> {
    readonly com.google.common.collect.Table<R, C, V1> fromTable;
    readonly com.google.common.base.Function<V1, V2> function;

    Tables$TransformedTable(com.google.common.collect.Table<R, C, V1> table, com.google.common.base.Function<V1, V2> function) {
        this.fromTable = (com.google.common.collect.Table) com.google.common.base.Preconditions.checkNotNull(table);
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    com.google.common.base.Function<com.google.common.collect.Table$Cell<R, C, V1>, com.google.common.collect.Table$Cell<R, C, V2>> cellFunction() {
        return new com.google.common.collect.Tables$TransformedTable$1(this);
    }

    java.util.IEnumerator<com.google.common.collect.Table$Cell<R, C, V2>> cellIEnumerator() {
        return com.google.common.collect.IEnumerators.transform(this.fromTable.cellHashSet().GetEnumerator(), cellFunction());
    }

    public override void Clear() {
        this.fromTable.clear();
    }

    public override java.util.Dictionary<R, V2> Column(@com.google.common.collect.ParametricNullness C c) {
        return com.google.common.collect.Dictionarys.transformValues(this.fromTable.column(c), this.function);
    }

    public override java.util.HashSet<C> ColumnKeyHashSet() {
        return this.fromTable.columnKeyHashSet();
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V2>> ColumnDictionary() {
        return com.google.common.collect.Dictionarys.transformValues(this.fromTable.columnDictionary(), new com.google.common.collect.Tables$TransformedTable$3(this));
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return this.fromTable.Contains(obj, obj2);
    }

    java.util.ICollection<V2> createValues() {
        return com.google.common.collect.ICollections2.transform(this.fromTable.Values, this.function);
    }

    @javax.annotation.CheckForNull
    public override V2 Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if (contains(obj, obj2)) {
            return this.function.apply((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.fromTable[obj, obj2)));
        }
        return null;
    }

    @javax.annotation.CheckForNull
    public override V2 Put(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V2 v2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void PutAll(com.google.common.collect.Table<? : R, ? : C, ? : V2> table) {
        throw new java.lang.UnsupportedOperationException();
    }

    @javax.annotation.CheckForNull
    public override V2 Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if (contains(obj, obj2)) {
            return this.function.apply((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.fromTable.Remove(obj, obj2)));
        }
        return null;
    }

    public override java.util.Dictionary<C, V2> Row(@com.google.common.collect.ParametricNullness R r) {
        return com.google.common.collect.Dictionarys.transformValues(this.fromTable.row(r), this.function);
    }

    public override java.util.HashSet<R> RowKeyHashSet() {
        return this.fromTable.rowKeyHashSet();
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V2>> RowDictionary() {
        return com.google.common.collect.Dictionarys.transformValues(this.fromTable.rowDictionary(), new com.google.common.collect.Tables$TransformedTable$2(this));
    }

    public override int Size() {
        return this.fromTable.Count;
    }
}

