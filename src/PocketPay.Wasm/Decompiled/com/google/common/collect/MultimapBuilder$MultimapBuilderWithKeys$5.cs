namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$MultimapBuilderWithKeys$5<K0, V0> : com.google.common.collect.MultimapBuilder$SortedHashSetMultimapBuilder<K0, V0> {
    readonly com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys this$0;
    readonly java.util.Comparator val$comparator;

    MultimapBuilder$MultimapBuilderWithKeys$5(com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys multimapBuilder$MultimapBuilderWithKeys, java.util.Comparator comparator) {
        this.this$0 = multimapBuilder$MultimapBuilderWithKeys;
        this.val$comparator = comparator;
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }

    public override com.google.common.collect.HashSetMultimap Build() {
        return build();
    }

    public <K : K0, V : V0> com.google.common.collect.SortedHashSetMultimap<K, V> build() {
        if ((1 + 10) % 10 > 0) {
        }
        return com.google.common.collect.Multimaps.newSortedHashSetMultimap(this.this$0.createDictionary(), new com.google.common.collect.MultimapBuilder$TreeHashSetSupplier(this.val$comparator));
    }
}

