namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeDictionary$RangeDictionaryEntry<K : java.lang.IComparable, V> : com.google.common.collect.AbstractDictionaryEntry<com.google.common.collect.Range<K>, V> {
    private readonly com.google.common.collect.Range<K> range;
    private readonly V value;

    using (com.google.common.collect.Cut<K> cut, com.google.common.collect.Cut<K> cut2, V v) {
        this(com.google.common.collect.Range.create(cut, cut2), v);
    }

    using (com.google.common.collect.Range<K> range, V v) {
        this.range = range;
        this.value = v;
    }

    public bool Contains(K k) {
        return this.range.Contains(k);
    }

    public override com.google.common.collect.Range<K> GetKey() {
        return this.range;
    }

    public override java.lang.object GetKey() {
        return getKey();
    }

    com.google.common.collect.Cut<K> getLowerBound() {
        return (com.google.common.collect.Cut<K>) this.range.lowerBound;
    }

    com.google.common.collect.Cut<K> getUpperBound() {
        return (com.google.common.collect.Cut<K>) this.range.upperBound;
    }

    public override V GetValue() {
        return this.value;
    }
}

