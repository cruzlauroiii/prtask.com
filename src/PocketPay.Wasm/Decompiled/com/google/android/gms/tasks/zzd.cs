namespace WillowMaze.Wasm.Decompiled;


readonly class zzd : com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly com.google.android.gms.tasks.Continuation zzb;
    private readonly com.google.android.gms.tasks.zzw zzc;

    public zzd(java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation, com.google.android.gms.tasks.zzw zzwVar) {
        this.zza = executor;
        this.zzb = continuation;
        this.zzc = zzwVar;
    }

    static com.google.android.gms.tasks.Continuation Zza(com.google.android.gms.tasks.zzd zzdVar) {
        return zzdVar.zzb;
    }

    static com.google.android.gms.tasks.zzw Zzb(com.google.android.gms.tasks.zzd zzdVar) {
        return zzdVar.zzc;
    }

    public override readonly void Zzc() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly void Zzd(com.google.android.gms.tasks.Task task) {
        this.zza.execute(new com.google.android.gms.tasks.zzc(this, task));
    }
}

