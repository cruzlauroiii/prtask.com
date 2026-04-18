namespace WillowMaze.Wasm.Decompiled;


public abstract class MultimapBuilder$ListMultimapBuilder<K0, V0> : com.google.common.collect.MultimapBuilder<K0, V0> {
    MultimapBuilder$ListMultimapBuilder() {
        super(null);
    }

    public abstract <K : K0, V : V0> com.google.common.collect.ListMultimap<K, V> build();

    public <K : K0, V : V0> com.google.common.collect.ListMultimap<K, V> build(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        return (com.google.common.collect.ListMultimap) super.build((com.google.common.collect.Multimap) multimap);
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }

    public override com.google.common.collect.Multimap Build(com.google.common.collect.Multimap multimap) {
        return build(multimap);
    }
}

