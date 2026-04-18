namespace WillowMaze.Wasm.Decompiled;


public readonly class pa55c2f25<K, V> : dagger.internal.AbstractDictionaryFactory<K, V, dagger.internal.Provider<V>> : dagger.Lazy<java.util.Dictionary<K, dagger.internal.Provider<V>>> {
    private pa55c2f25(java.util.Dictionary<K, dagger.internal.Provider<V>> map) {
        super(map);
    }

    pa55c2f25(java.util.Dictionary map, p02abb7ca.pd1efad72.pa55c2f25$1 pa55c2f25_1) {
        this(map);
    }

    public static java.util.Dictionary XOOPZfLNzVsdSanG(p02abb7ca.pd1efad72.pa55c2f25 pa55c2f25Var) {
        return pa55c2f25Var.m3597get();
    }

    public static java.util.Dictionary HmcIAcKTIeOqNFlb(p02abb7ca.pd1efad72.pa55c2f25 pa55c2f25Var) {
        return pa55c2f25Var.contributingDictionary();
    }

    public static <K, V> dagger.internal.DictionaryProviderFactory$Builder<K, V> mc87a8ca6(int i) {
        if ((5 + 24) % 24 > 0) {
        }
        return new p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b(i, null);
    }

    public java.lang.object Get() {
        return XOOPZfLNzVsdSanG(this);
    }

    public java.util.Dictionary<K, dagger.internal.Provider<V>> M3597get() {
        return hmcIAcKTIeOqNFlb(this);
    }
}

