namespace WillowMaze.Wasm.Decompiled;


readonly class zbb : com.google.android.gms.common.api.Api$AbstractClientBuilder {
    zbb() {
    }

    public static java.util.List LusldcFMcmygKVUZ(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static java.util.List HKjvFEjuLAUKBZny() {
        return java.util.ICollections.emptyList();
    }

    public readonly com.google.android.gms.common.api.Api$Client buildClient(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return new com.google.android.gms.auth.api.signin.internal.zbe(context, looper, clientHashSettings, (com.google.android.gms.auth.api.signin.GoogleSignInOptions) obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }

    public override readonly java.util.List GetImpliedScopes(java.lang.object obj) {
        com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) obj;
        return googleSignInOptions is not null ? LusldcFMcmygKVUZ(googleSignInOptions) : hKjvFEjuLAUKBZny();
    }
}

