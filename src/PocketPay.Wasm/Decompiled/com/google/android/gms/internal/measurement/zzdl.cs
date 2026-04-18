namespace WillowMaze.Wasm.Decompiled;


readonly class zzdl : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly java.lang.object zzc;
    readonly bool zzd;
    readonly com.google.android.gms.internal.measurement.zzff zze;

    zzdl(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.string str, java.lang.string str2, java.lang.object obj, bool z) {
        super(zzffVar, true);
        this.zza = str;
        this.zzb = str2;
        this.zzc = obj;
        this.zzd = z;
        this.zze = zzffVar;
    }

    public static void QGGcZXchIthsyWlS(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, java.lang.string str2, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, bool z, long j) throws android.os.RemoteException {
        zzcvVar.setUserProperty(str, str2, iobjectWrapper, z, j);
    }

    public static java.lang.object BrXuEIHPVNcidTtQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv KqkdoDFuVhpmPtRk(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper PehQJzANwaLeeamO(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((21 + 13) % 13 > 0) {
        }
        QGGcZXchIthsyWlS((com.google.android.gms.internal.measurement.zzcv) brXuEIHPVNcidTtQ(kqkdoDFuVhpmPtRk(this.zze)), this.zza, this.zzb, pehQJzANwaLeeamO(this.zzc), this.zzd, this.zzh);
    }
}

