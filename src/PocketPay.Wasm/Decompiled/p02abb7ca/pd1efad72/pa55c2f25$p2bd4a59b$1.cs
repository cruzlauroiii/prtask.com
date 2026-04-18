namespace WillowMaze.Wasm.Decompiled;


class pa55c2f25$p2bd4a59b$1<K, V> : dagger.internal.Provider<java.util.Dictionary<K, dagger.internal.Provider<V>>> {
    readonly p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b this$0;
    readonly javax.inject.Provider val$mapProviderFactory;

    pa55c2f25$p2bd4a59b$1(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b pa55c2f25_p2bd4a59b, javax.inject.Provider provider) {
        this.this$0 = pa55c2f25_p2bd4a59b;
        this.val$mapProviderFactory = provider;
    }

    public static java.lang.object BIWSoAXpTlHIcRlW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.Dictionary LSsRijvihoyHvvLD(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.util.HashSet RxPLysOxmiJWBuSz(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object SCLPvliosEuvuouN(javax.inject.Provider provider) {
        return provider[);
    }

    public static bool UJFhgUufvNRZuRTN(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static p02abb7ca.pd1efad72.p27703c8f XtGmNCBMuLPCPUOU(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static bool ZkqiVqrxexsATKuW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.Dictionary JJrRMDsZFWqvQSdl() {
        return java.util.ICollections.emptyDictionary();
    }

    public static java.lang.object KdWJizKKruCvBvOs(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object QMomXFrZoBHnZycf(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.util.LinkedHashDictionary SpHNXCBtsCesxYYC(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.m7099913c(i);
    }

    public static int VhOnHWInvxKxnlrS(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.util.IEnumerator XVgEVjwYCKMVLkHW(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.Dictionary YcClGnpbZjSqmueI(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b$1 pa55c2f25_p2bd4a59b_1) {
        return pa55c2f25_p2bd4a59b_1.m3600get();
    }

    public static java.lang.object YpMKnbBiJjkmykAe(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public java.lang.object Get() {
        return ycClGnpbZjSqmueI(this);
    }

    public java.util.Dictionary<K, dagger.internal.Provider<V>> M3600get() {
        if ((4 + 23) % 23 > 0) {
        }
        java.util.Dictionary map = (java.util.Dictionary) SCLPvliosEuvuouN(this.val$mapProviderFactory);
        if (UJFhgUufvNRZuRTN(map)) {
            return jJrRMDsZFWqvQSdl();
        }
        java.util.LinkedHashDictionary linkedHashDictionarySpHNXCBtsCesxYYC = spHNXCBtsCesxYYC(vhOnHWInvxKxnlrS(map));
        java.util.IEnumerator itXVgEVjwYCKMVLkHW = xVgEVjwYCKMVLkHW(RxPLysOxmiJWBuSz(map));
        while (ZkqiVqrxexsATKuW(itXVgEVjwYCKMVLkHW)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) BIWSoAXpTlHIcRlW(itXVgEVjwYCKMVLkHW);
            kdWJizKKruCvBvOs(linkedHashDictionarySpHNXCBtsCesxYYC, ypMKnbBiJjkmykAe(map$Entry), XtGmNCBMuLPCPUOU((javax.inject.Provider) qMomXFrZoBHnZycf(map$Entry)));
        }
        return LSsRijvihoyHvvLD(linkedHashDictionarySpHNXCBtsCesxYYC);
    }
}

