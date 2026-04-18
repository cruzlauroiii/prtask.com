namespace WillowMaze.Wasm.Decompiled;


readonly class zzdv : com.google.android.gms.internal.measurement.zzeu {
    readonly long zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdv(com.google.android.gms.internal.measurement.zzff zzffVar, long j) {
        super(zzffVar, true);
        this.zza = j;
        this.zzb = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv CmuHBgfVdRPlDBLs(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void NFyPgjocVJivQUuM(com.google.android.gms.internal.measurement.zzcv zzcvVar, long j) throws android.os.RemoteException {
        zzcvVar.setSessionTimeoutDuration(j);
    }

    public static java.lang.object VXiCFPsTIFFlMyEf(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((16 + 31) % 31 > 0) {
        }
        NFyPgjocVJivQUuM((com.google.android.gms.internal.measurement.zzcv) VXiCFPsTIFFlMyEf(CmuHBgfVdRPlDBLs(this.zzb)), this.zza);
    }
}

