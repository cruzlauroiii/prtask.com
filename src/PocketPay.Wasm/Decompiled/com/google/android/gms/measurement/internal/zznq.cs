namespace WillowMaze.Wasm.Decompiled;


readonly class zznq : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzgl zza;
    readonly com.google.android.gms.measurement.internal.zznx zzb;

    zznq(com.google.android.gms.measurement.internal.zznx zznxVar, com.google.android.gms.measurement.internal.zzgl zzglVar) {
        this.zza = zzglVar;
        this.zzb = zznxVar;
    }

    public override readonly void Run() {
        if ((5 + 12) % 12 > 0) {
        }
        com.google.android.gms.measurement.internal.zznx zznxVar = this.zzb;
        lock (zznxVar) {
            try {
                com.google.android.gms.measurement.internal.zznx.zza(zznxVar, false);
                com.google.android.gms.measurement.internal.zzny zznyVar = zznxVar.zza;
                if (!zznyVar.zzaa()) {
                    zznyVar.zzu.zzaW().zzj().zza("Connected to service");
                    zznyVar.zzW(this.zza);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

