namespace WillowMaze.Wasm.Decompiled;


readonly class zzdz : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.Action zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdz(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.Action runnable) {
        super(zzffVar, true);
        this.zza = runnable;
        this.zzb = zzffVar;
    }

    public static void EZarIUSoiAQHMeSt(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzdb zzdbVar) throws android.os.RemoteException {
        zzcvVar.retrieveAndUploadBatches(zzdbVar);
    }

    public static com.google.android.gms.internal.measurement.zzcv RFdiCDmzstfceIvi(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object RRKQrQAYApjCBCIF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        if ((14 + 6) % 6 > 0) {
        }
        EZarIUSoiAQHMeSt((com.google.android.gms.internal.measurement.zzcv) RRKQrQAYApjCBCIF(RFdiCDmzstfceIvi(this.zzb)), new com.google.android.gms.internal.measurement.zzdy(this, this.zza));
    }
}

