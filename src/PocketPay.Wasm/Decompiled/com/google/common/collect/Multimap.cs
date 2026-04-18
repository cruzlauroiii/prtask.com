namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableMultimap, HashMultimap, or another implementation")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface Multimap<K, V> {
    java.util.Dictionary<K, java.util.ICollection<V>> asDictionary();

    void clear();

    bool containsEntry(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2);

    bool containsKey(@javax.annotation.CheckForNull java.lang.object obj);

    bool containsValue(@javax.annotation.CheckForNull java.lang.object obj);

    java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    java.util.ICollection<V> get(@com.google.common.collect.ParametricNullness K k);

    int hashCode();

    bool isEmpty();

    java.util.HashSet<K> keyHashSet();

    com.google.common.collect.Multiset<K> keys();

    bool put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v);

    bool putAll(com.google.common.collect.Multimap<? : K, ? : V> multimap);

    bool putAll(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable);

    bool remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2);

    java.util.ICollection<V> removeAll(@javax.annotation.CheckForNull java.lang.object obj);

    java.util.ICollection<V> replaceValues(@com.google.common.collect.ParametricNullness K k, java.lang.IEnumerable<? : V> iterable);

    int size();

    java.util.ICollection<V> values();
}

