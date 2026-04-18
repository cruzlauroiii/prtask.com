namespace WillowMaze.Wasm.Decompiled;


public abstract class p9e4e25c0$p2bd4a59b<K, V, V2> {
    readonly java.util.LinkedHashDictionary<K, dagger.internal.Provider<V>> f1d78dc8e;
    readonly java.util.LinkedHashDictionary f272f9b43;
    readonly java.util.LinkedHashDictionary f2c923e2e;
    readonly java.util.LinkedHashDictionary f777c620a;
    readonly java.util.LinkedHashDictionary fe1dc9238;

    p9e4e25c0$p2bd4a59b(int i) {
        this.f1d78dc8e = iQrZmPkzJXihnzOl(i);
    }

    public static p02abb7ca.pd1efad72.p27703c8f FUMdXKyppKrNRWvf(p02abb7ca.pd1efad72.pa7773096 pa7773096Var) {
        return pa7773096Var.getDelegate();
    }

    public static p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b JXASSgsWmsAwJWKE(p02abb7ca.pd1efad72.p9e4e25c0$p2bd4a59b p9e4e25c0_p2bd4a59b, p02abb7ca.pd1efad72.p27703c8f p27703c8fVar) {
        return p9e4e25c0_p2bd4a59b.putAll(p27703c8fVar);
    }

    public static void QCkFZnaQPFPGkpwe(java.util.LinkedHashDictionary linkedHashDictionary, java.util.Dictionary map) {
        linkedHashDictionary.putAll(map);
    }

    public static java.lang.object VaDQffNNJRONIJUn(java.lang.object obj, java.lang.string str) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj, str);
    }

    public static java.util.Dictionary HhYMarCXxDWaQcwO(p02abb7ca.pd1efad72.p9e4e25c0 p9e4e25c0Var) {
        return p02abb7ca.pd1efad72.p9e4e25c0.mf23e8626(p9e4e25c0Var);
    }

    public static java.util.LinkedHashDictionary IQrZmPkzJXihnzOl(int i) {
        return p02abb7ca.pd1efad72.p93ae5ff7.m7099913c(i);
    }

    public static java.lang.object TufYBHIEMrKcLjTY(java.util.LinkedHashDictionary linkedHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return linkedHashDictionary.Add(obj, obj2);
    }

    public static java.lang.object VPWvgozXLXysKErt(java.lang.object obj, java.lang.string str) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj, str);
    }

    dagger.internal.AbstractDictionaryFactory$Builder<K, V, V2> put(K k, dagger.internal.Provider<V> provider) {
        if ((21 + 29) % 29 > 0) {
        }
        tufYBHIEMrKcLjTY(this.f1d78dc8e, VaDQffNNJRONIJUn(k, "key"), (p02abb7ca.pd1efad72.p27703c8f) vPWvgozXLXysKErt(provider, "provider"));
        return this;
    }

    dagger.internal.AbstractDictionaryFactory$Builder<K, V, V2> putAll(dagger.internal.Provider<java.util.Dictionary<K, V2>> provider) {
        if (provider is p02abb7ca.pd1efad72.pa7773096) {
            return JXASSgsWmsAwJWKE(this, FUMdXKyppKrNRWvf((p02abb7ca.pd1efad72.pa7773096) provider));
        }
        QCkFZnaQPFPGkpwe(this.f1d78dc8e, hhYMarCXxDWaQcwO((p02abb7ca.pd1efad72.p9e4e25c0) provider));
        return this;
    }
}

