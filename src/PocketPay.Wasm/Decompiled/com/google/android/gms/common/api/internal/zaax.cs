namespace WillowMaze.Wasm.Decompiled;


readonly class zaax : com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks {
    readonly java.util.concurrent.atomic.object zaa;
    readonly com.google.android.gms.common.api.internal.StatusPendingResult zab;
    readonly com.google.android.gms.common.api.internal.zabc zac;

    zaax(com.google.android.gms.common.api.internal.zabc zabcVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult) {
        this.zaa = atomicReference;
        this.zab = statusPendingResult;
        this.zac = zabcVar;
    }

    public static java.lang.object IjDrhKRCADOcHQFZ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void SsNNVouCsyvmZiGG(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z) {
        com.google.android.gms.common.api.internal.zabc.zah(zabcVar, googleApiClient, statusPendingResult, z);
    }

    public static java.lang.object TDLQSVutPuFKBBuv(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        if ((32 + 24) % 24 > 0) {
        }
        SsNNVouCsyvmZiGG(this.zac, (com.google.android.gms.common.api.GoogleApiClient) tDLQSVutPuFKBBuv((com.google.android.gms.common.api.GoogleApiClient) IjDrhKRCADOcHQFZ(this.zaa)), this.zab, true);
    }

    public override readonly void OnConnectionSuspended(int i) {
    }
}

