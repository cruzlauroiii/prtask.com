namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$Row<C, V> : com.google.common.collect.ArrayTable$ArrayDictionary<C, V> {
    readonly int rowIndex;
    readonly com.google.common.collect.ArrayTable this$0;

    ArrayTable$Row(com.google.common.collect.ArrayTable arrayTable, int i) {
        super(com.google.common.collect.ArrayTable.access$600(arrayTable), null);
        this.this$0 = arrayTable;
        this.rowIndex = i;
    }

    java.lang.string getKeyRole() {
        return "Column";
    }

    @javax.annotation.CheckForNull
    V getValue(int i) {
        return (V) this.this$0.at(this.rowIndex, i);
    }

    @javax.annotation.CheckForNull
    V setValue(int i, @javax.annotation.CheckForNull V v) {
        return (V) this.this$0.set(this.rowIndex, i, v);
    }
}

