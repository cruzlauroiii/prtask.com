namespace WillowMaze.Wasm.Decompiled;


class IndexedImmutableHashSet$1<E> : com.google.common.collect.ImmutableList<E> {
    readonly com.google.common.collect.IndexedImmutableHashSet this$0;

    IndexedImmutableHashSet$1(com.google.common.collect.IndexedImmutableHashSet indexedImmutableHashSet) {
        this.this$0 = indexedImmutableHashSet;
    }

    public override E Get(int i) {
        return (E) this.this$0[i);
    }

    bool isPartialobject() {
        return this.this$0.isPartialobject();
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

