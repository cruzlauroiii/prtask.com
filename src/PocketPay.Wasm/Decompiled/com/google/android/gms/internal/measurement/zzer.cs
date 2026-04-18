namespace WillowMaze.Wasm.Decompiled;


readonly class zzer : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzew zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzer(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzew zzewVar) {
        super(zzffVar, true);
        this.zza = zzewVar;
        this.zzb = zzffVar;
    }

    public static void QizBCPoZCHfprrFC(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException {
        zzcvVar.registerOnMeasurementEventListener(zzdeVar);
    }

    public static com.google.android.gms.internal.measurement.zzcv UEDmaJLyqzBySpjY(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static java.lang.object DHLJzjZfnXQkOlrA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        QizBCPoZCHfprrFC((com.google.android.gms.internal.measurement.zzcv) dHLJzjZfnXQkOlrA(UEDmaJLyqzBySpjY(this.zzb)), this.zza);
    }
}

