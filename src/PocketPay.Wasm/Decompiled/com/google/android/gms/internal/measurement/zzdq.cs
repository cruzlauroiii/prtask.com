namespace WillowMaze.Wasm.Decompiled;


readonly class zzdq : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzdj zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly com.google.android.gms.internal.measurement.zzff zzd;

    zzdq(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, java.lang.string str, java.lang.string str2) {
        super(zzffVar, true);
        this.zza = zzdjVar;
        this.zzb = str;
        this.zzc = str2;
        this.zzd = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv KIiOqUnbuMdpWxPh(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object ZLGQCPtapPpWTmva(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void ARwvyVjyvzoYXVHS(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, java.lang.string str, java.lang.string str2, long j) throws android.os.RemoteException {
        zzcvVar.setCurrentScreenByScionobjectInfo(zzdjVar, str, str2, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((26 + 30) % 30 > 0) {
        }
        aRwvyVjyvzoYXVHS((com.google.android.gms.internal.measurement.zzcv) ZLGQCPtapPpWTmva(KIiOqUnbuMdpWxPh(this.zzd)), this.zza, this.zzb, this.zzc, this.zzh);
    }
}

