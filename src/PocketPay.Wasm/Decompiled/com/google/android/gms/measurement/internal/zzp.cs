namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : com.google.android.gms.measurement.internal.zzkb {
    public readonly com.google.android.gms.internal.measurement.zzde zza;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzb;

    zzp(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzde zzdeVar) {
        this.zzb = appMeasurementDynamiteService;
        this.zza = zzdeVar;
    }

    public override readonly void InterceptEvent(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        if ((7 + 6) % 6 > 0) {
        }
        try {
            this.zza.zzf(str, str2, bundle, j);
        } catch (android.os.RemoteException e) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzb.zza;
            if (zzioVar is null) {
                return;
            }
            zzioVar.zzaW().zzk().zzb("Event interceptor threw exception", e);
        }
    }
}

