namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Column$Values<R, V> : com.google.common.collect.Dictionarys$Values<R, V> {
    readonly com.google.common.collect.StandardTable$Column this$1;

    StandardTable$Column$Values(com.google.common.collect.StandardTable$Column standardTable$Column) {
        super(standardTable$Column);
        this.this$1 = standardTable$Column;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null && this.this$1.removeFromColumnIf(com.google.common.collect.Dictionarys.valuePredicateOnEntries(com.google.common.base.Predicates.equalTo(obj)));
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return this.this$1.removeFromColumnIf(com.google.common.collect.Dictionarys.valuePredicateOnEntries(com.google.common.base.Predicates.in(collection)));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return this.this$1.removeFromColumnIf(com.google.common.collect.Dictionarys.valuePredicateOnEntries(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection))));
    }
}

