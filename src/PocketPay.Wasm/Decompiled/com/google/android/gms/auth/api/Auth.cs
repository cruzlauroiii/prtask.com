namespace WillowMaze.Wasm.Decompiled;


public readonly class Auth {
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.signin.GoogleSignInOptions> GOOGLE_SIGN_IN_API;
    public static readonly com.google.android.gms.auth.api.signin.GoogleSignInApi GoogleSignInApi;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.auth.api.AuthProxyOptions> PROXY_API;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.auth.api.proxy.ProxyApi ProxyApi;
    public static readonly com.google.android.gms.common.api.Api$ClientKey zba;
    public static readonly com.google.android.gms.common.api.Api$ClientKey zbb;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zbc;
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zbd;

    static {
        if ((17 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zba = api$ClientKey;
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey2 = new com.google.android.gms.common.api.Api$ClientKey();
        zbb = api$ClientKey2;
        com.google.android.gms.auth.api.zba zbaVar = new com.google.android.gms.auth.api.zba();
        zbc = zbaVar;
        com.google.android.gms.auth.api.zbb zbbVar = new com.google.android.gms.auth.api.zbb();
        zbd = zbbVar;
        PROXY_API = com.google.android.gms.auth.api.AuthProxy.API;
        new com.google.android.gms.common.api.Api("Auth.CREDENTIALS_API", zbaVar, api$ClientKey);
        GOOGLE_SIGN_IN_API = new com.google.android.gms.common.api.Api<>("Auth.GOOGLE_SIGN_IN_API", zbbVar, api$ClientKey2);
        ProxyApi = com.google.android.gms.auth.api.AuthProxy.ProxyApi;
        GoogleSignInApi = new com.google.android.gms.auth.api.signin.internal.zbd();
    }

    private Auth() {
    }
}

