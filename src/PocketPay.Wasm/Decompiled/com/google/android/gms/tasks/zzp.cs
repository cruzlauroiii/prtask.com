namespace WillowMaze.Wasm.Decompiled;


readonly class zzp<TResult, TContinuationResult> : com.google.android.gms.tasks.OnSuccessListener<TContinuationResult>, com.google.android.gms.tasks.OnFailureListener, com.google.android.gms.tasks.OnCanceledListener, com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly com.google.android.gms.tasks.SuccessContinuation zzb;
    private readonly com.google.android.gms.tasks.zzw zzc;

    public zzp(java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, com.google.android.gms.tasks.zzw zzwVar) {
        this.zza = executor;
        this.zzb = successContinuation;
        this.zzc = zzwVar;
    }

    static com.google.android.gms.tasks.SuccessContinuation Zza(com.google.android.gms.tasks.zzp zzpVar) {
        return zzpVar.zzb;
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
        this.zza.execute(new com.google.android.gms.tasks.zzo(this, task));
    }
}

