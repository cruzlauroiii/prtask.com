namespace WillowMaze.Wasm.Decompiled;


abstract class zzt : com.google.android.gms.internal.safetynet.zze<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> {
    protected readonly com.google.android.gms.internal.safetynet.zzg zza;

    public zzt(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
        this.zza = new com.google.android.gms.internal.safetynet.zzs(this);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.safetynet.zzad(status, false);
    }
}

