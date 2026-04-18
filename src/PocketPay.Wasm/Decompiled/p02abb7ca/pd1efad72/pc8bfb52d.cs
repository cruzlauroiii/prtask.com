namespace WillowMaze.Wasm.Decompiled;


public readonly class pc8bfb52d<T> : dagger.internal.Provider<dagger.Lazy<T>> {
    static readonly bool $assertionsDisabled = false;
    private readonly p02abb7ca.pd1efad72.p27703c8f f0bebe3dd;
    private readonly p02abb7ca.pd1efad72.p27703c8f f1e8737d4;
    private readonly dagger.internal.Provider<T> f9e9f3d70;
    private readonly p02abb7ca.pd1efad72.p27703c8f fc8bfcd61;

    private pc8bfb52d(dagger.internal.Provider<T> provider) {
        this.f9e9f3d70 = provider;
    }

    public static p02abb7ca.p46a9ebdb BDmJzFMqrUEuItkf(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p02abb7ca.pd1efad72.pa837ecba.m0ffe34b4(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p27703c8f AWnVIcQdkcYlzCeK(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    @java.lang.Deprecated
    public static <T> dagger.internal.Provider<dagger.Lazy<T>> M76ea0beb(javax.inject.Provider<T> provider) {
        return mtbIwcZfrEgZLbfS(aWnVIcQdkcYlzCeK(provider));
    }

    public static <T> dagger.internal.Provider<dagger.Lazy<T>> M76ea0beb(dagger.internal.Provider<T> provider) {
        return new p02abb7ca.pd1efad72.pc8bfb52d((p02abb7ca.pd1efad72.p27703c8f) pXpxawOWUbDzWXZt(provider));
    }

    public static p02abb7ca.pd1efad72.p27703c8f MtbIwcZfrEgZLbfS(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return m76ea0beb(p27703c8fVar);
    }

    public static p02abb7ca.p46a9ebdb NkcfcXHaGPetOIsQ(p02abb7ca.pd1efad72.pc8bfb52d pc8bfb52dVar) {
        return pc8bfb52dVar.m3602get();
    }

    public static java.lang.object PXpxawOWUbDzWXZt(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    public java.lang.object Get() {
        return nkcfcXHaGPetOIsQ(this);
    }

    public dagger.Lazy<T> M3602get() {
        return BDmJzFMqrUEuItkf(this.f9e9f3d70);
    }
}

