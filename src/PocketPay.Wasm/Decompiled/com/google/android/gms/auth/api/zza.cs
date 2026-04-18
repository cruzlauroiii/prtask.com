namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.gms.common.api.Api$AbstractClientBuilder {
    zza() {
    }

    public readonly com.google.android.gms.common.api.Api$Client buildClient(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        return new com.google.android.gms.internal.auth.zzbe(context, looper, clientHashSettings, (com.google.android.gms.auth.api.AuthProxyOptions) obj, connectionCallbacks, onConnectionFailedListener);
    }
}

