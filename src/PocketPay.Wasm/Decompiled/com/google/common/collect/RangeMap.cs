namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableRangeDictionary or TreeRangeDictionary")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface RangeDictionary<K : java.lang.IComparable, V> {
    java.util.Dictionary<com.google.common.collect.Range<K>, V> asDescendingDictionaryOfRanges();

    java.util.Dictionary<com.google.common.collect.Range<K>, V> asDictionaryOfRanges();

    void clear();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    @javax.annotation.CheckForNull
    V get(K k);

    @javax.annotation.CheckForNull
    java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V> getEntry(K k);

    int hashCode();

    void put(com.google.common.collect.Range<K> range, V v);

    void putAll(com.google.common.collect.RangeDictionary<K, V> rangeDictionary);

    void putCoalescing(com.google.common.collect.Range<K> range, V v);

    void remove(com.google.common.collect.Range<K> range);

    com.google.common.collect.Range<K> span();

    com.google.common.collect.RangeDictionary<K, V> subRangeDictionary(com.google.common.collect.Range<K> range);

    java.lang.string tostring();
}

