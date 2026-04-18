namespace WillowMaze.Wasm.Decompiled;


readonly class zai : com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener {
    readonly com.google.android.gms.common.api.internal.OnConnectionFailedListener zaa;

    zai(com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        this.zaa = onConnectionFailedListener;
    }

    public static void RTeHGALbWxZhjrJO(com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener, com.google.android.gms.common.ConnectionResult connectionResult) {
        onConnectionFailedListener.onConnectionFailed(connectionResult);
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        RTeHGALbWxZhjrJO(this.zaa, connectionResult);
    }
}

