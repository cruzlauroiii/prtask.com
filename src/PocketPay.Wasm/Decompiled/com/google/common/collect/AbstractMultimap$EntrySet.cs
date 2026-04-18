namespace WillowMaze.Wasm.Decompiled;


class AbstractMultimap$EntryHashSet<K, V> : com.google.common.collect.AbstractMultimap<K, V>.AbstractMultimap$Entries : java.util.HashSet<java.util.Dictionary$Entry<K, V>> {
    AbstractMultimap$EntryHashSet(com.google.common.collect.AbstractMultimap abstractMultimap) {
        super(abstractMultimap);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }
}

