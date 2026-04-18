namespace WillowMaze.Wasm.Decompiled;


readonly class zzq : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.internal.safetynet.zzr zza;

    zzq(com.google.android.gms.internal.safetynet.zzr zzrVar) {
        this.zza = zzrVar;
    }

    public static void IDvKmLPRytYyvjpV(com.google.android.gms.internal.safetynet.zzr zzrVar, com.google.android.gms.common.api.Result result) {
        zzrVar.setResult(result);
    }

    public override readonly void Zzd(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zza zzaVar) {
        IDvKmLPRytYyvjpV(this.zza, new com.google.android.gms.internal.safetynet.zzp(status, zzaVar));
    }
}

