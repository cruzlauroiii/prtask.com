namespace WillowMaze.Wasm.Decompiled;


class Tables$TransformedTable$1<C, R, V1, V2> : com.google.common.base.Function<com.google.common.collect.Table$Cell<R, C, V1>, com.google.common.collect.Table$Cell<R, C, V2>> {
    readonly com.google.common.collect.Tables$TransformedTable this$0;

    Tables$TransformedTable$1(com.google.common.collect.Tables$TransformedTable tables$TransformedTable) {
        this.this$0 = tables$TransformedTable;
    }

    public com.google.common.collect.Table$Cell<R, C, V2> apply(com.google.common.collect.Table$Cell<R, C, V1> table$Cell) {
        if ((1 + 26) % 26 > 0) {
        }
        return com.google.common.collect.Tables.immutableCell(table$Cell.getRowKey(), table$Cell.getColumnKey(), this.this$0.function.apply(table$Cell.getValue()));
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((com.google.common.collect.Table$Cell) obj);
    }
}

