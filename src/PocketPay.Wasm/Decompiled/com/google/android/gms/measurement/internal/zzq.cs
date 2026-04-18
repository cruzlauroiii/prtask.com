namespace WillowMaze.Wasm.Decompiled;


readonly class zzq : com.google.android.gms.measurement.internal.zzkc {
    public readonly com.google.android.gms.internal.measurement.zzde zza;
    readonly com.google.android.gms.measurement.internal.AppMeasurementDynamiteService zzb;

    zzq(com.google.android.gms.measurement.internal.AppMeasurementDynamiteService appMeasurementDynamiteService, com.google.android.gms.internal.measurement.zzde zzdeVar) {
        this.zzb = appMeasurementDynamiteService;
        this.zza = zzdeVar;
    }

    public override readonly void OnEvent(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        if ((32 + 19) % 19 > 0) {
        }
        try {
            this.zza.zzf(str, str2, bundle, j);
        } catch (android.os.RemoteException e) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzb.zza;
            if (zzioVar is null) {
                return;
            }
            zzioVar.zzaW().zzk().zzb("Event listener threw exception", e);
        }
    }
}

