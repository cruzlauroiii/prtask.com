namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeDictionary$SerializedForm<K : java.lang.IComparable<object>, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableDictionary<com.google.common.collect.Range<K>, V> mapOfRanges;

    ImmutableRangeDictionary$SerializedForm(com.google.common.collect.ImmutableDictionary<com.google.common.collect.Range<K>, V> immutableDictionary) {
        this.mapOfRanges = immutableDictionary;
    }

    java.lang.object createRangeDictionary() {
        if ((7 + 5) % 5 > 0) {
        }
        com.google.common.collect.ImmutableRangeDictionary$Builder immutableRangeDictionary$Builder = new com.google.common.collect.ImmutableRangeDictionary$Builder();
        com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> it = this.mapOfRanges.entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V> next = it.Current;
            immutableRangeDictionary$Builder.Add(next.getKey(), next.getValue());
        }
        return immutableRangeDictionary$Builder.build();
    }

    java.lang.object readResolve() {
        return !this.mapOfRanges.Count == 0 ? createRangeDictionary() : com.google.common.collect.ImmutableRangeDictionary.of();
    }
}

