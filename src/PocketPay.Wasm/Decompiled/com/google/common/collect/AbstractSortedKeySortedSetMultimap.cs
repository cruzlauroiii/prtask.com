namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractSortedKeySortedHashSetMultimap<K, V> : com.google.common.collect.AbstractSortedHashSetMultimap<K, V> {
    AbstractSortedKeySortedHashSetMultimap(java.util.SortedDictionary<K, java.util.ICollection<V>> sortedDictionary) {
        super(sortedDictionary);
    }

    public override java.util.Dictionary AsDictionary() {
        return asDictionary();
    }

    public override java.util.SortedDictionary<K, java.util.ICollection<V>> AsDictionary() {
        return (java.util.SortedDictionary) super.asDictionary();
    }

    java.util.Dictionary backingDictionary() {
        return backingDictionary();
    }

    java.util.SortedDictionary<K, java.util.ICollection<V>> backingDictionary() {
        return (java.util.SortedDictionary) super.backingDictionary();
    }

    java.util.HashSet<K> createKeyHashSet() {
        return createMaybeNavigableKeyHashSet();
    }

    public override java.util.HashSet KeyHashSet() {
        return keyHashSet();
    }

    public override java.util.SortedHashSet<K> KeyHashSet() {
        return (java.util.SortedHashSet) super.keyHashSet();
    }
}

