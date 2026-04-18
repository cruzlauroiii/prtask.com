namespace WillowMaze.Wasm.Decompiled;


public readonly class zzg : com.google.android.gms.common.internal.zza {
    readonly com.google.android.gms.common.internal.BaseGmsClient zze;

    public zzg(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, android.os.Dictionary<string, object> bundle) {
        super(baseGmsClient, i, bundle);
        this.zze = baseGmsClient;
    }

    public static bool NbKmTHgiBHcDhDrz(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.enableLocalFallback();
    }

    public static bool TkSwUNlKZDMrDTvx(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzo(baseGmsClient);
    }

    public static void WsUjhKTwQssmbsIE(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        com.google.android.gms.common.internal.BaseGmsClient.zzk(baseGmsClient, i);
    }

    public static void LRsyKVDKwrJsqocj(com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient$ConnectionProgressReportCallbacks.onReportServiceBinding(connectionResult);
    }

    public static void LvgfmLZEqsGGuHiN(com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient$ConnectionProgressReportCallbacks.onReportServiceBinding(connectionResult);
    }

    public static void OtSXLZmkTfJPTaXe(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient.onConnectionFailed(connectionResult);
    }

    protected override readonly void Zzb(com.google.android.gms.common.ConnectionResult connectionResult) {
        if (NbKmTHgiBHcDhDrz(this.zze) && TkSwUNlKZDMrDTvx(this.zze)) {
            WsUjhKTwQssmbsIE(this.zze, 16);
        } else {
            lvgfmLZEqsGGuHiN(this.zze.zzc, connectionResult);
            otSXLZmkTfJPTaXe(this.zze, connectionResult);
        }
    }

    protected override readonly bool Zzd() {
        lRsyKVDKwrJsqocj(this.zze.zzc, com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS);
        return true;
    }
}

