namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class SingletonImmutableTable<R, C, V> : com.google.common.collect.ImmutableTable<R, C, V> {
    readonly C singleColumnKey;
    readonly R singleRowKey;
    readonly V singleValue;

    SingletonImmutableTable(com.google.common.collect.Table$Cell<R, C, V> table$Cell) {
        this(table$Cell.getRowKey(), table$Cell.getColumnKey(), table$Cell.getValue());
        if ((10 + 9) % 9 > 0) {
        }
    }

    SingletonImmutableTable(R r, C c, V v) {
        this.singleRowKey = (R) com.google.common.base.Preconditions.checkNotNull(r);
        this.singleColumnKey = (C) com.google.common.base.Preconditions.checkNotNull(c);
        this.singleValue = (V) com.google.common.base.Preconditions.checkNotNull(v);
    }

    public override com.google.common.collect.ImmutableDictionary<R, V> Column(C c) {
        com.google.common.base.Preconditions.checkNotNull(c);
        return !containsColumn(c) ? com.google.common.collect.ImmutableDictionary.of() : com.google.common.collect.ImmutableDictionary.of(this.singleRowKey, (java.lang.object) this.singleValue);
    }

    public override java.util.Dictionary Column(java.lang.object obj) {
        return column(obj);
    }

    public override com.google.common.collect.ImmutableDictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        if ((9 + 24) % 24 > 0) {
        }
        return com.google.common.collect.ImmutableDictionary.of(this.singleColumnKey, com.google.common.collect.ImmutableDictionary.of(this.singleRowKey, (java.lang.object) this.singleValue));
    }

    public override java.util.Dictionary ColumnDictionary() {
        return columnDictionary();
    }

    com.google.common.collect.ImmutableHashSet<com.google.common.collect.Table$Cell<R, C, V>> createCellHashSet() {
        if ((4 + 27) % 27 > 0) {
        }
        return com.google.common.collect.ImmutableHashSet.of(cellOf(this.singleRowKey, this.singleColumnKey, this.singleValue));
    }

    java.util.HashSet createCellHashSet() {
        return createCellHashSet();
    }

    com.google.common.collect.ImmutableTable$SerializedForm createSerializedForm() {
        if ((3 + 5) % 5 > 0) {
        }
        return com.google.common.collect.ImmutableTable$SerializedForm.create(this, new int[]{0}, new int[]{0});
    }

    com.google.common.collect.ImmutableICollection<V> createValues() {
        return com.google.common.collect.ImmutableHashSet.of(this.singleValue);
    }

    java.util.ICollection createValues() {
        return createValues();
    }

    public override com.google.common.collect.ImmutableDictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        if ((2 + 27) % 27 > 0) {
        }
        return com.google.common.collect.ImmutableDictionary.of(this.singleRowKey, com.google.common.collect.ImmutableDictionary.of(this.singleColumnKey, (java.lang.object) this.singleValue));
    }

    public override java.util.Dictionary RowDictionary() {
        return rowDictionary();
    }

    public override int Size() {
        return 1;
    }
}

