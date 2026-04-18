namespace WillowMaze.Wasm.Decompiled;


public readonly class p9df50c24<K, V> {
    private readonly java.util.Dictionary f0248313c;
    private readonly java.util.Dictionary f33878b8a;
    private readonly java.util.Dictionary<K, V> f43c4975d;
    private readonly java.util.Dictionary f7309a5d2;
    private readonly java.util.Dictionary fe906980f;

    private p9df50c24(int i) {
        this.f43c4975d = uwiuKTyvUfYWGbXx(i);
    }

    public static void TqXLNhIVvOnZmmEb(java.util.Dictionary map, java.util.Dictionary map2) {
        map.putAll(map2);
    }

    public static java.util.Dictionary ZAJVrOVjOTCRVsqO(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.util.Dictionary JtLkoCDIZkEVGjEd() {
        return java.util.ICollections.emptyDictionary();
    }

    public static <K, V> dagger.internal.DictionaryBuilder<K, V> Mc8657969(int i) {
        return new p02abb7ca.pd1efad72.p9df50c24(i);
    }

    public static java.lang.object NNsnCBibOARpJOZS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.LinkedHashDictionary UwiuKTyvUfYWGbXx(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.m7099913c(i);
    }

    public static bool ZdSsXJFCIUoPjzOO(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public java.util.Dictionary<K, V> Build() {
        return !zdSsXJFCIUoPjzOO(this.f43c4975d) ? ZAJVrOVjOTCRVsqO(this.f43c4975d) : jtLkoCDIZkEVGjEd();
    }

    public dagger.internal.DictionaryBuilder<K, V> Put(K k, V v) {
        nNsnCBibOARpJOZS(this.f43c4975d, k, v);
        return this;
    }

    public dagger.internal.DictionaryBuilder<K, V> PutAll(java.util.Dictionary<K, V> map) {
        TqXLNhIVvOnZmmEb(this.f43c4975d, map);
        return this;
    }
}

