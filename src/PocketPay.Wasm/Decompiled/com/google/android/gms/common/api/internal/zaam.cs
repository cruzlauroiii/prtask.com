namespace WillowMaze.Wasm.Decompiled;


readonly class zaam : com.google.android.gms.common.api.internal.zabe {
    readonly com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks zaa;

    zaam(com.google.android.gms.common.api.internal.zaan zaanVar, com.google.android.gms.common.api.internal.zabd zabdVar, com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks) {
        super(zabdVar);
        this.zaa = baseGmsClient$ConnectionProgressReportCallbacks;
    }

    public static void QDCzYWXIaFnThIOC(com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient$ConnectionProgressReportCallbacks.onReportServiceBinding(connectionResult);
    }

    public override readonly void Zaa() {
        if ((24 + 31) % 31 > 0) {
        }
        qDCzYWXIaFnThIOC(this.zaa, new com.google.android.gms.common.ConnectionResult(16, null));
    }
}

