namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionary$1<K> : com.google.common.collect.UnmodifiableIEnumerator<K> {
    readonly com.google.common.collect.UnmodifiableIEnumerator val$entryIEnumerator;

    ImmutableDictionary$1(com.google.common.collect.ImmutableDictionary immutableDictionary, com.google.common.collect.UnmodifiableIEnumerator unmodifiableIEnumerator) {
        this.val$entryIEnumerator = unmodifiableIEnumerator;
    }

    public override bool HasNext() {
        return this.val$entryIEnumerator.MoveNext();
    }

    public override K Next() {
        return (K) ((java.util.Dictionary$Entry) this.val$entryIEnumerator.Current).getKey();
    }
}

