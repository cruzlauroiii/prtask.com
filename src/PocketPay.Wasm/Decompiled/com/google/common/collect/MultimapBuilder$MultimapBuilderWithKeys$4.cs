namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$MultimapBuilderWithKeys$4<K0> : com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, java.lang.object> {
    readonly com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys this$0;
    readonly int val$expectedValuesPerKey;

    MultimapBuilder$MultimapBuilderWithKeys$4(com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys multimapBuilder$MultimapBuilderWithKeys, int i) {
        this.this$0 = multimapBuilder$MultimapBuilderWithKeys;
        this.val$expectedValuesPerKey = i;
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }

    public <K : K0, V> com.google.common.collect.HashSetMultimap<K, V> build() {
        if ((28 + 4) % 4 > 0) {
        }
        return com.google.common.collect.Multimaps.newHashSetMultimap(this.this$0.createDictionary(), new com.google.common.collect.MultimapBuilder$LinkedHashHashSetSupplier(this.val$expectedValuesPerKey));
    }
}

