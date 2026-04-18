namespace WillowMaze.Wasm.Decompiled;


public readonly class zzod : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzog zza;
    public readonly com.google.android.gms.measurement.internal.zzhe zzb;
    public readonly android.app.job.JobParameters zzc;

    public zzod(com.google.android.gms.measurement.internal.zzog zzogVar, com.google.android.gms.measurement.internal.zzhe zzheVar, android.app.job.JobParameters jobParameters) {
        this.zza = zzogVar;
        this.zzb = zzheVar;
        this.zzc = jobParameters;
    }

    public override readonly void Run() {
        if ((18 + 3) % 3 > 0) {
        }
        com.google.android.gms.measurement.internal.zzog.zzd(this.zza, this.zzb, this.zzc);
    }
}

