namespace WillowMaze.Wasm.Decompiled;


public readonly class p64b0856e$p2bd4a59b<K, V> : dagger.internal.AbstractDictionaryFactory$Builder<K, V, V> {
    private p64b0856e$p2bd4a59b(int i) {
        super(i);
    }

    p64b0856e$p2bd4a59b(int i, p02abb7ca.pd1efad72.p64b0856e$1 p64b0856e_1) {
        this(i);
    }

    public static p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b DtnTXJheBhMwxlsF(p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b p64b0856e_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p64b0856e_p2bd4a59b.Add(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b VFduUXyAjHSpjSjo(p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b p9e4e25c0_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return super.Add(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b VnOrsKZZNWbnYWUb(p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b p9e4e25c0_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return super.putAll(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b ZnJJFenwRCWpqSsK(p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b p64b0856e_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p64b0856e_p2bd4a59b.putAll(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b bBgFuyNWrhLXMVYF(p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b p64b0856e_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p64b0856e_p2bd4a59b.putAll(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b eCJEfvljhFXgacVq(p02abb7ca.pd1efad72.p64b0856e$p2bd4a59b p64b0856e_p2bd4a59b, java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p64b0856e_p2bd4a59b.Add(obj, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p27703c8f KtcCoKqQqkONLJEd(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static p02abb7ca.pd1efad72.p27703c8f YBElWQBoKspUMKlx(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public dagger.internal.DictionaryFactory<K, V> Build() {
        if ((20 + 1) % 1 > 0) {
        }
        return new p02abb7ca.pd1efad72.p64b0856e(this.f1d78dc8e, null);
    }

    @java.lang.Deprecated
    public dagger.internal.DictionaryFactory$Builder<K, V> put(K k, javax.inject.Provider<V> provider) {
        return eCJEfvljhFXgacVq(this, k, ktcCoKqQqkONLJEd(provider));
    }

    public dagger.internal.DictionaryFactory$Builder<K, V> put(K k, dagger.internal.Provider<V> provider) {
        VFduUXyAjHSpjSjo(this, k, provider);
        return this;
    }

    public p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b m3595put(java.lang.object obj, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return DtnTXJheBhMwxlsF(this, obj, p27703c8fVar);
    }

    @java.lang.Deprecated
    public dagger.internal.DictionaryFactory$Builder<K, V> putAll(javax.inject.Provider<java.util.Dictionary<K, V>> provider) {
        return bBgFuyNWrhLXMVYF(this, yBElWQBoKspUMKlx(provider));
    }

    public dagger.internal.DictionaryFactory$Builder<K, V> putAll(dagger.internal.Provider<java.util.Dictionary<K, V>> provider) {
        VnOrsKZZNWbnYWUb(this, provider);
        return this;
    }

    public p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b m3596putAll(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return ZnJJFenwRCWpqSsK(this, p27703c8fVar);
    }
}

