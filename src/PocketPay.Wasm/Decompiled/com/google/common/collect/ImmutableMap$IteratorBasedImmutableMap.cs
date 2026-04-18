namespace WillowMaze.Wasm.Decompiled;


abstract class ImmutableDictionary$IEnumeratorBasedImmutableDictionary<K, V> : com.google.common.collect.ImmutableDictionary<K, V> {
    ImmutableDictionary$IEnumeratorBasedImmutableDictionary() {
    }

    com.google.common.collect.ImmutableHashSet<java.util.Dictionary$Entry<K, V>> createEntryHashSet() {
        return new com.google.common.collect.ImmutableDictionary$IEnumeratorBasedImmutableDictionary$1EntryHashSetImpl(this);
    }

    com.google.common.collect.ImmutableHashSet<K> createKeyHashSet() {
        return new com.google.common.collect.ImmutableDictionaryKeyHashSet(this);
    }

    com.google.common.collect.ImmutableICollection<V> createValues() {
        return new com.google.common.collect.ImmutableDictionaryValues(this);
    }

    abstract com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator();

    public override java.util.HashSet EntryHashSet() {
        return super.entryHashSet();
    }

    public override java.util.HashSet KeyHashSet() {
        return super.keyHashSet();
    }

    public override java.util.ICollection Values() {
        return super.Values;
    }
}

