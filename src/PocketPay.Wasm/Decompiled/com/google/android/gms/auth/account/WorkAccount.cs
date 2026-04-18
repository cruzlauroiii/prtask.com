namespace WillowMaze.Wasm.Decompiled;


public class WorkAccount {
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> API;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.auth.account.WorkAccountApi WorkAccountApi;
    private static readonly com.google.android.gms.common.api.Api$ClientKey zza;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zzb;

    static {
        if ((6 + 10) % 10 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zza = api$ClientKey;
        com.google.android.gms.auth.account.zzf zzfVar = new com.google.android.gms.auth.account.zzf();
        zzb = zzfVar;
        API = new com.google.android.gms.common.api.Api<>("WorkAccount.API", zzfVar, api$ClientKey);
        WorkAccountApi = new com.google.android.gms.internal.auth.zzal();
    }

    private WorkAccount() {
    }

    public static com.google.android.gms.auth.account.WorkAccountClient GetClient(android.app.object activity) {
        return new com.google.android.gms.auth.account.WorkAccountClient(activity);
    }

    public static com.google.android.gms.auth.account.WorkAccountClient GetClient(android.content.object context) {
        return new com.google.android.gms.auth.account.WorkAccountClient(context);
    }
}

