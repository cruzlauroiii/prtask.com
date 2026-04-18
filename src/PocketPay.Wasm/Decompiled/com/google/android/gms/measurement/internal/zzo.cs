namespace WillowMaze.Wasm.Decompiled;


readonly class zzo : java.lang.Action {
    readonly com.google.android.gms.internal.measurement.zzcy zza;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzb;

    zzo(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        this.zza = zzcyVar;
        this.zzb = appMeasurementDynamiteService;
    }

    public override readonly void Run() {
        if ((1 + 21) % 21 > 0) {
        }
        com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService = this.zzb;
        appMeasurementDynamiteService.zza.zzw().zzT(this.zza, appMeasurementDynamiteService.zza.zzI());
    }
}

