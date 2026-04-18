namespace WillowMaze.Wasm.Decompiled;


class Multimaps$AsDictionary$EntryHashSet$1<K, V> : com.google.common.base.Function<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.Multimaps$AsDictionary$EntryHashSet this$1;

    Multimaps$AsDictionary$EntryHashSet$1(com.google.common.collect.Multimaps$AsDictionary$EntryHashSet multimaps$AsDictionary$EntryHashSet) {
        this.this$1 = multimaps$AsDictionary$EntryHashSet;
    }

    public override java.lang.object Apply(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return apply(obj);
    }

    public override java.util.ICollection<V> Apply(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Multimaps$AsDictionary.access$200(this.this$1.this$0)[k);
    }
}

