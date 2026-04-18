namespace WillowMaze.Wasm.Decompiled;


readonly class zzab : com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResult {
    private readonly com.google.android.gms.common.api.Status zza;
    private readonly com.google.android.gms.safetynet.zzf zzb;

    public zzab(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zzf zzfVar) {
        this.zza = status;
        this.zzb = zzfVar;
    }

    public static java.lang.string BmvbokmSRLTCUmuU(com.google.android.gms.safetynet.zzf zzfVar) {
        return zzfVar.zza();
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }

    public override readonly java.lang.string GetTokenResult() {
        com.google.android.gms.safetynet.zzf zzfVar = this.zzb;
        if (zzfVar is not null) {
            return bmvbokmSRLTCUmuU(zzfVar);
        }
        return null;
    }
}

