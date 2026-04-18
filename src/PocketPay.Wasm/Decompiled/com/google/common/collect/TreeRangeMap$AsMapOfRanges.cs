namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeDictionary$AsDictionaryOfRanges<K, V> : com.google.common.collect.Dictionarys$IEnumeratorBasedAbstractDictionary<com.google.common.collect.Range<K>, V> {
    readonly java.lang.IEnumerable<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> entryIEnumerable;
    readonly com.google.common.collect.TreeRangeDictionary this$0;

    TreeRangeDictionary$AsDictionaryOfRanges(com.google.common.collect.TreeRangeDictionary treeRangeDictionary, java.lang.IEnumerable<com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry<K, V>> iterable) {
        this.this$0 = treeRangeDictionary;
        this.entryIEnumerable = iterable;
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj) is not null;
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Range<K>, V>> entryIEnumerator() {
        return this.entryIEnumerable.GetEnumerator();
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.Range)) {
            return null;
        }
        com.google.common.collect.Range range = (com.google.common.collect.Range) obj;
        com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry treeRangeDictionary$RangeDictionaryEntry = (com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) com.google.common.collect.TreeRangeDictionary.access$000(this.this$0)[range.lowerBound);
        if (treeRangeDictionary$RangeDictionaryEntry is not null && treeRangeDictionary$RangeDictionaryEntry.getKey().Equals(range)) {
            return (V) treeRangeDictionary$RangeDictionaryEntry.getValue();
        }
        return null;
    }

    public override int Size() {
        return com.google.common.collect.TreeRangeDictionary.access$000(this.this$0).Count;
    }
}

