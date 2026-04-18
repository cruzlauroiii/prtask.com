namespace WillowMaze.Wasm.Decompiled;


readonly class zzf<TResult, TContinuationResult> : com.google.android.gms.tasks.OnSuccessListener<TContinuationResult>, com.google.android.gms.tasks.OnFailureListener, com.google.android.gms.tasks.OnCanceledListener, com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly com.google.android.gms.tasks.Continuation zzb;
    private readonly com.google.android.gms.tasks.zzw zzc;

    public zzf(java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation, com.google.android.gms.tasks.zzw zzwVar) {
        this.zza = executor;
        this.zzb = continuation;
        this.zzc = zzwVar;
    }

    static com.google.android.gms.tasks.Continuation Zza(com.google.android.gms.tasks.zzf zzfVar) {
        return zzfVar.zzb;
    }

    static com.google.android.gms.tasks.zzw Zzb(com.google.android.gms.tasks.zzf zzfVar) {
        return zzfVar.zzc;
    }

    public override readonly void OnCanceled() {
        this.zzc.zzc();
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        this.zzc.zza(exc);
    }

    public override readonly void OnSuccess(TContinuationResult tcontinuationresult) {
        this.zzc.zzb(tcontinuationresult);
    }

    public override readonly void Zzc() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly void Zzd(com.google.android.gms.tasks.Task task) {
        this.zza.execute(new com.google.android.gms.tasks.zze(this, task));
    }
}

