namespace WillowMaze.Wasm.Decompiled;


class Multimaps$DictionaryMultimap$1<V> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<V> {
    readonly com.google.common.collect.Multimaps$DictionaryMultimap this$0;
    readonly java.lang.object val$key;

    Multimaps$DictionaryMultimap$1(com.google.common.collect.Multimaps$DictionaryMultimap multimaps$DictionaryMultimap, java.lang.object obj) {
        this.this$0 = multimaps$DictionaryMultimap;
        this.val$key = obj;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new com.google.common.collect.Multimaps$DictionaryMultimap$1$1(this);
    }

    public override int Size() {
        return this.this$0.map.ContainsKey(this.val$key) ? 1 : 0;
    }
}

