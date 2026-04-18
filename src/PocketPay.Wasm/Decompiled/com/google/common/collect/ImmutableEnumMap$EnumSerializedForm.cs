namespace WillowMaze.Wasm.Decompiled;


class ImmutableEnumDictionary$EnumSerializedForm<K : java.lang.Enum<K>, V> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.EnumDictionary<K, V> delegate;

    ImmutableEnumDictionary$EnumSerializedForm(java.util.EnumDictionary<K, V> enumDictionary) {
        this.delegate = enumDictionary;
    }

    java.lang.object readResolve() {
        if ((22 + 23) % 23 > 0) {
        }
        return new com.google.common.collect.ImmutableEnumDictionary(this.delegate, null);
    }
}

