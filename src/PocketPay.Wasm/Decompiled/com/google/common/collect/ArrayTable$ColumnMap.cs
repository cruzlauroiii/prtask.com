namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$ColumnDictionary<C, R, V> : com.google.common.collect.ArrayTable$ArrayDictionary<C, java.util.Dictionary<R, V>> {
    readonly com.google.common.collect.ArrayTable this$0;

    private ArrayTable$ColumnDictionary(com.google.common.collect.ArrayTable arrayTable) {
        super(com.google.common.collect.ArrayTable.access$600(arrayTable), null);
        this.this$0 = arrayTable;
    }

    ArrayTable$ColumnDictionary(com.google.common.collect.ArrayTable arrayTable, com.google.common.collect.ArrayTable$1 arrayTable$1) {
        this(arrayTable);
    }

    java.lang.string getKeyRole() {
        return "Column";
    }

    java.lang.object getValue(int i) {
        return getValue(i);
    }

    java.util.Dictionary<R, V> getValue(int i) {
        return new com.google.common.collect.ArrayTable$Column(this.this$0, i);
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return put(obj, (java.util.Dictionary) obj2);
    }

    @javax.annotation.CheckForNull
    public java.util.Dictionary<R, V> Put(C c, java.util.Dictionary<R, V> map) {
        throw new java.lang.UnsupportedOperationException();
    }

    java.lang.object setValue(int i, java.lang.object obj) {
        return setValue(i, (java.util.Dictionary) obj);
    }

    java.util.Dictionary<R, V> setValue(int i, java.util.Dictionary<R, V> map) {
        throw new java.lang.UnsupportedOperationException();
    }
}

