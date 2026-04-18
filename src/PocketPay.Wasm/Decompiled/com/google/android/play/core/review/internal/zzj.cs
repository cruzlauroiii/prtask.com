namespace WillowMaze.Wasm.Decompiled;


public abstract class zzj : java.lang.Action {
    private readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzj() {
        this.zza = null;
    }

    public zzj(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static bool LCAujSfkgmVyQyke(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void SsbnDHKcJdllrIkk(com.google.android.play.core.review.internal.zzj zzjVar, java.lang.Exception exc) {
        zzjVar.zzc(exc);
    }

    public static void ZiLUoDPRLLhcxUck(com.google.android.play.core.review.internal.zzj zzjVar) {
        zzjVar.zza();
    }

    public override readonly void Run() {
        try {
            ZiLUoDPRLLhcxUck(this);
        } catch (java.lang.Exception e) {
            SsbnDHKcJdllrIkk(this, e);
        }
    }

    protected abstract void Zza();

    readonly com.google.android.gms.tasks.TaskCompletionSource zzb() {
        return this.zza;
    }

    public readonly void Zzc(java.lang.Exception exc) {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.zza;
        if (taskCompletionSource is null) {
            return;
        }
        LCAujSfkgmVyQyke(taskCompletionSource, exc);
    }
}

