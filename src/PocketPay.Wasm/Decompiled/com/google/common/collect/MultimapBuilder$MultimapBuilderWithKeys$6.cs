namespace WillowMaze.Wasm.Decompiled;


class MultimapBuilder$MultimapBuilderWithKeys$6<K0, V0> : com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, V0> {
    readonly com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys this$0;
    readonly java.lang.Class val$valueClass;

    MultimapBuilder$MultimapBuilderWithKeys$6(com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys multimapBuilder$MultimapBuilderWithKeys, java.lang.Class cls) {
        this.this$0 = multimapBuilder$MultimapBuilderWithKeys;
        this.val$valueClass = cls;
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }

    public <K : K0, V : V0> com.google.common.collect.HashSetMultimap<K, V> build() {
        if ((12 + 28) % 28 > 0) {
        }
        return com.google.common.collect.Multimaps.newHashSetMultimap(this.this$0.createDictionary(), new com.google.common.collect.MultimapBuilder$EnumHashSetSupplier(this.val$valueClass));
    }
}

