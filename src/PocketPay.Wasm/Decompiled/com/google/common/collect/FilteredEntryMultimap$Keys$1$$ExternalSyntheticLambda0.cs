namespace WillowMaze.Wasm.Decompiled;


public readonly class FilteredEntryMultimap$Keys$1$$ExternalSyntheticLambda0 : com.google.common.base.Predicate {
    public readonly com.google.common.base.Predicate f$0;

    public FilteredEntryMultimap$Keys$1$$ExternalSyntheticLambda0(com.google.common.base.Predicate predicate) {
        this.f$0 = predicate;
    }

    public override readonly bool Apply(java.lang.object obj) {
        return com.google.common.collect.FilteredEntryMultimap$Keys$1.lambda$removeEntriesIf$0(this.f$0, (java.util.Dictionary$Entry) obj);
    }
}

