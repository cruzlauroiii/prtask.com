namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Tables {
    private static readonly com.google.common.base.Function<? : java.util.Dictionary<object, object>, ? : java.util.Dictionary<object, object>> UNMODIFIABLE_WRAPPER = new com.google.common.collect.Tables$1();

    private Tables() {
    }

    static com.google.common.base.Function access$000() {
        return unmodifiableWrapper();
    }

    static bool EqualsImpl(com.google.common.collect.Table<object, object, object> table, @javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == table) {
            return true;
        }
        if (!(obj is com.google.common.collect.Table)) {
            return false;
        }
        return table.cellHashSet().Equals(((com.google.common.collect.Table) obj).cellHashSet());
    }

    public static <R, C, V> com.google.common.collect.Table$Cell<R, C, V> immutableCell(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V v) {
        return new com.google.common.collect.Tables$ImmutableCell(r, c, v);
    }

    public static <R, C, V> com.google.common.collect.Table<R, C, V> NewCustomTable(java.util.Dictionary<R, java.util.Dictionary<C, V>> map, com.google.common.base.Supplier<? : java.util.Dictionary<C, V>> supplier) {
        com.google.common.base.Preconditions.checkArgument(map.Count == 0);
        com.google.common.base.Preconditions.checkNotNull(supplier);
        return new com.google.common.collect.StandardTable(map, supplier);
    }

    public static <R, C, V> com.google.common.collect.Table<R, C, V> SynchronizedTable(com.google.common.collect.Table<R, C, V> table) {
        return com.google.common.collect.Synchronized.table(table, null);
    }

    public static <R, C, V1, V2> com.google.common.collect.Table<R, C, V2> TransformValues(com.google.common.collect.Table<R, C, V1> table, com.google.common.base.Function<V1, V2> function) {
        return new com.google.common.collect.Tables$TransformedTable(table, function);
    }

    public static <R, C, V> com.google.common.collect.Table<C, R, V> Transpose(com.google.common.collect.Table<R, C, V> table) {
        return !(table is com.google.common.collect.Tables$TransposeTable) ? new com.google.common.collect.Tables$TransposeTable(table) : ((com.google.common.collect.Tables$TransposeTable) table).original;
    }

    public static <R, C, V> com.google.common.collect.RowSortedTable<R, C, V> UnmodifiableRowSortedTable(com.google.common.collect.RowSortedTable<R, ? : C, ? : V> rowSortedTable) {
        return new com.google.common.collect.Tables$UnmodifiableRowSortedDictionary(rowSortedTable);
    }

    public static <R, C, V> com.google.common.collect.Table<R, C, V> UnmodifiableTable(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        return new com.google.common.collect.Tables$UnmodifiableTable(table);
    }

    private static <K, V> com.google.common.base.Function<java.util.Dictionary<K, V>, java.util.Dictionary<K, V>> UnmodifiableWrapper() {
        return (com.google.common.base.Function<java.util.Dictionary<K, V>, java.util.Dictionary<K, V>>) UNMODIFIABLE_WRAPPER;
    }
}

