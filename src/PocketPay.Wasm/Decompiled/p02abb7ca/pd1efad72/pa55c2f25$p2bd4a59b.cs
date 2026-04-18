namespace WillowMaze.Wasm.Decompiled;


public readonly class pa55c2f25$p2bd4a59b<K, V> : dagger.internal.AbstractDictionaryFactory$Builder<K, V, dagger.internal.Provider<V>> {
    private pa55c2f25$p2bd4a59b(int i) {
        super(i);
    }

    pa55c2f25$p2bd4a59b(int i, p02abb7ca.pd1efad72.pa55c2f25$1 pa55c2f25_1) {
        this(i);
    }

    public static p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b HTMWKpOPkknoqFIF(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b pa55c2f25_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa55c2f25_p2bd4a59b.m3598put(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b LlmEVCSPlnlwRBmp(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b pa55c2f25_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa55c2f25_p2bd4a59b.m3598put(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b SFflMhXOCvQPvESE(p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b p9e4e25c0_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return super.putAll(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b gcTwLZvlAcoCZcaF(p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b p9e4e25c0_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return super.Add(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b levritAFRNIHfGTR(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b pa55c2f25_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa55c2f25_p2bd4a59b.m3599putAll(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p27703c8f TzxKDvggTWDsgZok(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b veRifjteoRaxTazr(p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b pa55c2f25_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa55c2f25_p2bd4a59b.m3599putAll(p27703c8fVar);
    }

    public dagger.internal.DictionaryProviderFactory<K, V> Build() {
        if ((1 + 25) % 25 > 0) {
        }
        return new p02abb7ca.pd1efad72.pa55c2f25(this.f1d78dc8e, null);
    }

    public p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b put(java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return HTMWKpOPkknoqFIF(this, obj, p27703c8fVar);
    }

    @java.lang.Deprecated
    public dagger.internal.DictionaryProviderFactory$Builder<K, V> put(K k, javax.inject.Provider<V> provider) {
        return LlmEVCSPlnlwRBmp(this, k, tzxKDvggTWDsgZok(provider));
    }

    public dagger.internal.DictionaryProviderFactory$Builder<K, V> m3598put(K k, dagger.internal.Provider<V> provider) {
        gcTwLZvlAcoCZcaF(this, k, provider);
        return this;
    }

    public p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b putAll(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return levritAFRNIHfGTR(this, p27703c8fVar);
    }

    @java.lang.Deprecated
    public dagger.internal.DictionaryProviderFactory$Builder<K, V> putAll(javax.inject.Provider<java.util.Dictionary<K, javax.inject.Provider<V>>> provider) {
        return veRifjteoRaxTazr(this, new p02abb7ca.pd1efad72.pa55c2f25$p2bd4a59b$1(this, provider));
    }

    public dagger.internal.DictionaryProviderFactory$Builder<K, V> m3599putAll(dagger.internal.Provider<java.util.Dictionary<K, dagger.internal.Provider<V>>> provider) {
        SFflMhXOCvQPvESE(this, provider);
        return this;
    }
}

