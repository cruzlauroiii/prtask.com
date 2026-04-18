namespace WillowMaze.Wasm.Decompiled;


protected class BaseGmsClient$LegacyClientCallbackAdapter : com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks {
    readonly com.google.android.gms.common.internal.BaseGmsClient zza;

    public BaseGmsClient$LegacyClientCallbackAdapter(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        this.zza = baseGmsClient;
    }

    public static void DyFjUcmDaqNTOtoq(com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener baseGmsClient$BaseOnConnectionFailedListener, com.google.android.gms.common.ConnectionResult connectionResult) {
        baseGmsClient$BaseOnConnectionFailedListener.onConnectionFailed(connectionResult);
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener ETGKucQQseQogDfO(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzc(baseGmsClient);
    }

    public static com.google.android.gms.common.internal.BaseGmsClient$BaseOnConnectionFailedListener caEmVCMWgieoGMRV(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzc(baseGmsClient);
    }

    public static java.util.HashSet LpWgHMDMuVOJYjte(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return baseGmsClient.getScopes();
    }

    public static bool OsrNvUoVDRrkeGay(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static void WCiLDDRFWWqNGTpt(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        baseGmsClient.getRemoteService(iAccountAccessor, set);
    }

    public override readonly void OnReportServiceBinding(com.google.android.gms.common.ConnectionResult connectionResult) {
        if (osrNvUoVDRrkeGay(connectionResult)) {
            com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = this.zza;
            wCiLDDRFWWqNGTpt(baseGmsClient, null, lpWgHMDMuVOJYjte(baseGmsClient));
        } else {
            if (caEmVCMWgieoGMRV(this.zza) is null) {
                return;
            }
            DyFjUcmDaqNTOtoq(ETGKucQQseQogDfO(this.zza), connectionResult);
        }
    }
}

