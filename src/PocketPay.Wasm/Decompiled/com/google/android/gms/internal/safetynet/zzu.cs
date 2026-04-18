namespace WillowMaze.Wasm.Decompiled;


readonly class zzu : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.internal.safetynet.zzv zza;

    zzu(com.google.android.gms.internal.safetynet.zzv zzvVar) {
        this.zza = zzvVar;
    }

    public static void EzgEwJAjImotUAUC(com.google.android.gms.internal.safetynet.zzv zzvVar, com.google.android.gms.common.api.Result result) {
        zzvVar.setResult(result);
    }

    public override readonly void Zzg(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zzd zzdVar) {
        EzgEwJAjImotUAUC(this.zza, new com.google.android.gms.internal.safetynet.zzaa(status, zzdVar));
    }
}

