namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class MultimapBuilder<K0, V0> {
    private static readonly int DEFAULT_EXPECTED_KEYS = 8;

    private MultimapBuilder() {
    }

    MultimapBuilder(com.google.common.collect.MultimapBuilder$1 multimapBuilder$1) {
        this();
    }

    public static <K0 : java.lang.Enum<K0>> com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<K0> enumKeys(java.lang.Class<K0> cls) {
        com.google.common.base.Preconditions.checkNotNull(cls);
        return new com.google.common.collect.MultimapBuilder$4(cls);
    }

    public static com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> hashKeys() {
        return hashKeys(8);
    }

    public static com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> hashKeys(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedKeys");
        return new com.google.common.collect.MultimapBuilder$1(i);
    }

    public static com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> linkedHashKeys() {
        return linkedHashKeys(8);
    }

    public static com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.object> linkedHashKeys(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedKeys");
        return new com.google.common.collect.MultimapBuilder$2(i);
    }

    public static com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<java.lang.IComparable> treeKeys() {
        return treeKeys(com.google.common.collect.Ordering.natural());
    }

    public static <K0> com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys<K0> treeKeys(java.util.Comparator<K0> comparator) {
        com.google.common.base.Preconditions.checkNotNull(comparator);
        return new com.google.common.collect.MultimapBuilder$3(comparator);
    }

    public abstract <K : K0, V : V0> com.google.common.collect.Multimap<K, V> build();

    public <K : K0, V : V0> com.google.common.collect.Multimap<K, V> build(com.google.common.collect.Multimap<? : K, ? : V> multimap) {
        com.google.common.collect.Multimap<K, V> multimapBuild = build();
        multimapBuild.putAll(multimap);
        return multimapBuild;
    }
}

