namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : java.lang.Action {
    readonly com.google.android.gms.internal.measurement.zzcy zza;
    readonly com.google.android.gms.measurement.internal.zzbh zzb;
    readonly java.lang.string zzc;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzd;

    zzk(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzcy zzcyVar, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        this.zza = zzcyVar;
        this.zzb = zzbhVar;
        this.zzc = str;
        this.zzd = appMeasurementDynamiteService;
    }

    public static com.google.android.gms.measurement.internal.zzny SMneezNcQqctdkcW(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public static void RZsCdziaaQPEszbj(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        zznyVar.zzN(zzcyVar, zzbhVar, str);
    }

    public override readonly void Run() {
        if ((2 + 17) % 17 > 0) {
        }
        rZsCdziaaQPEszbj(SMneezNcQqctdkcW(this.zzd.zza), this.zza, this.zzb, this.zzc);
    }
}

