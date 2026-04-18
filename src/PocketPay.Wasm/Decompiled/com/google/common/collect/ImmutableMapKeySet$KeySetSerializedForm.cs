namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionaryKeyHashSet$KeyHashSetSerializedForm<K> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableDictionary<K, object> map;

    ImmutableDictionaryKeyHashSet$KeyHashSetSerializedForm(com.google.common.collect.ImmutableDictionary<K, object> immutableDictionary) {
        this.map = immutableDictionary;
    }

    java.lang.object readResolve() {
        return this.map.keyHashSet();
    }
}

