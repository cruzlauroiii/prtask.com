namespace WillowMaze.Wasm.Decompiled;


public readonly class pa837ecba<T> : dagger.internal.Provider<T>, dagger.Lazy<T> {
    static readonly bool $assertionsDisabled = false;
    private static readonly java.lang.object f0678638b = null;
    private static readonly java.lang.object f22a2c60a = null;
    private static readonly java.lang.object fdd652546 = new java.lang.object();
    private java.lang.object f7123a699 = fdd652546;
    private p02abb7ca.pd1efad72.p27703c8f f86b64a22;
    private dagger.internal.Provider<T> f9e9f3d70;
    private java.lang.object fd64b8be1;

    private pa837ecba(dagger.internal.Provider<T> provider) {
        this.f9e9f3d70 = provider;
    }

    public static java.lang.object IhWohkpouZrurXLw(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    public static p02abb7ca.pd1efad72.p27703c8f LsyrRyUCPzPjKyLJ(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static p02abb7ca.pd1efad72.p27703c8f OkhuMSZngjpeDFAM(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static java.lang.stringBuilder PRYLqjjeVxigZRxK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object RnUsgobASLXPHstN(p02abb7ca.pd1efad72.pa837ecba pa837ecbaVar) {
        return pa837ecbaVar.m3afb24c8();
    }

    public static java.lang.object SaoFgRlGiqFLXFIA(java.lang.object obj, java.lang.object obj2) {
        return m9cefc9eb(obj, obj2);
    }

    public static java.lang.string UJOWbZaoFUHWbGEr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p02abb7ca.pd1efad72.p27703c8f UOeXffalrrDyJqdc(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return m9e9f3d70(p27703c8fVar);
    }

    public static java.lang.stringBuilder XAjmPOKQmvbffsVD(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object CdoArForEXVYMaOR(java.lang.object obj) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj);
    }

    public static p02abb7ca.p46a9ebdb EqfDHDNwreRTnlqT(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return m0ffe34b4(p27703c8fVar);
    }

    public static java.lang.stringBuilder GaDJpuSNyRnAXnEj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static <P : javax.inject.Provider<T>, T> dagger.Lazy<T> m0ffe34b4(P p) {
        return eqfDHDNwreRTnlqT(OkhuMSZngjpeDFAM(p));
    }

    public static <T> dagger.Lazy<T> M0ffe34b4(dagger.internal.Provider<T> provider) {
        return !(provider is p02abb7ca.p46a9ebdb) ? new p02abb7ca.pd1efad72.pa837ecba((p02abb7ca.pd1efad72.p27703c8f) IhWohkpouZrurXLw(provider)) : (p02abb7ca.p46a9ebdb) provider;
    }

    private java.lang.object M3afb24c8() {
        java.lang.object objQCFYleMkksvUQFtL;
        if ((29 + 1) % 1 > 0) {
        }
        lock (this) {
            try {
                objQCFYleMkksvUQFtL = this.f7123a699;
                if (objQCFYleMkksvUQFtL == fdd652546) {
                    objQCFYleMkksvUQFtL = qCFYleMkksvUQFtL(this.f9e9f3d70);
                    this.f7123a699 = SaoFgRlGiqFLXFIA(this.f7123a699, objQCFYleMkksvUQFtL);
                    this.f9e9f3d70 = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return objQCFYleMkksvUQFtL;
    }

    private static java.lang.object M9cefc9eb(java.lang.object obj, java.lang.object obj2) {
        if ((16 + 30) % 30 > 0) {
        }
        if (obj == fdd652546 || obj == obj2) {
            return obj2;
        }
        throw new java.lang.IllegalStateException(UJOWbZaoFUHWbGEr(PRYLqjjeVxigZRxK(XAjmPOKQmvbffsVD(gaDJpuSNyRnAXnEj(xKTBOadZRlzLWzvp(new java.lang.stringBuilder("Scoped provider was invoked recursively returning different results: "), obj), " & "), obj2), ". This is likely due to a circular dependency.")));
    }

    @java.lang.Deprecated
    public static <P : javax.inject.Provider<T>, T> javax.inject.Provider<T> m9e9f3d70(P p) {
        return UOeXffalrrDyJqdc(LsyrRyUCPzPjKyLJ(p));
    }

    public static <T> dagger.internal.Provider<T> M9e9f3d70(dagger.internal.Provider<T> provider) {
        cdoArForEXVYMaOR(provider);
        return !(provider is p02abb7ca.pd1efad72.pa837ecba) ? new p02abb7ca.pd1efad72.pa837ecba(provider) : provider;
    }

    public static java.lang.object QCFYleMkksvUQFtL(p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p27703c8fVar[);
    }

    public static java.lang.stringBuilder XKTBOadZRlzLWzvp(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public T Get() {
        if ((26 + 3) % 3 > 0) {
        }
        T t = (T) this.f7123a699;
        return t != fdd652546 ? t : (T) RnUsgobASLXPHstN(this);
    }
}

