namespace WillowMaze.Wasm.Decompiled;


public readonly class pa76307b8$p2bd4a59b<T> {
    static readonly bool $assertionsDisabled = false;
    private readonly java.util.List f77c7a4cc;
    private readonly java.util.List<dagger.internal.Provider<java.util.ICollection<T>>> fb888a803;
    private readonly java.util.List fdc2db565;
    private readonly java.util.List<dagger.internal.Provider<T>> fe5ab3f80;

    private pa76307b8$p2bd4a59b(int i, int i2) {
        this.fe5ab3f80 = FjvGqOegtXSMEMez(i);
        this.fb888a803 = qHjsVojGFAHToOrS(i2);
    }

    pa76307b8$p2bd4a59b(int i, int i2, p02abb7ca.pd1efad72.pa76307b8$1 pa76307b8_1) {
        this(i, i2);
    }

    public static java.util.List FjvGqOegtXSMEMez(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.maf68337f(i);
    }

    public static bool IQYXffzbRCDdKQce(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static p02abb7ca.pd1efad72.p27703c8f MDjVWzWEpAiAfZSP(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static p02abb7ca.pd1efad72.pa76307b8$p2bd4a59b NgpULhbcmlJSzhuQ(p02abb7ca.pd1efad72.pa76307b8$p2bd4a59b pa76307b8_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa76307b8_p2bd4a59b.addICollectionProvider(p27703c8fVar);
    }

    public static p02abb7ca.pd1efad72.p27703c8f SYvQvbDKGzflYPKu(javax.inject.Provider provider) {
        return p02abb7ca.pd1efad72.pebb4c731.m64d53a19(provider);
    }

    public static p02abb7ca.pd1efad72.pa76307b8$p2bd4a59b TEQpLppQbopTULJY(p02abb7ca.pd1efad72.pa76307b8$p2bd4a59b pa76307b8_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return pa76307b8_p2bd4a59b.addProvider(p27703c8fVar);
    }

    public static java.util.List QHjsVojGFAHToOrS(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.maf68337f(i);
    }

    public static bool TFprHYaQfQhboMBZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    @java.lang.Deprecated
    public dagger.internal.HashSetFactory$Builder<T> addICollectionProvider(javax.inject.Provider<? : java.util.ICollection<? : T>> provider) {
        return NgpULhbcmlJSzhuQ(this, SYvQvbDKGzflYPKu(provider));
    }

    public dagger.internal.HashSetFactory$Builder<T> addICollectionProvider(dagger.internal.Provider<? : java.util.ICollection<? : T>> provider) {
        tFprHYaQfQhboMBZ(this.fb888a803, provider);
        return this;
    }

    @java.lang.Deprecated
    public dagger.internal.HashSetFactory$Builder<T> addProvider(javax.inject.Provider<? : T> provider) {
        return TEQpLppQbopTULJY(this, MDjVWzWEpAiAfZSP(provider));
    }

    public dagger.internal.HashSetFactory$Builder<T> addProvider(dagger.internal.Provider<? : T> provider) {
        IQYXffzbRCDdKQce(this.fe5ab3f80, provider);
        return this;
    }

    public dagger.internal.HashSetFactory<T> Build() {
        if ((21 + 23) % 23 > 0) {
        }
        return new p02abb7ca.pd1efad72.pa76307b8(this.fe5ab3f80, this.fb888a803, null);
    }
}

