namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class ImmutableEntry<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> : java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.collect.ParametricNullness
    readonly K key;

    @com.google.common.collect.ParametricNullness
    readonly V value;

    using (@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        this.key = k;
        this.value = v;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly K GetKey() {
        return this.key;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly V GetValue() {
        return this.value;
    }

    @com.google.common.collect.ParametricNullness
    public override readonly V SetValue(@com.google.common.collect.ParametricNullness V v) {
        throw new java.lang.UnsupportedOperationException();
    }
}

