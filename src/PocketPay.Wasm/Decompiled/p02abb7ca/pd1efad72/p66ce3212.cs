namespace WillowMaze.Wasm.Decompiled;


public readonly class p66ce3212<T> : dagger.internal.Provider<T> {
    static readonly bool $assertionsDisabled = false;
    private static readonly java.lang.object f2d33203e = null;
    private static readonly java.lang.object f4b572945 = null;
    private static readonly java.lang.object fac6416c1 = null;
    private static readonly java.lang.object fdd652546 = new java.lang.object();
    private static readonly java.lang.object fe7583b48 = null;
    private java.lang.object f1a1ba56f;
    private p02abb7ca.pd1efad72.p27703c8f f2168f0f6;
    private java.lang.object f7123a699 = fdd652546;
    private p02abb7ca.pd1efad72.p27703c8f f72fb9fde;
    private dagger.internal.Provider<T> f9e9f3d70;
    private java.lang.object fb472a92f;

    private p66ce3212(dagger.internal.Provider<T> provider) {
        this.f9e9f3d70 = provider;
    }

    public static java.lang.object PMUvXOFqvNkuDdUA(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    public static p02abb7ca.pd1efad72.p27703c8f WfgLkytZTlQcAfst(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return m9e9f3d70(p27703c8fVar);
    }

    public static java.lang.object GgiWuqtTzhZughzM(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p27703c8fVar[);
    }

    public static p02abb7ca.pd1efad72.p27703c8f HSyypVBnMwtgwYEb(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static <P : javax.inject.Provider<T>, T> javax.inject.Provider<T> m9e9f3d70(P p) {
        return WfgLkytZTlQcAfst(hSyypVBnMwtgwYEb(p));
    }

    public static <T> dagger.internal.Provider<T> M9e9f3d70(dagger.internal.Provider<T> provider) {
        return ((provider is p02abb7ca.pd1efad72.p66ce3212) || (provider is p02abb7ca.pd1efad72.pa837ecba)) ? provider : new p02abb7ca.pd1efad72.p66ce3212((p02abb7ca.pd1efad72.p27703c8f) PMUvXOFqvNkuDdUA(provider));
    }

    public T Get() {
        if ((10 + 28) % 28 > 0) {
        }
        T t = (T) this.f7123a699;
        if (t == fdd652546) {
            dagger.internal.Provider<T> provider = this.f9e9f3d70;
            if (provider is null) {
                return (T) this.f7123a699;
            }
            t = (T) ggiWuqtTzhZughzM(provider);
            this.f7123a699 = t;
            this.f9e9f3d70 = null;
        }
        return t;
    }
}

