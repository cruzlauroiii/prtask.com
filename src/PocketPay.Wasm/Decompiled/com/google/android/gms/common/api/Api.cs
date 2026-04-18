namespace WillowMaze.Wasm.Decompiled;


public readonly class Api<O : com.google.android.gms.common.api.Api$ApiOptions> {
    private readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zaa;
    private readonly com.google.android.gms.common.api.Api$ClientKey zab;
    private readonly java.lang.string zac;

    public <C : com.google.android.gms.common.api.Api$Client> Api(java.lang.string str, com.google.android.gms.common.api.Api$AbstractClientBuilder<C, O> api$AbstractClientBuilder, com.google.android.gms.common.api.Api$ClientKey<C> api$ClientKey) {
        YrcZKDwJkCauAhxr(api$AbstractClientBuilder, "Cannot construct an Api with a null ClientBuilder");
        bdHxidpVillzDGch(api$ClientKey, "Cannot construct an Api with a null ClientKey");
        this.zac = str;
        this.zaa = api$AbstractClientBuilder;
        this.zab = api$ClientKey;
    }

    public static java.lang.object YrcZKDwJkCauAhxr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object BdHxidpVillzDGch(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zaa() {
        return this.zaa;
    }

    public readonly com.google.android.gms.common.api.Api$AnyClientKey zab() {
        return this.zab;
    }

    public readonly com.google.android.gms.common.api.Api$BaseClientBuilder zac() {
        return this.zaa;
    }

    public readonly java.lang.string Zad() {
        return this.zac;
    }
}

