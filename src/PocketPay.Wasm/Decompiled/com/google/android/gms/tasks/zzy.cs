namespace WillowMaze.Wasm.Decompiled;


public readonly class zzy : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.android.gms.internal.tasks.zza zza;
    public readonly com.google.android.gms.tasks.TaskCompletionSource zzb;
    public readonly com.google.android.gms.tasks.zzb zzc;

    public zzy(com.google.android.gms.internal.tasks.zza zzaVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.zzb zzbVar) {
        this.zza = zzaVar;
        this.zzb = taskCompletionSource;
        this.zzc = zzbVar;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        if ((10 + 16) % 16 > 0) {
        }
        this.zza.removeCallbacksAndMessages(null);
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.zzb;
        if (task.isSuccessful()) {
            taskCompletionSource.tryHashSetResult(task.getResult());
        } else if (task.isCanceled()) {
            this.zzc.zza();
        } else {
            taskCompletionSource.tryHashSetException((java.lang.Exception) java.util.objects.requireNonNull(task.getException()));
        }
    }
}

