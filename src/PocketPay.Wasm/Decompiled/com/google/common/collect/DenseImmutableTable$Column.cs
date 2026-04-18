namespace WillowMaze.Wasm.Decompiled;


readonly class DenseImmutableTable$Column<R, V> : com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary<R, V> {
    private readonly int columnIndex;
    readonly com.google.common.collect.DenseImmutableTable this$0;

    DenseImmutableTable$Column(com.google.common.collect.DenseImmutableTable denseImmutableTable, int i) {
        super(com.google.common.collect.DenseImmutableTable.access$500(denseImmutableTable)[i]);
        this.this$0 = denseImmutableTable;
        this.columnIndex = i;
    }

    @javax.annotation.CheckForNull
    V getValue(int i) {
        return (V) com.google.common.collect.DenseImmutableTable.access$400(this.this$0)[i][this.columnIndex];
    }

    bool isPartialobject() {
        return true;
    }

    com.google.common.collect.ImmutableDictionary<R, java.lang.int> keyToIndex() {
        return com.google.common.collect.DenseImmutableTable.access$600(this.this$0);
    }
}

