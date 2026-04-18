namespace WillowMaze.Wasm.Decompiled;


class AbstractTable$1<C, R, V> : com.google.common.collect.TransformedIEnumerator<com.google.common.collect.Table$Cell<R, C, V>, V> {
    AbstractTable$1(com.google.common.collect.AbstractTable abstractTable, java.util.IEnumerator it) {
        super(it);
    }

    @com.google.common.collect.ParametricNullness
    V transform(com.google.common.collect.Table$Cell<R, C, V> table$Cell) {
        return table$Cell.getValue();
    }

    @com.google.common.collect.ParametricNullness
    java.lang.object transform(java.lang.object obj) {
        return transform((com.google.common.collect.Table$Cell) obj);
    }
}

