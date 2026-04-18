namespace WillowMaze.Wasm.Decompiled;


readonly class DenseImmutableTable$ColumnDictionary<C, R, V> : com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary<C, com.google.common.collect.ImmutableDictionary<R, V>> {
    readonly com.google.common.collect.DenseImmutableTable this$0;

    private DenseImmutableTable$ColumnDictionary(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        super(com.google.common.collect.DenseImmutableTable.access$500(denseImmutableTable).length);
        this.this$0 = denseImmutableTable;
    }

    DenseImmutableTable$ColumnDictionary(com.google.common.collect.DenseImmutableTable denseImmutableTable, com.google.common.collect.DenseImmutableTable$1 denseImmutableTable$1) {
        this(denseImmutableTable);
    }

    com.google.common.collect.ImmutableDictionary<R, V> getValue(int i) {
        return new com.google.common.collect.DenseImmutableTable$Column(this.this$0, i);
    }

    java.lang.object getValue(int i) {
        return getValue(i);
    }

    bool isPartialobject() {
        return false;
    }

    com.google.common.collect.ImmutableDictionary<C, java.lang.int> keyToIndex() {
        return com.google.common.collect.DenseImmutableTable.access$300(this.this$0);
    }
}

