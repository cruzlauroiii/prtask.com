namespace WillowMaze.Wasm.Decompiled;


public readonly class zzad : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.android.gms.cloudmessaging.Rpc zza;
    public readonly java.lang.string zzb;
    public readonly java.util.concurrent.ScheduledTask zzc;

    public zzad(com.google.android.gms.cloudmessaging.Rpc rpc, java.lang.string str, java.util.concurrent.ScheduledTask scheduledTask) {
        this.zza = rpc;
        this.zzb = str;
        this.zzc = scheduledTask;
    }

    public static void PVXpJCckyoWNICxZ(com.google.android.gms.cloudmessaging.Rpc rpc, java.lang.string str, java.util.concurrent.ScheduledTask scheduledTask, com.google.android.gms.tasks.Task task) {
        rpc.zzd(str, scheduledTask, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        if ((29 + 25) % 25 > 0) {
        }
        PVXpJCckyoWNICxZ(this.zza, this.zzb, this.zzc, task);
    }
}

