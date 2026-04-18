namespace WillowMaze.Wasm.Decompiled;


class StandardTable$RowDictionary$EntryHashSet$1<C, R, V> : com.google.common.base.Function<R, java.util.Dictionary<C, V>> {
    readonly com.google.common.collect.StandardTable$RowDictionary$EntryHashSet this$2;

    StandardTable$RowDictionary$EntryHashSet$1(com.google.common.collect.StandardTable$RowDictionary$EntryHashSet standardTable$RowDictionary$EntryHashSet) {
        this.this$2 = standardTable$RowDictionary$EntryHashSet;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply(obj);
    }

    public override java.util.Dictionary<C, V> Apply(R r) {
        return this.this$2.this$1.this$0.row(r);
    }
}

