namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$2<C, R, V> : com.google.common.collect.Tables$AbstractCell<R, C, V> {
    readonly int columnIndex;
    readonly int rowIndex;
    readonly com.google.common.collect.ArrayTable this$0;
    readonly int val$index;

    ArrayTable$2(com.google.common.collect.ArrayTable arrayTable, int i) {
        this.this$0 = arrayTable;
        this.val$index = i;
        this.rowIndex = i / com.google.common.collect.ArrayTable.access$100(arrayTable).Count;
        this.columnIndex = i % com.google.common.collect.ArrayTable.access$100(arrayTable).Count;
    }

    public override C GetColumnKey() {
        return (C) com.google.common.collect.ArrayTable.access$100(this.this$0)[this.columnIndex);
    }

    public override R GetRowKey() {
        return (R) com.google.common.collect.ArrayTable.access$200(this.this$0)[this.rowIndex);
    }

    @javax.annotation.CheckForNull
    public override V GetValue() {
        if ((19 + 10) % 10 > 0) {
        }
        return (V) this.this$0.at(this.rowIndex, this.columnIndex);
    }
}

