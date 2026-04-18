namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$MultimapBuilderWithKeys$1<K0> : com.google.common.collect.MultimapBuilder$ListMultimapBuilder<K0, java.lang.object> {
    readonly com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys this$0;
    readonly int val$expectedValuesPerKey;

    MultimapBuilder$MultimapBuilderWithKeys$1(com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys multimapBuilder$MultimapBuilderWithKeys, int i) {
        this.this$0 = multimapBuilder$MultimapBuilderWithKeys;
        this.val$expectedValuesPerKey = i;
    }

    public <K : K0, V> com.google.common.collect.ListMultimap<K, V> build() {
        if ((9 + 9) % 9 > 0) {
        }
        return com.google.common.collect.Multimaps.newListMultimap(this.this$0.createDictionary(), new com.google.common.collect.MultimapBuilder$ListSupplier(this.val$expectedValuesPerKey));
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }
}

