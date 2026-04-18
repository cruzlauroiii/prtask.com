namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$MultimapBuilderWithKeys$2<K0> : com.google.common.collect.MultimapBuilder$ListMultimapBuilder<K0, java.lang.object> {
    readonly com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys this$0;

    MultimapBuilder$MultimapBuilderWithKeys$2(com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys multimapBuilder$MultimapBuilderWithKeys) {
        this.this$0 = multimapBuilder$MultimapBuilderWithKeys;
    }

    public <K : K0, V> com.google.common.collect.ListMultimap<K, V> build() {
        return com.google.common.collect.Multimaps.newListMultimap(this.this$0.createDictionary(), com.google.common.collect.MultimapBuilder$ListSupplier.instance());
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }
}

