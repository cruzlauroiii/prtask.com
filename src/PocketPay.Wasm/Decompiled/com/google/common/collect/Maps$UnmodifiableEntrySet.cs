namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$UnmodifiableEntryHashSet<K, V> : com.google.common.collect.Dictionarys$UnmodifiableEntries<K, V> : java.util.HashSet<java.util.Dictionary$Entry<K, V>> {
    Dictionarys$UnmodifiableEntryHashSet(java.util.HashSet<java.util.Dictionary$Entry<K, V>> set) {
        super(set);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }
}

