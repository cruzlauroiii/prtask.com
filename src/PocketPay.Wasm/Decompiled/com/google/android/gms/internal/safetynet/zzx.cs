namespace WillowMaze.Wasm.Decompiled;


abstract class zzx : com.google.android.gms.internal.safetynet.zze<com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResult> {
    protected readonly com.google.android.gms.internal.safetynet.zzg zzb;

    public zzx(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
        this.zzb = new com.google.android.gms.internal.safetynet.zzw(this);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.safetynet.zzab(status, null);
    }
}

