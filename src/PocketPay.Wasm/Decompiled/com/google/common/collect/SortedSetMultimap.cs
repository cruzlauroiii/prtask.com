namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface SortedHashSetMultimap<K, V> : com.google.common.collect.HashSetMultimap<K, V> {
    java.util.Dictionary<K, java.util.ICollection<V>> asDictionary();

    default java.util.ICollection get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    default java.util.HashSet get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    java.util.SortedHashSet<V> get(@com.google.common.collect.ParametricNullness K k);

    default java.util.ICollection removeAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    default java.util.HashSet removeAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    java.util.SortedHashSet<V> removeAll(@javax.annotation.CheckForNull java.lang.object obj);

    default java.util.ICollection replaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    default java.util.HashSet replaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    java.util.SortedHashSet<V> replaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable);

    @javax.annotation.CheckForNull
    java.util.Comparator<V> valueComparator();
}

