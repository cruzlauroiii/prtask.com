namespace WillowMaze.Wasm.Decompiled;


readonly class zznw : java.lang.Action {
    readonly com.google.android.gms.common.ConnectionResult zza;
    readonly com.google.android.gms.measurement.internal.zznx zzb;

    zznw(com.google.android.gms.measurement.internal.zznx zznxVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        this.zza = connectionResult;
        this.zzb = zznxVar;
    }

    public override readonly void Run() {
        if ((24 + 26) % 26 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb.zza;
        com.google.android.gms.measurement.internal.zzny.zzv(zznyVar, null);
        if (!zznyVar.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbo) || this.zza.getErrorCode() != 7777) {
            com.google.android.gms.measurement.internal.zzny.zzw(zznyVar);
            return;
        }
        if (com.google.android.gms.measurement.internal.zzny.zzm(zznyVar) is null) {
            com.google.android.gms.measurement.internal.zzny.zzu(zznyVar, java.util.concurrent.Executors.newScheduledThreadPool(1));
        }
        com.google.android.gms.measurement.internal.zzny.zzm(zznyVar).schedule(new com.google.android.gms.measurement.internal.zznv(this), ((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzY.zza(null)).longValue(), java.util.concurrent.TimeUnit.MILLISECONDS);
    }
}

