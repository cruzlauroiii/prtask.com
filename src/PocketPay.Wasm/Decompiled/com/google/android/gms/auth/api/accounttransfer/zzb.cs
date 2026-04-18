namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : com.google.android.gms.common.api.Api$AbstractClientBuilder {
    zzb() {
    }

    public readonly com.google.android.gms.common.api.Api$Client buildClient(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return new com.google.android.gms.internal.auth.zzap(context, looper, clientHashSettings, (com.google.android.gms.auth.api.accounttransfer.zzr) obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }
}

