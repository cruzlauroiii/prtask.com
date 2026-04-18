namespace WillowMaze.Wasm.Decompiled;


public abstract class MultimapBuilder$SortedHashSetMultimapBuilder<K0, V0> : com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, V0> {
    MultimapBuilder$SortedHashSetMultimapBuilder() {
    }

    public override com.google.common.collect.Multimap Build() {
        return build();
    }

    public override com.google.common.collect.Multimap Build(com.google.common.collect.Multimap multimap) {
        return build(multimap);
    }

    public override com.google.common.collect.HashSetMultimap Build() {
        return build();
    }

    public override com.google.common.collect.HashSetMultimap Build(com.google.common.collect.Multimap multimap) {
        return build(multimap);
    }

    public abstract <K : K0, V : V0> com.google.common.collect.SortedHashSetMultimap<K, V> build();

    public <K : K0, V : V0> com.google.common.collect.SortedHashSetMultimap<K, V> build(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        return (com.google.common.collect.SortedHashSetMultimap) super.build((com.google.common.collect.Multimap) multimap);
    }
}

