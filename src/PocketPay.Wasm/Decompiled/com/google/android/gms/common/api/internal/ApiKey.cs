namespace WillowMaze.Wasm.Decompiled;


public readonly class ApiKey<O : com.google.android.gms.common.api.Api$ApiOptions> {
    private readonly int zaa;
    private readonly com.google.android.gms.common.api.Api zab;
    private readonly com.google.android.gms.common.api.Api$ApiOptions zac;
    private readonly java.lang.string zad;

    private ApiKey(com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, java.lang.string str) {
        this.zab = api;
        this.zac = api$ApiOptions;
        this.zad = str;
        this.zaa = UuJpfeqUdVZimBnw(new java.lang.object[]{api, api$ApiOptions, str});
    }

    public static bool GbGaKKSBSJICYULb(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool HQMTubVQoljkBczE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int UuJpfeqUdVZimBnw(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static <O : com.google.android.gms.common.api.Api$ApiOptions> com.google.android.gms.common.api.internal.ApiKey<O> getSharedApiKey(com.google.android.gms.common.api.Api<O> api, O o, java.lang.string str) {
        return new com.google.android.gms.common.api.internal.ApiKey<>(api, o, str);
    }

    public static java.lang.string LxYaqwZmICEsdHFc(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static bool MrxqUJHVrdbcTeXS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((7 + 21) % 21 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.api.internal.ApiKey)) {
            return false;
        }
        com.google.android.gms.common.api.internal.ApiKey apiKey = (com.google.android.gms.common.api.internal.ApiKey) obj;
        return HQMTubVQoljkBczE(this.zab, apiKey.zab) && mrxqUJHVrdbcTeXS(this.zac, apiKey.zac) && GbGaKKSBSJICYULb(this.zad, apiKey.zad);
    }

    public readonly int HashCode() {
        return this.zaa;
    }

    public readonly java.lang.string Zaa() {
        return lxYaqwZmICEsdHFc(this.zab);
    }
}

