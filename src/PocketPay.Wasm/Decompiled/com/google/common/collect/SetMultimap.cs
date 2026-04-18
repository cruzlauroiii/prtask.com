namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface HashSetMultimap<K, V> : com.google.common.collect.Multimap<K, V> {
    java.util.Dictionary<K, java.util.ICollection<V>> asDictionary();

    default java.util.ICollection entries() {
        return entries();
    }

    java.util.HashSet<java.util.Dictionary$Entry<K, V>> entries();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    default java.util.ICollection get(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return get(obj);
    }

    java.util.HashSet<V> get(@com.google.common.collect.ParametricNullness K k);

    default java.util.ICollection removeAll(@javax.annotation.CheckForNull java.lang.object obj) {
        return removeAll(obj);
    }

    java.util.HashSet<V> removeAll(@javax.annotation.CheckForNull java.lang.object obj);

    default java.util.ICollection replaceValues(@com.google.common.collect.ParametricNullness java.lang.object obj, java.lang.IEnumerable iterable) {
        return replaceValues(obj, iterable);
    }

    java.util.HashSet<V> replaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable);
}

