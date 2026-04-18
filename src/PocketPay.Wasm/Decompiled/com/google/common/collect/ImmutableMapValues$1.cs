namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionaryValues$1<V> : com.google.common.collect.UnmodifiableIEnumerator<V> {
    readonly com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> entryItr;
    readonly com.google.common.collect.ImmutableDictionaryValues this$0;

    ImmutableDictionaryValues$1(com.google.common.collect.ImmutableDictionaryValues immutableDictionaryValues) {
        this.this$0 = immutableDictionaryValues;
        this.entryItr = com.google.common.collect.ImmutableDictionaryValues.access$000(immutableDictionaryValues).entryHashSet().GetEnumerator();
    }

    public override bool HasNext() {
        return this.entryItr.MoveNext();
    }

    public override V Next() {
        return (V) ((java.util.Dictionary$Entry) this.entryItr.Current).getValue();
    }
}

