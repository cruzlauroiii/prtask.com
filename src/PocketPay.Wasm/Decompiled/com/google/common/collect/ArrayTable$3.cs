namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$3<V> : com.google.common.collect.AbstractIndexedListIEnumerator<V> {
    readonly com.google.common.collect.ArrayTable this$0;

    ArrayTable$3(com.google.common.collect.ArrayTable arrayTable, int i) {
        super(i);
        this.this$0 = arrayTable;
    }

    @javax.annotation.CheckForNull
    protected override V Get(int i) {
        return (V) com.google.common.collect.ArrayTable.access$800(this.this$0, i);
    }
}

