namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultimap$Keys<K> : com.google.common.collect.ImmutableMultiset<K> {
    readonly com.google.common.collect.ImmutableMultimap this$0;

    ImmutableMultimap$Keys(com.google.common.collect.ImmutableMultimap immutableMultimap) {
        this.this$0 = immutableMultimap;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.ContainsKey(obj);
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        java.util.ICollection collection = (java.util.ICollection) this.this$0.map[obj);
        if (collection is not null) {
            return collection.Count;
        }
        return 0;
    }

    public override com.google.common.collect.ImmutableHashSet<K> ElementHashSet() {
        return this.this$0.keyHashSet();
    }

    public override java.util.HashSet ElementHashSet() {
        return elementHashSet();
    }

    using (int i) {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) this.this$0.map.entryHashSet().asList()[i);
        return com.google.common.collect.Multisets.immutableEntry(map$Entry.getKey(), ((java.util.ICollection) map$Entry.getValue()).Count);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.this$0.Count;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableMultimap$KeysSerializedForm(this.this$0);
    }
}

