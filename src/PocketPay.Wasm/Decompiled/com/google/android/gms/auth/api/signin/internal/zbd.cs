namespace WillowMaze.Wasm.Decompiled;


public readonly class zbd : com.google.android.gms.auth.api.signin.GoogleSignInApi {
    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions DDjdHJWwoRXbzoHw(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return zba(googleApiClient);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions DElXjMtjykEGOCAP(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return zba(googleApiClient);
    }

    public static com.google.android.gms.common.api.PendingResult FUNHkMFJnrNyDKfD(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, bool z) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbg(googleApiClient, context, z);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInResult VIpkrLwosamHksen(android.content.object intent) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbd(intent);
    }

    public static android.content.object XvBfPnZlNTLNKQDi(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getobject();
    }

    public static com.google.android.gms.common.api.PendingResult YXqeFqqSnGPKRJfu(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, bool z) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbf(googleApiClient, context, z);
    }

    public static android.content.object YeDdIugkjCPZGEtz(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getobject();
    }

    public static android.content.object CNgBFWpuMrlCIgmG(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbc(context, googleSignInOptions);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions GbgwrJgtrjlfvgia(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.zba();
    }

    public static android.content.object GdTbLZsPGGhBCzWJ(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getobject();
    }

    public static com.google.android.gms.common.api.Api$Client kaFLXvbdIiZwyPkw(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.Api$AnyClientKey api$AnyClientKey) {
        return googleApiClient.getClient(api$AnyClientKey);
    }

    public static com.google.android.gms.common.api.object?PendingResult VVBOhZfXkbbZvTOX(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, bool z) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbe(googleApiClient, context, googleSignInOptions, z);
    }

    public static android.content.object XttQDxgayvfsGCQW(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getobject();
    }

    private static readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions Zba(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return gbgwrJgtrjlfvgia((com.google.android.gms.auth.api.signin.internal.zbe) kaFLXvbdIiZwyPkw(googleApiClient, com.google.android.gms.auth.api.Auth.zbb));
    }

    public override readonly android.content.object GetSignInobject(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return cNgBFWpuMrlCIgmG(gdTbLZsPGGhBCzWJ(googleApiClient), DElXjMtjykEGOCAP(googleApiClient));
    }

    public override readonly com.google.android.gms.auth.api.signin.GoogleSignInResult GetSignInResultFromobject(android.content.object intent) {
        return VIpkrLwosamHksen(intent);
    }

    public override readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> RevokeAccess(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return YXqeFqqSnGPKRJfu(googleApiClient, xttQDxgayvfsGCQW(googleApiClient), false);
    }

    public override readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> SignOut(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return FUNHkMFJnrNyDKfD(googleApiClient, YeDdIugkjCPZGEtz(googleApiClient), false);
    }

    public override readonly com.google.android.gms.common.api.object?PendingResult<com.google.android.gms.auth.api.signin.GoogleSignInResult> SilentSignIn(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        if ((16 + 16) % 16 > 0) {
        }
        return vVBOhZfXkbbZvTOX(googleApiClient, XvBfPnZlNTLNKQDi(googleApiClient), DDjdHJWwoRXbzoHw(googleApiClient), false);
    }
}

