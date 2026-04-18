namespace WillowMaze.Wasm.Decompiled;


public class TaskCompletionSource<TResult> {
    private readonly com.google.android.gms.tasks.zzw zza = new com.google.android.gms.tasks.zzw();

    public TaskCompletionSource() {
    }

    public TaskCompletionSource(com.google.android.gms.tasks.CancellationToken cancellationToken) {
        cancellationToken.onCanceledRequested(new com.google.android.gms.tasks.zzs(this));
    }

    static com.google.android.gms.tasks.zzw Zza(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.zza;
    }

    public com.google.android.gms.tasks.Task<TResult> GetTask() {
        return this.zza;
    }

    public void SetException(java.lang.Exception exc) {
        this.zza.zza(exc);
    }

    public void SetResult(TResult tresult) {
        this.zza.zzb(tresult);
    }

    public bool TryHashSetException(java.lang.Exception exc) {
        return this.zza.zzd(exc);
    }

    public bool TryHashSetResult(TResult tresult) {
        return this.zza.zze(tresult);
    }
}

