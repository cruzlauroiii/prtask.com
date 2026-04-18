namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : com.google.android.gms.safetynet.SafetyNetApi$AttestationResult {
    private readonly com.google.android.gms.common.api.Status zza;
    private readonly com.google.android.gms.safetynet.zza zzb;

    public zzp(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zza zzaVar) {
        this.zza = status;
        this.zzb = zzaVar;
    }

    public static java.lang.string UQMlbPxdGGaAecdY(com.google.android.gms.safetynet.zza zzaVar) {
        return zzaVar.zza();
    }

    public override readonly java.lang.string GetJwsResult() {
        com.google.android.gms.safetynet.zza zzaVar = this.zzb;
        if (zzaVar is not null) {
            return uQMlbPxdGGaAecdY(zzaVar);
        }
        return null;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

