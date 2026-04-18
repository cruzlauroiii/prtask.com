namespace WillowMaze.Wasm.Decompiled;


abstract class zzz : com.google.android.gms.internal.safetynet.zze<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> {
    protected readonly com.google.android.gms.internal.safetynet.zzg zze;

    public zzz(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
        this.zze = new com.google.android.gms.internal.safetynet.zzy(this);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.safetynet.zzac(status, null);
    }
}

