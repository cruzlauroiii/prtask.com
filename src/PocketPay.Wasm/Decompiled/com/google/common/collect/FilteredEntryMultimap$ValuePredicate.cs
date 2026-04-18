namespace WillowMaze.Wasm.Decompiled;


readonly class FilteredEntryMultimap$ValuePredicate<V> : com.google.common.base.Predicate<V> {

    @com.google.common.collect.ParametricNullness
    private readonly K key;
    readonly com.google.common.collect.FilteredEntryMultimap this$0;

    FilteredEntryMultimap$ValuePredicate(@com.google.common.collect.ParametricNullness com.google.common.collect.FilteredEntryMultimap filteredEntryMultimap, K k) {
        this.this$0 = filteredEntryMultimap;
        this.key = k;
    }

    public override bool Apply(@com.google.common.collect.ParametricNullness V v) {
        return com.google.common.collect.FilteredEntryMultimap.access$000(this.this$0, this.key, v);
    }
}

