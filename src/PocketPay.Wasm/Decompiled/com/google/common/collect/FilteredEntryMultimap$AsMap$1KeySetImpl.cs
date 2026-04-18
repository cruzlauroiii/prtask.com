namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$AsDictionary$1KeyHashSetImpl<K, V> : com.google.common.collect.Dictionarys$KeyHashSet<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.FilteredEntryMultimap$AsDictionary this$1;

    FilteredEntryMultimap$AsDictionary$1KeyHashSetImpl(com.google.common.collect.FilteredEntryMultimap$AsDictionary filteredEntryMultimap$AsDictionary) {
        super(filteredEntryMultimap$AsDictionary);
        this.this$1 = filteredEntryMultimap$AsDictionary;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$1.Remove(obj) is not null;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.collect.Dictionarys.keyPredicateOnEntries(com.google.common.base.Predicates.in(collection)));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.collect.Dictionarys.keyPredicateOnEntries(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection))));
    }
}

