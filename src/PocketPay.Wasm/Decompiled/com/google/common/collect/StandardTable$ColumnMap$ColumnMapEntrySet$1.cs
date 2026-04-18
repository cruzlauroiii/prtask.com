namespace WillowMaze.Wasm.Decompiled;


class StandardTable$ColumnDictionary$ColumnDictionaryEntryHashSet$1<C, R, V> : com.google.common.base.Function<C, java.util.Dictionary<R, V>> {
    readonly com.google.common.collect.StandardTable$ColumnDictionary$ColumnDictionaryEntryHashSet this$2;

    StandardTable$ColumnDictionary$ColumnDictionaryEntryHashSet$1(com.google.common.collect.StandardTable$ColumnDictionary$ColumnDictionaryEntryHashSet standardTable$ColumnDictionary$ColumnDictionaryEntryHashSet) {
        this.this$2 = standardTable$ColumnDictionary$ColumnDictionaryEntryHashSet;
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply(obj);
    }

    public override java.util.Dictionary<R, V> Apply(C c) {
        return this.this$2.this$1.this$0.column(c);
    }
}

