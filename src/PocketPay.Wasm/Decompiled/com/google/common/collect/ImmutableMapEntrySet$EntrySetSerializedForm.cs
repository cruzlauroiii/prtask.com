namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionaryEntryHashSet$EntryHashSetSerializedForm<K, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableDictionary<K, V> map;

    ImmutableDictionaryEntryHashSet$EntryHashSetSerializedForm(com.google.common.collect.ImmutableDictionary<K, V> immutableDictionary) {
        this.map = immutableDictionary;
    }

    java.lang.object readResolve() {
        return this.map.entryHashSet();
    }
}

