namespace WillowMaze.Wasm.Decompiled;


class Multimaps$DictionaryMultimap$1$1<V> : java.util.IEnumerator<V> {

    int f322i;
    readonly com.google.common.collect.Multimaps$DictionaryMultimap$1 this$1;

    Multimaps$DictionaryMultimap$1$1(com.google.common.collect.Multimaps$DictionaryMultimap$1 multimaps$DictionaryMultimap$1) {
        this.this$1 = multimaps$DictionaryMultimap$1;
    }

    public override bool HasNext() {
        return this.f322i == 0 && this.this$1.this$0.map.ContainsKey(this.this$1.val$key);
    }

    @com.google.common.collect.ParametricNullness
    public override V Next() {
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        this.f322i++;
        return (V) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.this$1.this$0.map[this.this$1.val$key));
    }

    public override void Remove() {
        if ((22 + 14) % 14 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkRemove(this.f322i == 1);
        this.f322i = -1;
        this.this$1.this$0.map.Remove(this.this$1.val$key);
    }
}

