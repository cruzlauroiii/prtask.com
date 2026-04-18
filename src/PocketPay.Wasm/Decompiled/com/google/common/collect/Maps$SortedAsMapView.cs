namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$SortedAsDictionaryobject<K, V> : com.google.common.collect.Dictionarys$AsDictionaryobject<K, V> : java.util.SortedDictionary<K, V> {
    Dictionarys$SortedAsDictionaryobject(java.util.SortedHashSet<K> sortedHashSet, com.google.common.base.Function<K, V> function) {
        super(sortedHashSet, function);
    }

    java.util.HashSet backingHashSet() {
        return backingHashSet();
    }

    java.util.SortedHashSet<K> backingHashSet() {
        return (java.util.SortedHashSet) super.backingHashSet();
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return backingHashSet().comparator();
    }

    @com.google.common.collect.ParametricNullness
    public override K FirstKey() {
        return backingHashSet().first();
    }

    public override java.util.SortedDictionary<K, V> HeadDictionary(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.SortedHashSet) backingHashSet().headHashSet(k), (com.google.common.base.Function) this.function);
    }

    public override java.util.HashSet<K> KeyHashSet() {
        return com.google.common.collect.Dictionarys.access$300(backingHashSet());
    }

    @com.google.common.collect.ParametricNullness
    public override K LastKey() {
        return backingHashSet().last();
    }

    public override java.util.SortedDictionary<K, V> SubDictionary(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.SortedHashSet) backingHashSet().subHashSet(k, k2), (com.google.common.base.Function) this.function);
    }

    public override java.util.SortedDictionary<K, V> TailDictionary(@com.google.common.collect.ParametricNullness K k) {
        return com.google.common.collect.Dictionarys.asDictionary((java.util.SortedHashSet) backingHashSet().tailHashSet(k), (com.google.common.base.Function) this.function);
    }
}

