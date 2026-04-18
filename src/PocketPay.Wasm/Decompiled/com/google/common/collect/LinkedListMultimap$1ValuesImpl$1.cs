namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$1ValuesImpl$1<K, V> : com.google.common.collect.TransformedListIEnumerator<java.util.Dictionary$Entry<K, V>, V> {
    readonly com.google.common.collect.ListMultimap$NodeIEnumerator val$nodeItr;

    ListMultimap$1ValuesImpl$1(com.google.common.collect.ListMultimap$1ValuesImpl linkedListMultimap$1ValuesImpl, java.util.ListIEnumerator listIEnumerator, com.google.common.collect.ListMultimap$NodeIEnumerator linkedListMultimap$NodeIEnumerator) {
        super(listIEnumerator);
        this.val$nodeItr = linkedListMultimap$NodeIEnumerator;
    }

    public override void Set(@com.google.common.collect.ParametricNullness V v) {
        this.val$nodeItr.setValue(v);
    }

    @com.google.common.collect.ParametricNullness
    java.lang.object transform(java.lang.object obj) {
        return transform((java.util.Dictionary$Entry) obj);
    }

    @com.google.common.collect.ParametricNullness
    V transform(java.util.Dictionary$Entry<K, V> map$Entry) {
        return map$Entry.getValue();
    }
}

