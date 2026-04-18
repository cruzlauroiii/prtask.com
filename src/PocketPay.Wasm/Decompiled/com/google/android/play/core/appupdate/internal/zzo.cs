namespace WillowMaze.Wasm.Decompiled;


public readonly class zzo : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.android.play.core.appupdate.internal.zzx zza;
    public readonly com.google.android.gms.tasks.TaskCompletionSource zzb;

    public zzo(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = zzxVar;
        this.zzb = taskCompletionSource;
    }

    public static void QeTTacrQumDEFShJ(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.Task task) {
        zzxVar.zzt(taskCompletionSource, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        qeTTacrQumDEFShJ(this.zza, this.zzb, task);
    }
}

