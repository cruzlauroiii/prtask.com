namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultimap$EntryICollection<K, V> : com.google.common.collect.ImmutableICollection<java.util.Dictionary$Entry<K, V>> {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableMultimap<K, V> multimap;

    ImmutableMultimap$EntryICollection(com.google.common.collect.ImmutableMultimap<K, V> immutableMultimap) {
        this.multimap = immutableMultimap;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return this.multimap.containsEntry(map$Entry.getKey(), map$Entry.getValue());
    }

    bool isPartialobject() {
        return this.multimap.isPartialobject();
    }

    public com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.multimap.entryIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.multimap.Count;
    }
}

