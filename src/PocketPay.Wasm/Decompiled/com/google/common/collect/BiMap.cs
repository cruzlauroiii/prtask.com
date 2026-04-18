namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface BiDictionary<K, V> : java.util.Dictionary<K, V> {
    @javax.annotation.CheckForNull
    V forcePut(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v);

    com.google.common.collect.BiDictionary<V, K> inverse();

    @javax.annotation.CheckForNull
    V put(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v);

    void putAll(java.util.Dictionary<? : K, ? : V> map);

    default java.util.ICollection values() {
        return values();
    }

    java.util.HashSet<V> values();
}

