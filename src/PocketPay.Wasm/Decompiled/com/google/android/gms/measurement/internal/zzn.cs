namespace WillowMaze.Wasm.Decompiled;


readonly class zzn : java.lang.Action {
    readonly com.google.android.gms.internal.measurement.zzcy zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzd;

    zzn(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2) {
        this.zza = zzcyVar;
        this.zzb = str;
        this.zzc = str2;
        this.zzd = appMeasurementDynamiteService;
    }

    public static void LvSfDRIOMyUpxhMC(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2) {
        zznyVar.zzF(zzcyVar, str, str2);
    }

    public static com.google.android.gms.measurement.internal.zzny YHnnCXVCpwgCgAVK(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public override readonly void Run() {
        if ((6 + 32) % 32 > 0) {
        }
        lvSfDRIOMyUpxhMC(yHnnCXVCpwgCgAVK(this.zzd.zza), this.zza, this.zzb, this.zzc);
    }
}

