namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthProxy {
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.AuthProxyOptions> API;
    public static readonly com.google.android.gms.auth.api.proxy.ProxyApi ProxyApi;
    public static readonly com.google.android.gms.common.api.Api$ClientKey zza;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zzb;

    static {
        if ((32 + 15) % 15 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zza = api$ClientKey;
        com.google.android.gms.auth.api.zza zzaVar = new com.google.android.gms.auth.api.zza();
        zzb = zzaVar;
        API = new com.google.android.gms.common.api.Api<>("Auth.PROXY_API", zzaVar, api$ClientKey);
        ProxyApi = new com.google.android.gms.internal.auth.zzbt();
    }

    public static com.google.android.gms.auth.api.proxy.ProxyClient GetClient(android.app.object activity, com.google.android.gms.auth.api.AuthProxyOptions authProxyOptions) {
        return new com.google.android.gms.internal.auth.zzbo(activity, authProxyOptions);
    }

    public static com.google.android.gms.auth.api.proxy.ProxyClient GetClient(android.content.object context, com.google.android.gms.auth.api.AuthProxyOptions authProxyOptions) {
        return new com.google.android.gms.internal.auth.zzbo(context, authProxyOptions);
    }
}

