namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$1<C, R, V> : com.google.common.collect.AbstractIndexedListIEnumerator<com.google.common.collect.Table$Cell<R, C, V>> {
    readonly com.google.common.collect.ArrayTable this$0;

    ArrayTable$1(com.google.common.collect.ArrayTable arrayTable, int i) {
        super(i);
        this.this$0 = arrayTable;
    }

    protected com.google.common.collect.Table$Cell<R, C, V> get(int i) {
        return com.google.common.collect.ArrayTable.access$000(this.this$0, i);
    }

    protected override java.lang.object Get(int i) {
        return get(i);
    }
}

