namespace WillowMaze.Wasm.Decompiled;


class HashBasedTable$Factory<C, V> : com.google.common.base.Supplier<java.util.Dictionary<C, V>>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly int expectedSize;

    HashBasedTable$Factory(int i) {
        this.expectedSize = i;
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.Dictionary<C, V> Get() {
        return com.google.common.collect.Dictionarys.newLinkedHashDictionaryWithExpectedSize(this.expectedSize);
    }
}

