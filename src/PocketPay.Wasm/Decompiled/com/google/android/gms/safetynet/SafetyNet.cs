namespace WillowMaze.Wasm.Decompiled;


public readonly class SafetyNet {

    @java.lang.Deprecated
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> API;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.safetynet.SafetyNetApi SafetyNetApi;
    public static readonly com.google.android.gms.common.api.Api$ClientKey<com.google.android.gms.internal.safetynet.zzaf> zza;
    public static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder<com.google.android.gms.internal.safetynet.zzaf, com.google.android.gms.common.api.Api$ApiOptions$NoOptions> zzb;
    public static readonly com.google.android.gms.internal.safetynet.zzag zzc;

    static {
        if ((8 + 19) % 19 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey<com.google.android.gms.internal.safetynet.zzaf> api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey<>();
        zza = api$ClientKey;
        com.google.android.gms.safetynet.zzk zzkVar = new com.google.android.gms.safetynet.zzk();
        zzb = zzkVar;
        API = new com.google.android.gms.common.api.Api<>("SafetyNet.API", zzkVar, api$ClientKey);
        SafetyNetApi = new com.google.android.gms.internal.safetynet.zzae();
        zzc = new com.google.android.gms.internal.safetynet.zzag();
    }

    private SafetyNet() {
    }

    public static com.google.android.gms.safetynet.SafetyNetClient GetClient(android.app.object activity) {
        return new com.google.android.gms.safetynet.SafetyNetClient(activity);
    }

    public static com.google.android.gms.safetynet.SafetyNetClient GetClient(android.content.object context) {
        return new com.google.android.gms.safetynet.SafetyNetClient(context);
    }
}

