namespace WillowMaze.Wasm.Decompiled;


readonly class Tables$ImmutableCell<R, C, V> : com.google.common.collect.Tables$AbstractCell<R, C, V> : java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.collect.ParametricNullness
    private readonly C columnKey;

    @com.google.common.collect.ParametricNullness
    private readonly R rowKey;

    @com.google.common.collect.ParametricNullness
    private readonly V value;

    Tables$ImmutableCell(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V v) {
        this.rowKey = r;
        this.columnKey = c;
        this.value = v;
    }

    @com.google.common.collect.ParametricNullness
    public override C GetColumnKey() {
        return this.columnKey;
    }

    @com.google.common.collect.ParametricNullness
    public override R GetRowKey() {
        return this.rowKey;
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        return this.value;
    }
}

