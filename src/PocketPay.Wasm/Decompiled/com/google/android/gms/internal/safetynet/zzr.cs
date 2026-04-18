namespace WillowMaze.Wasm.Decompiled;


abstract class zzr : com.google.android.gms.internal.safetynet.zze<com.google.android.gms.safetynet.SafetyNetApi$AttestationResult> {
    protected readonly com.google.android.gms.internal.safetynet.zzg zzc;

    public zzr(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
        this.zzc = new com.google.android.gms.internal.safetynet.zzq(this);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.safetynet.zzp(status, null);
    }
}

