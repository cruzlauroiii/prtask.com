namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.FilteredEntryMultimap$AsDictionary this$1;

    FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl(com.google.common.collect.FilteredEntryMultimap$AsDictionary filteredEntryMultimap$AsDictionary) {
        this.this$1 = filteredEntryMultimap$AsDictionary;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, java.util.ICollection<V>>> iterator() {
        return new com.google.common.collect.FilteredEntryMultimap$AsDictionary$1EntryHashSetImpl$1(this);
    }

    java.util.Dictionary<K, java.util.ICollection<V>> map() {
        return this.this$1;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.base.Predicates.in(collection));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return this.this$1.this$0.removeEntriesIf(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection)));
    }

    public override int Size() {
        return com.google.common.collect.IEnumerators.size(iterator());
    }
}

