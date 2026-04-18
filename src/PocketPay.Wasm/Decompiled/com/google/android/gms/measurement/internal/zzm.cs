namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzp zza;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzb;

    zzm(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.measurement.internal.zzp zzpVar) {
        this.zza = zzpVar;
        this.zzb = appMeasurementDynamiteService;
    }

    public static com.google.android.gms.measurement.internal.zzlw QZXKirSZugAeKBsq(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzq();
    }

    public static void XyMaNpVoKGyybjmj(com.google.android.gms.measurement.internal.zzlw zzlwVar, com.google.android.gms.measurement.internal.zzkb zzkbVar) {
        zzlwVar.zzah(zzkbVar);
    }

    public override readonly void Run() {
        XyMaNpVoKGyybjmj(QZXKirSZugAeKBsq(this.zzb.zza), this.zza);
    }
}

