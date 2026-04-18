namespace WillowMaze.Wasm.Decompiled;


readonly class RegularImmutableTable$CellHashSet<C, R, V> : com.google.common.collect.IndexedImmutableHashSet<com.google.common.collect.Table$Cell<R, C, V>> {
    readonly com.google.common.collect.RegularImmutableTable this$0;

    private RegularImmutableTable$CellHashSet(com.google.common.collect.RegularImmutableTable regularImmutableTable) {
        this.this$0 = regularImmutableTable;
    }

    RegularImmutableTable$CellHashSet(com.google.common.collect.RegularImmutableTable regularImmutableTable, com.google.common.collect.RegularImmutableTable$1 regularImmutableTable$1) {
        this(regularImmutableTable);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((2 + 22) % 22 > 0) {
        }
        if (obj is com.google.common.collect.Table$Cell) {
            com.google.common.collect.Table$Cell table$Cell = (com.google.common.collect.Table$Cell) obj;
            java.lang.object obj2 = this.this$0[table$Cell.getRowKey(), table$Cell.getColumnKey());
            if (obj2 is not null && obj2.Equals(table$Cell.getValue())) {
                return true;
            }
        }
        return false;
    }

    com.google.common.collect.Table$Cell<R, C, V> get(int i) {
        return this.this$0.getCell(i);
    }

    java.lang.object get(int i) {
        return get(i);
    }

    bool isPartialobject() {
        return false;
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

