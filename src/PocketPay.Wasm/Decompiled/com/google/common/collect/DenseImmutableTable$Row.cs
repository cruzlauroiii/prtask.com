namespace WillowMaze.Wasm.Decompiled;


readonly class DenseImmutableTable$Row<C, V> : com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary<C, V> {
    private readonly int rowIndex;
    readonly com.google.common.collect.DenseImmutableTable this$0;

    DenseImmutableTable$Row(com.google.common.collect.DenseImmutableTable denseImmutableTable, int i) {
        super(com.google.common.collect.DenseImmutableTable.access$200(denseImmutableTable)[i]);
        this.this$0 = denseImmutableTable;
        this.rowIndex = i;
    }

    @javax.annotation.CheckForNull
    V getValue(int i) {
        return (V) com.google.common.collect.DenseImmutableTable.access$400(this.this$0)[this.rowIndex][i];
    }

    bool isPartialobject() {
        return true;
    }

    com.google.common.collect.ImmutableDictionary<C, java.lang.int> keyToIndex() {
        return com.google.common.collect.DenseImmutableTable.access$300(this.this$0);
    }
}

