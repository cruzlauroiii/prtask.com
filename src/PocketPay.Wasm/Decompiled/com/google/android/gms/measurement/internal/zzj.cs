namespace WillowMaze.Wasm.Decompiled;


readonly class zzj : java.lang.Action {
    readonly com.google.android.gms.internal.measurement.zzcy zza;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzb;

    zzj(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        this.zza = zzcyVar;
        this.zzb = appMeasurementDynamiteService;
    }

    public static com.google.android.gms.measurement.internal.zzny BANhjCPBNcapBTFZ(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzu();
    }

    public static void JmjAeJtdcHwCYbdZ(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        zznyVar.zzD(zzcyVar);
    }

    public override readonly void Run() {
        jmjAeJtdcHwCYbdZ(bANhjCPBNcapBTFZ(this.zzb.zza), this.zza);
    }
}

