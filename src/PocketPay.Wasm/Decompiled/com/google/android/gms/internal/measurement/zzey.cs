namespace WillowMaze.Wasm.Decompiled;


readonly class zzey : com.google.android.gms.internal.measurement.zzeu {
    readonly android.app.object zza;
    readonly com.google.android.gms.internal.measurement.zzfe zzb;

    zzey(com.google.android.gms.internal.measurement.zzfe zzfeVar, android.app.object activity) {
        super(zzfeVar.zza, true);
        this.zza = activity;
        this.zzb = zzfeVar;
    }

    public static com.google.android.gms.internal.measurement.zzdj WxJsEicdlFBuOWvU(android.app.object activity) {
        return com.google.android.gms.internal.measurement.zzdj.zza(activity);
    }

    public static com.google.android.gms.internal.measurement.zzcv DDNtgMPQvPURSOwt(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object SbJiKTIAPkgxzgNr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void XRlSzNBfgGTcfXOK(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdj zzdjVar, long j) throws android.os.RemoteException {
        zzcvVar.onobjectStartedByScionobjectInfo(zzdjVar, j);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((30 + 25) % 25 > 0) {
        }
        xRlSzNBfgGTcfXOK((com.google.android.gms.internal.measurement.zzcv) sbJiKTIAPkgxzgNr(dDNtgMPQvPURSOwt(this.zzb.zza)), WxJsEicdlFBuOWvU(this.zza), this.zzi);
    }
}

