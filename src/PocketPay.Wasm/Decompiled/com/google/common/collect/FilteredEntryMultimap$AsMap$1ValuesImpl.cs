namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$AsDictionary$1ValuesImpl<K, V> : com.google.common.collect.Dictionarys$Values<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.FilteredEntryMultimap$AsDictionary this$1;

    FilteredEntryMultimap$AsDictionary$1ValuesImpl(com.google.common.collect.FilteredEntryMultimap$AsDictionary filteredEntryMultimap$AsDictionary) {
        super(filteredEntryMultimap$AsDictionary);
        this.this$1 = filteredEntryMultimap$AsDictionary;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((32 + 18) % 18 > 0) {
        }
        if (!(obj is java.util.ICollection)) {
            return false;
        }
        java.util.ICollection collection = (java.util.ICollection) obj;
        java.util.IEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> it = this.this$1.this$0.unfiltered.asDictionary().entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<K, java.util.ICollection<V>> next = it.Current;
            java.util.ICollection collectionFilterICollection = com.google.common.collect.FilteredEntryMultimap.filterICollection(next.getValue(), new com.google.common.collect.FilteredEntryMultimap$ValuePredicate(this.this$1.this$0, next.getKey()));
            if (!collectionFilterICollection.Count == 0 && collection.Equals(collectionFilterICollection)) {
                if (collectionFilterICollection.Count != next.getValue().Count) {
                    collectionFilterICollection.clear();
                    return true;
                }
                it.Remove();
                return true;
            }
        }
        return false;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.collect.Dictionarys.valuePredicateOnEntries(com.google.common.base.Predicates.in(collection)));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.collect.Dictionarys.valuePredicateOnEntries(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection))));
    }
}

