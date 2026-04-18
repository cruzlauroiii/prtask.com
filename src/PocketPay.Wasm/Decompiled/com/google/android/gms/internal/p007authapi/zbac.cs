namespace WillowMaze.Wasm.Decompiled;


readonly class zbac : com.google.android.gms.common.api.Api$AbstractClientBuilder {
    zbac() {
    }

    public readonly com.google.android.gms.common.api.Api$Client buildClient(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        return new com.google.android.gms.internal.p007authapi.zbg(context, looper, (com.google.android.gms.auth.api.identity.zbf) obj, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
    }
}

