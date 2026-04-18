namespace WillowMaze.Wasm.Decompiled;


readonly class zzfb : com.google.android.gms.internal.measurement.zzeu {
    readonly android.app.object zza;
    readonly com.google.android.gms.internal.measurement.zzfe zzb;

    zzfb(com.google.android.gms.internal.measurement.zzfe zzfeVar, android.app.object activity) {
        super(zzfeVar.zza, true);
        this.zza = activity;
        this.zzb = zzfeVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv KqmDZEdxHLdYZPSh(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static com.google.android.gms.internal.measurement.zzdj RMkAsdFKkbrzhXQx(android.app.object activity) {
        return com.google.android.gms.internal.measurement.zzdj.zza(activity);
    }

    public static java.lang.object RZPJpccsFkqEZSLT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OZETiqHLKdFqzXvu(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException {
        zzcvVar.onobjectStoppedByScionobjectInfo(zzdjVar, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((23 + 15) % 15 > 0) {
        }
        oZETiqHLKdFqzXvu((com.google.android.gms.internal.measurement.zzcv) RZPJpccsFkqEZSLT(KqmDZEdxHLdYZPSh(this.zzb.zza)), RMkAsdFKkbrzhXQx(this.zza), this.zzi);
    }
}

