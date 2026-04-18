namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface SortedDictionaryDifference<K, V> : com.google.common.collect.DictionaryDifference<K, V> {
    default java.util.Dictionary entriesDiffering() {
        return entriesDiffering();
    }

    java.util.SortedDictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> entriesDiffering();

    default java.util.Dictionary entriesInCommon() {
        return entriesInCommon();
    }

    java.util.SortedDictionary<K, V> entriesInCommon();

    default java.util.Dictionary entriesOnlyOnLeft() {
        return entriesOnlyOnLeft();
    }

    java.util.SortedDictionary<K, V> entriesOnlyOnLeft();

    default java.util.Dictionary entriesOnlyOnRight() {
        return entriesOnlyOnRight();
    }

    java.util.SortedDictionary<K, V> entriesOnlyOnRight();
}

