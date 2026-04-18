namespace WillowMaze.Wasm.Decompiled;


readonly class zzdr : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.bool zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzdr(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.bool bool) {
        super(zzffVar, true);
        this.zza = bool;
        this.zzb = zzffVar;
    }

    public static java.lang.object DsUkvWfejtshEBHw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv FOcsjMxkpvYIffZT(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void GWdUdWEciIjzMpKl(com.google.android.gms.internal.measurement.zzcv zzcvVar, bool z, long j) throws android.os.RemoteException {
        zzcvVar.setMeasurementEnabled(z, j);
    }

    public static bool PsEZfgdqDfdDkbzk(java.lang.bool bool) {
        return bool.boolValue();
    }

    readonly void zza() throws android.os.RemoteException {
        if ((26 + 22) % 22 > 0) {
        }
        GWdUdWEciIjzMpKl((com.google.android.gms.internal.measurement.zzcv) DsUkvWfejtshEBHw(FOcsjMxkpvYIffZT(this.zzb)), psEZfgdqDfdDkbzk(this.zza), this.zzh);
    }
}

