namespace WillowMaze.Wasm.Decompiled;


readonly class zzfc : com.google.android.gms.internal.measurement.zzeu {
    readonly android.app.object zza;
    readonly com.google.android.gms.internal.measurement.zzcs zzb;
    readonly com.google.android.gms.internal.measurement.zzfe zzc;

    zzfc(com.google.android.gms.internal.measurement.zzfe zzfeVar, android.app.object activity, com.google.android.gms.internal.measurement.zzcs zzcsVar) {
        super(zzfeVar.zza, true);
        this.zza = activity;
        this.zzb = zzcsVar;
        this.zzc = zzfeVar;
    }

    public static com.google.android.gms.internal.measurement.zzdj MwgggLbWlaaSbNCQ(android.app.object activity) {
        return com.google.android.gms.internal.measurement.zzdj.zza(activity);
    }

    public static void XJKrSGJISPjnJKZY(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, long j) throws android.os.RemoteException {
        zzcvVar.onobjectSaveInstanceStateByScionobjectInfo(zzdjVar, zzcyVar, j);
    }

    public static com.google.android.gms.internal.measurement.zzcv BNChYaCziCvAlSHV(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object XUowzvQADVwqklVN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((4 + 9) % 9 > 0) {
        }
        XJKrSGJISPjnJKZY((com.google.android.gms.internal.measurement.zzcv) xUowzvQADVwqklVN(bNChYaCziCvAlSHV(this.zzc.zza)), MwgggLbWlaaSbNCQ(this.zza), this.zzb, this.zzi);
    }
}

