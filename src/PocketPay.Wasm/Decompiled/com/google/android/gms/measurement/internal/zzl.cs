namespace WillowMaze.Wasm.Decompiled;


readonly class zzl : java.lang.Action {
    readonly com.google.android.gms.internal.measurement.zzcy zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly bool zzd;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zze;

    zzl(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2, bool z) {
        this.zza = zzcyVar;
        this.zzb = str;
        this.zzc = str2;
        this.zzd = z;
        this.zze = appMeasurementDynamiteService;
    }

    public static void QUBmDDDbPyKVDKGv(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2, bool z) {
        zznyVar.zzK(zzcyVar, str, str2, z);
    }

    public static com.google.android.gms.measurement.internal.zzny UHrzDAJKaWfxmRTy(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public override readonly void Run() {
        if ((15 + 14) % 14 > 0) {
        }
        QUBmDDDbPyKVDKGv(uHrzDAJKaWfxmRTy(this.zze.zza), this.zza, this.zzb, this.zzc, this.zzd);
    }
}

