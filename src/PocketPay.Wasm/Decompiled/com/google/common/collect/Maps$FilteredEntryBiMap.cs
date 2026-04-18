namespace WillowMaze.Wasm.Decompiled;


readonly class Dictionarys$FilteredEntryBiDictionary<K, V> : com.google.common.collect.Dictionarys$FilteredEntryDictionary<K, V> : com.google.common.collect.BiDictionary<K, V> {
    private readonly com.google.common.collect.BiDictionary<V, K> inverse;

    Dictionarys$FilteredEntryBiDictionary(com.google.common.collect.BiDictionary<K, V> biDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        super(biDictionary, predicate);
        this.inverse = new com.google.common.collect.Dictionarys$FilteredEntryBiDictionary(biDictionary.inverse(), inversePredicate(predicate), this);
    }

    private Dictionarys$FilteredEntryBiDictionary(com.google.common.collect.BiDictionary<K, V> biDictionary, com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate, com.google.common.collect.BiDictionary<V, K> biDictionary2) {
        super(biDictionary, predicate);
        this.inverse = biDictionary2;
    }

    private static <K, V> com.google.common.base.Predicate<java.util.Dictionary$Entry<V, K>> inversePredicate(com.google.common.base.Predicate<? super java.util.Dictionary$Entry<K, V>> predicate) {
        return new com.google.common.collect.Dictionarys$FilteredEntryBiDictionary$1(predicate);
    }

    @javax.annotation.CheckForNull
    public override V ForcePut(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        com.google.common.base.Preconditions.checkArgument(apply(k, v));
        return unfiltered().forcePut(k, v);
    }

    public override com.google.common.collect.BiDictionary<V, K> Inverse() {
        return this.inverse;
    }

    com.google.common.collect.BiDictionary<K, V> unfiltered() {
        return (com.google.common.collect.BiDictionary) this.unfiltered;
    }

    public override java.util.ICollection Values() {
        return values();
    }

    public override java.util.HashSet<V> Values() {
        return this.inverse.keyHashSet();
    }
}

