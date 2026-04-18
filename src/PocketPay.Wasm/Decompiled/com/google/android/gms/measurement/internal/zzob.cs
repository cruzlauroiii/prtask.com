namespace WillowMaze.Wasm.Decompiled;


public readonly class zzob : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzog zza;
    public readonly android.app.job.JobParameters zzb;

    public zzob(com.google.android.gms.measurement.internal.zzog zzogVar, android.app.job.JobParameters jobParameters) {
        this.zza = zzogVar;
        this.zzb = jobParameters;
    }

    public override readonly void Run() {
        com.google.android.gms.measurement.internal.zzog.zzc(this.zza, this.zzb);
    }
}

