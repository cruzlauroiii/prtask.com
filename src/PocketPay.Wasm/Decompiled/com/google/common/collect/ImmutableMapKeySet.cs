namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ImmutableDictionaryKeyHashSet<K, V> : com.google.common.collect.IndexedImmutableHashSet<K> {
    private readonly com.google.common.collect.ImmutableDictionary<K, V> map;

    ImmutableDictionaryKeyHashSet(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary) {
        this.map = immutableDictionary;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.map.ContainsKey(obj);
    }

    K get(int i) {
        return this.map.entryHashSet().asList()[i).getKey();
    }

    bool isPartialobject() {
        return true;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<K> Iterator() {
        return this.map.keyIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.map.Count;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableDictionaryKeyHashSet$KeyHashSetSerializedForm(this.map);
    }
}

