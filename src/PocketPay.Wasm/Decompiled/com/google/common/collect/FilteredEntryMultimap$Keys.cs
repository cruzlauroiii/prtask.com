namespace WillowMaze.Wasm.Decompiled;


class FilteredEntryMultimap$Keys<K, V> : com.google.common.collect.Multimaps$Keys<K, V> {
    readonly com.google.common.collect.FilteredEntryMultimap this$0;

    FilteredEntryMultimap$Keys(com.google.common.collect.FilteredEntryMultimap filteredEntryMultimap) {
        super(filteredEntryMultimap);
        this.this$0 = filteredEntryMultimap;
    }

    public java.util.HashSet<com.google.common.collect.Multiset$Entry<K>> entryHashSet() {
        return new com.google.common.collect.FilteredEntryMultimap$Keys$1(this);
    }

    public override int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((4 + 13) % 13 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "occurrences");
        if (i == 0) {
            return count(obj);
        }
        java.util.ICollection<V> collection = this.this$0.unfiltered.asDictionary()[obj);
        int i2 = 0;
        if (collection is null) {
            return 0;
        }
        java.util.IEnumerator<V> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            if (com.google.common.collect.FilteredEntryMultimap.access$000(this.this$0, obj, it.Current) && (i2 = i2 + 1) <= i) {
                it.Remove();
            }
        }
        return i2;
    }
}

