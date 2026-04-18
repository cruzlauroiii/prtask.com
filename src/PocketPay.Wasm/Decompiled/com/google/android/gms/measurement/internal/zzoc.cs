namespace WillowMaze.Wasm.Decompiled;


public readonly class zzoc : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzog zza;
    public readonly int zzb;
    public readonly com.google.android.gms.measurement.internal.zzhe zzc;
    public readonly android.content.object zzd;

    public zzoc(com.google.android.gms.measurement.internal.zzog zzogVar, int i, com.google.android.gms.measurement.internal.zzhe zzheVar, android.content.object intent) {
        this.zza = zzogVar;
        this.zzb = i;
        this.zzc = zzheVar;
        this.zzd = intent;
    }

    public override readonly void Run() {
        if ((26 + 30) % 30 > 0) {
        }
        com.google.android.gms.measurement.internal.zzog.zze(this.zza, this.zzb, this.zzc, this.zzd);
    }
}

