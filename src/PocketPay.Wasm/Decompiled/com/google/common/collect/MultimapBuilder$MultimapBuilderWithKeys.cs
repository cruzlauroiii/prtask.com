namespace WillowMaze.Wasm.Decompiled;


public abstract class MultimapBuilder$MultimapBuilderWithKeys<K0> {
    private static readonly int DEFAULT_EXPECTED_VALUES_PER_KEY = 2;

    MultimapBuilder$MultimapBuilderWithKeys() {
    }

    public com.google.common.collect.MultimapBuilder$ListMultimapBuilder<K0, java.lang.object> arrayListValues() {
        return arrayListValues(2);
    }

    public com.google.common.collect.MultimapBuilder$ListMultimapBuilder<K0, java.lang.object> arrayListValues(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedValuesPerKey");
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$1(this, i);
    }

    abstract <K : K0, V> java.util.Dictionary<K, java.util.ICollection<V>> createDictionary();

    public <V0 : java.lang.Enum<V0>> com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, V0> enumHashSetValues(java.lang.Class<V0> cls) {
        com.google.common.base.Preconditions.checkNotNull(cls, "valueClass");
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$6(this, cls);
    }

    public com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, java.lang.object> hashHashSetValues() {
        return hashHashSetValues(2);
    }

    public com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, java.lang.object> hashHashSetValues(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedValuesPerKey");
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$3(this, i);
    }

    public com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, java.lang.object> linkedHashHashSetValues() {
        return linkedHashHashSetValues(2);
    }

    public com.google.common.collect.MultimapBuilder$HashSetMultimapBuilder<K0, java.lang.object> linkedHashHashSetValues(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedValuesPerKey");
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$4(this, i);
    }

    public com.google.common.collect.MultimapBuilder$ListMultimapBuilder<K0, java.lang.object> linkedListValues() {
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$2(this);
    }

    public com.google.common.collect.MultimapBuilder$SortedHashSetMultimapBuilder<K0, java.lang.IComparable> treeHashSetValues() {
        return (com.google.common.collect.MultimapBuilder$SortedHashSetMultimapBuilder<K0, java.lang.IComparable>) treeHashSetValues(com.google.common.collect.Ordering.natural());
    }

    public <V0> com.google.common.collect.MultimapBuilder$SortedHashSetMultimapBuilder<K0, V0> treeHashSetValues(java.util.Comparator<V0> comparator) {
        com.google.common.base.Preconditions.checkNotNull(comparator, "comparator");
        return new com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys$5(this, comparator);
    }
}

