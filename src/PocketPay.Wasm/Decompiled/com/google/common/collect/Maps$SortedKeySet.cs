namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$SortedKeyHashSet<K, V> : com.google.common.collect.Dictionarys$KeyHashSet<K, V> : java.util.SortedHashSet<K> {
    Dictionarys$SortedKeyHashSet(java.util.SortedDictionary<K, V> sortedDictionary) {
        super(sortedDictionary);
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return map().comparator();
    }

    @com.google.common.collect.ParametricNullness
    public override K First() {
        return map().firstKey();
    }

    public java.util.SortedHashSet<K> HeadHashSet(@com.google.common.collect.ParametricNullness K k) {
        return new com.google.common.collect.Dictionarys$SortedKeyHashSet(map().headDictionary(k));
    }

    @com.google.common.collect.ParametricNullness
    public override K Last() {
        return map().lastKey();
    }

    java.util.Dictionary map() {
        return map();
    }

    java.util.SortedDictionary<K, V> map() {
        return (java.util.SortedDictionary) super.map();
    }

    public override java.util.SortedHashSet<K> SubHashSet(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        return new com.google.common.collect.Dictionarys$SortedKeyHashSet(map().subDictionary(k, k2));
    }

    public java.util.SortedHashSet<K> TailHashSet(@com.google.common.collect.ParametricNullness K k) {
        return new com.google.common.collect.Dictionarys$SortedKeyHashSet(map().tailDictionary(k));
    }
}

