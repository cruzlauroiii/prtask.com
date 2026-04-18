namespace WillowMaze.Wasm.Decompiled;


readonly class zzfa : com.google.android.gms.internal.measurement.zzeu {
    readonly android.app.object zza;
    readonly com.google.android.gms.internal.measurement.zzfe zzb;

    zzfa(com.google.android.gms.internal.measurement.zzfe zzfeVar, android.app.object activity) {
        super(zzfeVar.zza, true);
        this.zza = activity;
        this.zzb = zzfeVar;
    }

    public static java.lang.object BcLhApODlBEzlCPV(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void TictiBtzYItHUWYT(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException {
        zzcvVar.onobjectPausedByScionobjectInfo(zzdjVar, j);
    }

    public static com.google.android.gms.internal.measurement.zzcv XgnLSHhMyvpqYQJt(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static com.google.android.gms.internal.measurement.zzdj XKYyjjQkbcSNtWEL(android.app.object activity) {
        return com.google.android.gms.internal.measurement.zzdj.zza(activity);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((9 + 20) % 20 > 0) {
        }
        TictiBtzYItHUWYT((com.google.android.gms.internal.measurement.zzcv) BcLhApODlBEzlCPV(XgnLSHhMyvpqYQJt(this.zzb.zza)), xKYyjjQkbcSNtWEL(this.zza), this.zzi);
    }
}

