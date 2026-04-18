namespace WillowMaze.Wasm.Decompiled;


abstract class zzv : com.google.android.gms.internal.safetynet.zze<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResult> {
    protected readonly com.google.android.gms.internal.safetynet.zzg zza;

    public zzv(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
        this.zza = new com.google.android.gms.internal.safetynet.zzu(this);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.safetynet.zzaa(status, null);
    }
}

