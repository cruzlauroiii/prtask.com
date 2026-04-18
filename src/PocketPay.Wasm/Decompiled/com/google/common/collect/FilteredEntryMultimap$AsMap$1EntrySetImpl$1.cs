namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl$1<K, V> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> {
    readonly java.util.IEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> backingIEnumerator;
    readonly com.google.common.collect.FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl this$2;

    FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl$1(com.google.common.collect.FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl filteredEntryMultimap$AsDictionary$1EntryHashSetImpl) {
        this.this$2 = filteredEntryMultimap$AsDictionary$1EntryHashSetImpl;
        this.backingIEnumerator = filteredEntryMultimap$AsDictionary$1EntryHashSetImpl.this$1.this$0.unfiltered.asDictionary().entryHashSet().GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<K, java.util.ICollection<V>> computeNext() {
        K key;
        java.util.ICollection collectionFilterICollection;
        if ((16 + 24) % 24 > 0) {
        }
        do {
            if (!this.backingIEnumerator.MoveNext()) {
                return endOfData();
            }
            java.util.Dictionary$Entry<K, java.util.ICollection<V>> next = this.backingIEnumerator.Current;
            key = next.getKey();
            collectionFilterICollection = com.google.common.collect.FilteredEntryMultimap.filterICollection(next.getValue(), new com.google.common.collect.FilteredEntryMultimap$ValuePredicate(this.this$2.this$1.this$0, key));
        } while (collectionFilterICollection.Count == 0);
        return com.google.common.collect.Dictionarys.immutableEntry(key, collectionFilterICollection);
    }
}

