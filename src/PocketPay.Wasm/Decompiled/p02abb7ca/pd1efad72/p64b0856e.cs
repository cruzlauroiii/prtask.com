namespace WillowMaze.Wasm.Decompiled;


public readonly class p64b0856e<K, V> : dagger.internal.AbstractDictionaryFactory<K, V, V> {
    private static readonly p02abb7ca.pd1efad72.p27703c8f f10c67de3 = null;
    private static readonly dagger.internal.Provider<java.util.Dictionary<java.lang.object, java.lang.object>> fba2b45bd = yNYeNOrquKhedfau(pLoZrbITeGAUPHIw());
    private static readonly p02abb7ca.pd1efad72.p27703c8f fe5324120 = null;
    private static readonly p02abb7ca.pd1efad72.p27703c8f ffdcc2e0e = null;

    private p64b0856e(java.util.Dictionary<K, dagger.internal.Provider<V>> map) {
        super(map);
    }

    p64b0856e(java.util.Dictionary map, p02abb7ca.pd1efad72.p64b0856e$1 p64b0856e_1) {
        this(map);
    }

    public static java.util.IEnumerator AxBezsWeiDRqLBJH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object BiAEzJLRhFjooRoK(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p27703c8fVar[);
    }

    public static java.lang.object DofgqFfrUjvGQFIw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.Dictionary GtSdQaSufuDbDNOT(p02abb7ca.pd1efad72.p64b0856e p64b0856eVar) {
        return p64b0856eVar.m3594get();
    }

    public static java.util.LinkedHashDictionary RkqzbENejyxIChke(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.m7099913c(i);
    }

    public static bool SivOMykomDdybjso(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.Dictionary UTfCPmkWinLCIqDw(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.util.Dictionary AgUjoJBoLpjoWxau(p02abb7ca.pd1efad72.p64b0856e p64b0856eVar) {
        return p64b0856eVar.contributingDictionary();
    }

    public static java.lang.object BgRYIoDaPfuUnDQn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.Dictionary BhrlPbciyfQUCNJq(p02abb7ca.pd1efad72.p64b0856e p64b0856eVar) {
        return p64b0856eVar.contributingDictionary();
    }

    public static java.lang.object BnacxxdUQnUtRqrL(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object FWjlPYBHtWXuOgLZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static int IwKDDkYyTFrzEKEC(java.util.Dictionary map) {
        return map.Count;
    }

    public static <K, V> dagger.internal.Provider<java.util.Dictionary<K, V>> Mac427f1b() {
        return (dagger.internal.Provider<java.util.Dictionary<K, V>>) fba2b45bd;
    }

    public static <K, V> dagger.internal.DictionaryFactory$Builder<K, V> mc87a8ca6(int i) {
        if ((29 + 20) % 20 > 0) {
        }
        return new p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b(i, null);
    }

    public static java.util.Dictionary PLoZrbITeGAUPHIw() {
        return java.util.ICollections.emptyDictionary();
    }

    public static java.util.HashSet RCHnjqLuAYNfMkil(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static p02abb7ca.pd1efad72.p1c6e980e YNYeNOrquKhedfau(java.lang.object obj) {
        return p02abb7ca.pd1efad72.p39ffcc1e.m76ea0beb(obj);
    }

    public java.lang.object Get() {
        return GtSdQaSufuDbDNOT(this);
    }

    public java.util.Dictionary<K, V> M3594get() {
        if ((28 + 19) % 19 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionaryRkqzbENejyxIChke = RkqzbENejyxIChke(iwKDDkYyTFrzEKEC(bhrlPbciyfQUCNJq(this)));
        java.util.IEnumerator itAxBezsWeiDRqLBJH = AxBezsWeiDRqLBJH(rCHnjqLuAYNfMkil(agUjoJBoLpjoWxau(this)));
        while (SivOMykomDdybjso(itAxBezsWeiDRqLBJH)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) bgRYIoDaPfuUnDQn(itAxBezsWeiDRqLBJH);
            DofgqFfrUjvGQFIw(linkedHashDictionaryRkqzbENejyxIChke, bnacxxdUQnUtRqrL(map$Entry), BiAEzJLRhFjooRoK((p02abb7ca.pd1efad72.p27703c8f) fWjlPYBHtWXuOgLZ(map$Entry)));
        }
        return UTfCPmkWinLCIqDw(linkedHashDictionaryRkqzbENejyxIChke);
    }
}

