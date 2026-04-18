namespace WillowMaze.Wasm.Decompiled;


readonly class zzes : com.google.android.gms.internal.measurement.zzeu {
    readonly com.google.android.gms.internal.measurement.zzew zza;
    readonly com.google.android.gms.internal.measurement.zzff zzb;

    zzes(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzew zzewVar) {
        super(zzffVar, true);
        this.zza = zzewVar;
        this.zzb = zzffVar;
    }

    public static com.google.android.gms.internal.measurement.zzcv CfSAYanUItmuWuMT(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void FgJpbzKwuaRzDMZn(com.google.android.gms.internal.measurement.zzcv zzcvVar, com.google.android.gms.internal.measurement.zzde zzdeVar) throws android.os.RemoteException {
        zzcvVar.unregisterOnMeasurementEventListener(zzdeVar);
    }

    public static java.lang.object PCbAjUFNKgtTXiIo(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly void zza() throws android.os.RemoteException {
        FgJpbzKwuaRzDMZn((com.google.android.gms.internal.measurement.zzcv) PCbAjUFNKgtTXiIo(CfSAYanUItmuWuMT(this.zzb)), this.zza);
    }
}

