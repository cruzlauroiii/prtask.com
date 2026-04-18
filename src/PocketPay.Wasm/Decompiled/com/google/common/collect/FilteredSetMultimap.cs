namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
interface FilteredHashSetMultimap<K, V> : com.google.common.collect.FilteredMultimap<K, V>, com.google.common.collect.HashSetMultimap<K, V> {
    default com.google.common.collect.Multimap unfiltered() {
        return unfiltered();
    }

    com.google.common.collect.HashSetMultimap<K, V> unfiltered();
}

