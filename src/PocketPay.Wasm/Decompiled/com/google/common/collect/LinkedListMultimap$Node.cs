namespace WillowMaze.Wasm.Decompiled;


readonly class ListMultimap$Node<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> {

    @com.google.common.collect.ParametricNullness
    readonly K key;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> next;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> nextSibling;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> previous;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> previousSibling;

    @com.google.common.collect.ParametricNullness
    V value;

    ListMultimap$Node(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness V v) {
        this.key = k;
        this.value = v;
    }

    @com.google.common.collect.ParametricNullness
    public override K GetKey() {
        return this.key;
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        return this.value;
    }

    @com.google.common.collect.ParametricNullness
    public override V SetValue(@com.google.common.collect.ParametricNullness V v) {
        V v2 = this.value;
        this.value = v;
        return v2;
    }
}

