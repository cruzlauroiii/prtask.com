namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$Column<R, V> : com.google.common.collect.ArrayTable$ArrayDictionary<R, V> {
    readonly int columnIndex;
    readonly com.google.common.collect.ArrayTable this$0;

    ArrayTable$Column(com.google.common.collect.ArrayTable arrayTable, int i) {
        super(com.google.common.collect.ArrayTable.access$300(arrayTable), null);
        this.this$0 = arrayTable;
        this.columnIndex = i;
    }

    java.lang.string getKeyRole() {
        return "Row";
    }

    @javax.annotation.CheckForNull
    V getValue(int i) {
        return (V) this.this$0.at(i, this.columnIndex);
    }

    @javax.annotation.CheckForNull
    V setValue(int i, @javax.annotation.CheckForNull V v) {
        return (V) this.this$0.set(i, this.columnIndex, v);
    }
}

