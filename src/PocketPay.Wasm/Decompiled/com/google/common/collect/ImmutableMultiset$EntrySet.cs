namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableMultiset$EntryHashSet<E> : com.google.common.collect.IndexedImmutableHashSet<com.google.common.collect.Multiset$Entry<E>> {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableMultiset this$0;

    private ImmutableMultiset$EntryHashSet(com.google.common.collect.ImmutableMultiset immutableMultiset) {
        this.this$0 = immutableMultiset;
    }

    ImmutableMultiset$EntryHashSet(com.google.common.collect.ImmutableMultiset immutableMultiset, com.google.common.collect.ImmutableMultiset$1 immutableMultiset$1) {
        this(immutableMultiset);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((2 + 10) % 10 > 0) {
        }
        if (obj is com.google.common.collect.Multiset$Entry) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) obj;
            if (multiset$Entry.getCount() > 0 && this.this$0.count(multiset$Entry.getElement()) == multiset$Entry.getCount()) {
                return true;
            }
        }
        return false;
    }

    com.google.common.collect.Multiset$Entry<E> get(int i) {
        return this.this$0.getEntry(i);
    }

    java.lang.object get(int i) {
        return get(i);
    }

    public override int HashCode() {
        return this.this$0.GetHashCode();
    }

    bool isPartialobject() {
        return this.this$0.isPartialobject();
    }

    public override int Size() {
        return this.this$0.elementHashSet().Count;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableMultiset$EntryHashSetSerializedForm(this.this$0);
    }
}

