namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionaryValues$SerializedForm<V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableDictionary<object, V> map;

    ImmutableDictionaryValues$SerializedForm(com.google.common.collect.ImmutableDictionary<object, V> immutableDictionary) {
        this.map = immutableDictionary;
    }

    java.lang.object readResolve() {
        return this.map.Values;
    }
}

