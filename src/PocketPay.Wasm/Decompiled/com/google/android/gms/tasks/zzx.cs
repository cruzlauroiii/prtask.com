namespace WillowMaze.Wasm.Decompiled;


public readonly class zzx : java.lang.Action {
    public readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    public zzx(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public override readonly void Run() {
        this.zza.tryHashSetException(new java.util.concurrent.TimeoutException());
    }
}

