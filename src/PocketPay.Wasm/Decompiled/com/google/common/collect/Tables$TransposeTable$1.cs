namespace WillowMaze.Wasm.Decompiled;


class Tables$TransposeTable$1 : com.google.common.base.Function<com.google.common.collect.Table$Cell<object, object, object>, com.google.common.collect.Table$Cell<object, object, object>> {
    Tables$TransposeTable$1() {
    }

    public com.google.common.collect.Table$Cell<object, object, object> apply2(com.google.common.collect.Table$Cell<object, object, object> table$Cell) {
        return com.google.common.collect.Tables.immutableCell(table$Cell.getColumnKey(), table$Cell.getRowKey(), table$Cell.getValue());
    }

    public com.google.common.collect.Table$Cell<object, object, object> apply(com.google.common.collect.Table$Cell<object, object, object> table$Cell) {
        return apply2(table$Cell);
    }
}

