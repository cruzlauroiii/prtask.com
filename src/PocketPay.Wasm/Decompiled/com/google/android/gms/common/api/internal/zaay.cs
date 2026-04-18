namespace WillowMaze.Wasm.Decompiled;


readonly class zaay : com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener {
    readonly com.google.android.gms.common.api.internal.StatusPendingResult zaa;

    zaay(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult) {
        this.zaa = statusPendingResult;
    }

    public static void EgayAmSaEqBuJJPl(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        egayAmSaEqBuJJPl(this.zaa, new com.google.android.gms.common.api.Status(8));
    }
}

