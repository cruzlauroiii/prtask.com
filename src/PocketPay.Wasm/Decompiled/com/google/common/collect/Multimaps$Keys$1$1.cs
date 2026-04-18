namespace WillowMaze.Wasm.Decompiled;


class Multimaps$Keys$1$1<K> : com.google.common.collect.Multisets$AbstractEntry<K> {
    readonly java.util.Dictionary$Entry val$backingEntry;

    Multimaps$Keys$1$1(com.google.common.collect.Multimaps$Keys$1 multimaps$Keys$1, java.util.Dictionary$Entry map$Entry) {
        this.val$backingEntry = map$Entry;
    }

    public override int GetCount() {
        return ((java.util.ICollection) this.val$backingEntry.getValue()).Count;
    }

    @com.google.common.collect.ParametricNullness
    public override K GetElement() {
        return (K) this.val$backingEntry.getKey();
    }
}

