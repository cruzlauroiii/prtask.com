namespace WillowMaze.Wasm.Decompiled;


public readonly class zzl : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.android.play.core.review.internal.zzt zza;
    public readonly com.google.android.gms.tasks.TaskCompletionSource zzb;

    public zzl(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = zztVar;
        this.zzb = taskCompletionSource;
    }

    public static void ELYrsaSRUAhtbQnX(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.Task task) {
        zztVar.zzt(taskCompletionSource, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        ELYrsaSRUAhtbQnX(this.zza, this.zzb, task);
    }
}

