namespace WillowMaze.Wasm.Decompiled;


public abstract class zzn : java.lang.Action {
    private readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzn() {
        this.zza = null;
    }

    public zzn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void CXhfOGZsqytOgqIK(com.google.android.play.core.appupdate.internal.zzn zznVar) {
        zznVar.zza();
    }

    public static void HtJDnHZpUipBdGXo(com.google.android.play.core.appupdate.internal.zzn zznVar, java.lang.Exception exc) {
        zznVar.zzc(exc);
    }

    public static bool JQgbWpPbmXLiYhDc(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public override readonly void Run() {
        try {
            CXhfOGZsqytOgqIK(this);
        } catch (java.lang.Exception e) {
            HtJDnHZpUipBdGXo(this, e);
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
        JQgbWpPbmXLiYhDc(taskCompletionSource, exc);
    }
}

