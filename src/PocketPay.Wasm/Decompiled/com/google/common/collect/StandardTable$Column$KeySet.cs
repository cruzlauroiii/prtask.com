namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Column$KeyHashSet<R, V> : com.google.common.collect.Dictionarys$KeyHashSet<R, V> {
    readonly com.google.common.collect.StandardTable$Column this$1;

    StandardTable$Column$KeyHashSet(com.google.common.collect.StandardTable$Column standardTable$Column) {
        super(standardTable$Column);
        this.this$1 = standardTable$Column;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$1.this$0.Contains(obj, this.this$1.columnKey);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$1.this$0.Remove(obj, this.this$1.columnKey) is not null;
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return this.this$1.removeFromColumnIf(com.google.common.collect.Dictionarys.keyPredicateOnEntries(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection))));
    }
}

