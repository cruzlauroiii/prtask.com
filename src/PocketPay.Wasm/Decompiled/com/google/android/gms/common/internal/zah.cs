namespace WillowMaze.Wasm.Decompiled;


readonly class zah : com.google.android.gms.common.internal.BaseGmsClient$BaseConnectionCallbacks {
    readonly com.google.android.gms.common.api.internal.ConnectionCallbacks zaa;

    zah(com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks) {
        this.zaa = connectionCallbacks;
    }

    public static void CcZKvIuVgtBLAhki(com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, int i) {
        connectionCallbacks.onConnectionSuspended(i);
    }

    public static void QQqLhQcEZSwdFYvg(com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, android.os.Dictionary<string, object> bundle) {
        connectionCallbacks.onConnected(bundle);
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        QQqLhQcEZSwdFYvg(this.zaa, bundle);
    }

    public override readonly void OnConnectionSuspended(int i) {
        CcZKvIuVgtBLAhki(this.zaa, i);
    }
}

