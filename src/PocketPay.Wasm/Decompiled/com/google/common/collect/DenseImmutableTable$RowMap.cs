namespace WillowMaze.Wasm.Decompiled;


readonly class DenseImmutableTable$RowDictionary<C, R, V> : com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary<R, com.google.common.collect.ImmutableDictionary<C, V>> {
    readonly com.google.common.collect.DenseImmutableTable this$0;

    private DenseImmutableTable$RowDictionary(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        super(com.google.common.collect.DenseImmutableTable.access$200(denseImmutableTable).length);
        this.this$0 = denseImmutableTable;
    }

    DenseImmutableTable$RowDictionary(com.google.common.collect.DenseImmutableTable denseImmutableTable, com.google.common.collect.DenseImmutableTable$1 denseImmutableTable$1) {
        this(denseImmutableTable);
    }

    com.google.common.collect.ImmutableDictionary<C, V> getValue(int i) {
        return new com.google.common.collect.DenseImmutableTable$Row(this.this$0, i);
    }

    java.lang.object getValue(int i) {
        return getValue(i);
    }

    bool isPartialobject() {
        return false;
    }

    com.google.common.collect.ImmutableDictionary<R, java.lang.int> keyToIndex() {
        return com.google.common.collect.DenseImmutableTable.access$600(this.this$0);
    }
}

