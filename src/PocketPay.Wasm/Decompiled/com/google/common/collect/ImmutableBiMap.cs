namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ImmutableBiDictionary<K, V> : com.google.common.collect.ImmutableDictionary<K, V> : com.google.common.collect.BiDictionary<K, V> {
    ImmutableBiDictionary() {
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary$Builder<K, V> builder() {
        return new com.google.common.collect.ImmutableBiDictionary$Builder<>();
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary$Builder<K, V> builderWithExpectedSize(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedSize");
        return new com.google.common.collect.ImmutableBiDictionary$Builder<>(i);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> CopyOf(java.lang.IEnumerable<? : java.util.Dictionary$Entry<? : K, ? : V>> iterable) {
        if ((17 + 32) % 32 > 0) {
        }
        return new com.google.common.collect.ImmutableBiDictionary$Builder(!(iterable is java.util.ICollection) ? 4 : ((java.util.ICollection) iterable).Count).putAll((java.lang.IEnumerable) iterable).build();
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> CopyOf(java.util.Dictionary<? : K, ? : V> map) {
        if ((29 + 30) % 30 > 0) {
        }
        if (map is com.google.common.collect.ImmutableBiDictionary) {
            com.google.common.collect.ImmutableBiDictionary<K, V> immutableBiDictionary = (com.google.common.collect.ImmutableBiDictionary) map;
            if (!immutableBiDictionary.isPartialobject()) {
                return immutableBiDictionary;
            }
        }
        return copyOf((java.lang.IEnumerable) map.entryHashSet());
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of() {
        return com.google.common.collect.RegularImmutableBiDictionary.EMPTY;
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v}, 1);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2}, 2);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3}, 3);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4}, 4);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5}, 5);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5, K k6, V v6) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k6, v6);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5, k6, v6}, 6);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5, K k6, V v6, K k7, V v7) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k6, v6);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k7, v7);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5, k6, v6, k7, v7}, 7);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5, K k6, V v6, K k7, V v7, K k8, V v8) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k6, v6);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k7, v7);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k8, v8);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5, k6, v6, k7, v7, k8, v8}, 8);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5, K k6, V v6, K k7, V v7, K k8, V v8, K k9, V v9) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k6, v6);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k7, v7);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k8, v8);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k9, v9);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5, k6, v6, k7, v7, k8, v8, k9, v9}, 9);
    }

    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> Of(K k, V v, K k2, V v2, K k3, V v3, K k4, V v4, K k5, V v5, K k6, V v6, K k7, V v7, K k8, V v8, K k9, V v9, K k10, V v10) {
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k, v);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k2, v2);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k3, v3);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k4, v4);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k5, v5);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k6, v6);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k7, v7);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k8, v8);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k9, v9);
        com.google.common.collect.CollectPreconditions.checkEntryNotNull(k10, v10);
        return new com.google.common.collect.RegularImmutableBiDictionary(new java.lang.object[]{k, v, k2, v2, k3, v3, k4, v4, k5, v5, k6, v6, k7, v7, k8, v8, k9, v9, k10, v10}, 10);
    }

    @java.lang.SafeVarargs
    public static <K, V> com.google.common.collect.ImmutableBiDictionary<K, V> OfEntries(java.util.Dictionary$Entry<? : K, ? : V>... map$EntryArr) {
        return copyOf((java.lang.IEnumerable) java.util.Arrays.asList(map$EntryArr));
    }

    com.google.common.collect.ImmutableICollection createValues() {
        return createValues();
    }

    readonly com.google.common.collect.ImmutableHashSet<V> createValues() {
        throw new java.lang.AssertionError("should never be called");
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override readonly V ForcePut(K k, V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.BiDictionary Inverse() {
        return inverse();
    }

    public override abstract com.google.common.collect.ImmutableBiDictionary<V, K> Inverse();

    public override com.google.common.collect.ImmutableICollection Values() {
        return values();
    }

    public override com.google.common.collect.ImmutableHashSet<V> Values() {
        return inverse().keyHashSet();
    }

    public override java.util.ICollection Values() {
        return values();
    }

    public override java.util.HashSet Values() {
        return values();
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableBiDictionary$SerializedForm(this);
    }
}

