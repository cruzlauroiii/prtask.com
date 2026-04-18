namespace WillowMaze.Wasm.Decompiled;


public readonly class pa7773096<T> : dagger.internal.Factory<T> {
    private p02abb7ca.pd1efad72.p27703c8f f5d43cc73;
    private dagger.internal.Provider<T> f7f662005;

    public static java.lang.object GJIvmpZtLOTGmapK(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p27703c8fVar[);
    }

    public static p02abb7ca.pd1efad72.p27703c8f KvsNQlZlvywkEeGZ(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static java.lang.object MjnqcpplYzejQhEo(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    public static void URhtFkPakoWLkUfs(p02abb7ca.pd1efad72.pa7773096 pa7773096Var, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        m1e77b355(pa7773096Var, p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p27703c8f AGaIHFqRSGrXyGqv(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static void BWfEbIFXIpPqIpED(p02abb7ca.pd1efad72.pa7773096 pa7773096Var, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        m1e77b355(pa7773096Var, p27703c8fVar);
    }

    private static <T> void M1e77b355(dagger.internal.DelegateFactory<T> delegateFactory, dagger.internal.Provider<T> provider) {
        MjnqcpplYzejQhEo(provider);
        if (((p02abb7ca.pd1efad72.pa7773096) delegateFactory).f7f662005 is not null) {
            throw new java.lang.IllegalStateException();
        }
        ((p02abb7ca.pd1efad72.pa7773096) delegateFactory).f7f662005 = provider;
    }

    public static java.lang.object MYjqSnrcUXUPkNHN(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    @java.lang.Deprecated
    public static <T> void Md3f1b02c(javax.inject.Provider<T> provider, javax.inject.Provider<T> provider2) {
        bWfEbIFXIpPqIpED((p02abb7ca.pd1efad72.pa7773096) provider, KvsNQlZlvywkEeGZ(provider2));
    }

    public static <T> void Md3f1b02c(dagger.internal.Provider<T> provider, dagger.internal.Provider<T> provider2) {
        URhtFkPakoWLkUfs((p02abb7ca.pd1efad72.pa7773096) provider, provider2);
    }

    public static void NKWuqfatbVJxfxIH(p02abb7ca.pd1efad72.pa7773096 pa7773096Var, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        pa7773096Var.setDelegatedProvider(p27703c8fVar);
    }

    public static void PhwaZcTNmJGqxbqs(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar2) {
        md3f1b02c(p27703c8fVar, p27703c8fVar2);
    }

    public T Get() {
        dagger.internal.Provider<T> provider = this.f7f662005;
        if (provider is null) {
            throw new java.lang.IllegalStateException();
        }
        return (T) GJIvmpZtLOTGmapK(provider);
    }

    dagger.internal.Provider<T> getDelegate() {
        return (p02abb7ca.pd1efad72.p27703c8f) mYjqSnrcUXUPkNHN(this.f7f662005);
    }

    @java.lang.Deprecated
    public void SetDelegatedProvider(javax.inject.Provider<T> provider) {
        nKWuqfatbVJxfxIH(this, aGaIHFqRSGrXyGqv(provider));
    }

    @java.lang.Deprecated
    public void SetDelegatedProvider(dagger.internal.Provider<T> provider) {
        phwaZcTNmJGqxbqs(this, provider);
    }
}

