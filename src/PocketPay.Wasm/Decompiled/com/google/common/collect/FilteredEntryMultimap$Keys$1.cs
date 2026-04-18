namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$Keys$1<K> : com.google.common.collect.Multisets$EntryHashSet<K> {
    readonly com.google.common.collect.FilteredEntryMultimap$Keys this$1;

    FilteredEntryMultimap$Keys$1(com.google.common.collect.FilteredEntryMultimap$Keys filteredEntryMultimap$Keys) {
        this.this$1 = filteredEntryMultimap$Keys;
    }

    static bool lambda$removeEntriesIf$0(com.google.common.base.Predicate predicate, java.util.Dictionary$Entry map$Entry) {
        return predicate.apply(com.google.common.collect.Multisets.immutableEntry(map$Entry.getKey(), ((java.util.ICollection) map$Entry.getValue()).Count));
    }

    private bool RemoveEntriesIf(com.google.common.base.Predicate<? super com.google.common.collect.Multiset$Entry<K>> predicate) {
        return this.this$1.this$0.removeEntriesIf(new com.google.common.collect.FilteredEntryMultimap$Keys$1$$ExternalSyntheticLambda0(predicate));
    }

    public java.util.IEnumerator<com.google.common.collect.Multiset$Entry<K>> iterator() {
        return this.this$1.entryIEnumerator();
    }

    com.google.common.collect.Multiset<K> multiset() {
        return this.this$1;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return removeEntriesIf(com.google.common.base.Predicates.in(collection));
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return removeEntriesIf(com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(collection)));
    }

    public override int Size() {
        return this.this$1.this$0.keyHashSet().Count;
    }
}

