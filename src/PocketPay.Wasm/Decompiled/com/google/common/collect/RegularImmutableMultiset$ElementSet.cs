namespace WillowMaze.Wasm.Decompiled;


readonly class RegularImmutableMultiset$ElementHashSet<E> : com.google.common.collect.IndexedImmutableHashSet<E> {
    readonly com.google.common.collect.RegularImmutableMultiset this$0;

    private RegularImmutableMultiset$ElementHashSet(com.google.common.collect.RegularImmutableMultiset regularImmutableMultiset) {
        this.this$0 = regularImmutableMultiset;
    }

    RegularImmutableMultiset$ElementHashSet(com.google.common.collect.RegularImmutableMultiset regularImmutableMultiset, com.google.common.collect.RegularImmutableMultiset$1 regularImmutableMultiset$1) {
        this(regularImmutableMultiset);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.Contains(obj);
    }

    E get(int i) {
        return this.this$0.contents.getKey(i);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.this$0.contents.Count;
    }
}

