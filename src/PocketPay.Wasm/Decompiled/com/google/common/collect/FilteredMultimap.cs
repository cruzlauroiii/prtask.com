namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
interface FilteredMultimap<K, V> : com.google.common.collect.Multimap<K, V> {
    com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> entryPredicate();

    com.google.common.collect.Multimap<K, V> unfiltered();
}

