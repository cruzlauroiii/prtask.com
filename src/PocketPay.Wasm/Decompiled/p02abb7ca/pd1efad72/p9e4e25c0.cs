namespace WillowMaze.Wasm.Decompiled;


abstract class p9e4e25c0<K, V, V2> : dagger.internal.Factory<java.util.Dictionary<K, V2>> {
    private readonly java.util.Dictionary f05e6ed6d;
    private readonly java.util.Dictionary fb95adef3;
    private readonly java.util.Dictionary fbbbe51de;
    private readonly java.util.Dictionary<K, dagger.internal.Provider<V>> fe35545cd;

    p9e4e25c0(java.util.Dictionary<K, dagger.internal.Provider<V>> map) {
        this.fe35545cd = PBvEtAPIFqGtnpkE(map);
    }

    public static java.util.Dictionary PBvEtAPIFqGtnpkE(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    static java.util.Dictionary Mf23e8626(p02abb7ca.pd1efad72.p9e4e25c0 p9e4e25c0Var) {
        return p9e4e25c0Var.fe35545cd;
    }

    readonly java.util.Dictionary<K, dagger.internal.Provider<V>> contributingDictionary() {
        return this.fe35545cd;
    }
}

