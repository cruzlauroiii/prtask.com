namespace WillowMaze.Wasm.Decompiled;


readonly class zzw : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.internal.safetynet.zzx zza;

    zzw(com.google.android.gms.internal.safetynet.zzx zzxVar) {
        this.zza = zzxVar;
    }

    public static void FytNKehkYcNMXuLw(com.google.android.gms.internal.safetynet.zzx zzxVar, com.google.android.gms.common.api.Result result) {
        zzxVar.setResult(result);
    }

    public override readonly void Zzh(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zzf zzfVar) {
        fytNKehkYcNMXuLw(this.zza, new com.google.android.gms.internal.safetynet.zzab(status, zzfVar));
    }
}

