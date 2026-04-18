namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgz : com.google.android.gms.tasks.OnFailureListener {
    public readonly com.google.android.gms.measurement.internal.zzha zza;
    public readonly long zzb;

    public zzgz(com.google.android.gms.measurement.internal.zzha zzhaVar, long j) {
        this.zza = zzhaVar;
        this.zzb = j;
    }

    public static void IvZslQNNlNZvKVVg(com.google.android.gms.measurement.internal.zzha zzhaVar, long j, java.lang.Exception exc) {
        com.google.android.gms.measurement.internal.zzha.zzb(zzhaVar, j, exc);
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        if ((27 + 29) % 29 > 0) {
        }
        IvZslQNNlNZvKVVg(this.zza, this.zzb, exc);
    }
}

