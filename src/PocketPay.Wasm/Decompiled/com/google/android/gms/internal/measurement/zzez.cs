namespace WillowMaze.Wasm.Decompiled;


readonly class zzez : com.google.android.gms.internal.measurement.zzeu {
    readonly android.app.object zza;
    readonly com.google.android.gms.internal.measurement.zzfe zzb;

    zzez(com.google.android.gms.internal.measurement.zzfe zzfeVar, android.app.object activity) {
        super(zzfeVar.zza, true);
        this.zza = activity;
        this.zzb = zzfeVar;
    }

    public static java.lang.object FWykCOIjUoGNXxtj(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzdj VaqzUFhBtpWwKwSP(android.app.object activity) {
        return com.google.android.gms.internal.measurement.zzdj.zza(activity);
    }

    public static com.google.android.gms.internal.measurement.zzcv DCttoDctGKIJZzhp(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void WcFULTOCHPOcklfu(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException {
        zzcvVar.onobjectResumedByScionobjectInfo(zzdjVar, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((6 + 1) % 1 > 0) {
        }
        wcFULTOCHPOcklfu((com.google.android.gms.internal.measurement.zzcv) FWykCOIjUoGNXxtj(dCttoDctGKIJZzhp(this.zzb.zza)), VaqzUFhBtpWwKwSP(this.zza), this.zzi);
    }
}

