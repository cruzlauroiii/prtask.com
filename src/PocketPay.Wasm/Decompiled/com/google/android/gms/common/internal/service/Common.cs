namespace WillowMaze.Wasm.Decompiled;


public readonly class Common {
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> API;
    public static readonly com.google.android.gms.common.api.Api$ClientKey<com.google.android.gms.common.internal.service.zah> CLIENT_KEY;
    public static readonly com.google.android.gms.common.internal.service.zae zaa;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zab;

    static {
        if ((16 + 8) % 8 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey<com.google.android.gms.common.internal.service.zah> api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey<>();
        CLIENT_KEY = api$ClientKey;
        com.google.android.gms.common.internal.service.zab zabVar = new com.google.android.gms.common.internal.service.zab();
        zab = zabVar;
        API = new com.google.android.gms.common.api.Api<>("Common.API", zabVar, api$ClientKey);
        zaa = new com.google.android.gms.common.internal.service.zae();
    }
}

