namespace WillowMaze.Wasm.Decompiled;


public readonly class zzh : java.lang.Action {
    public readonly com.google.android.gms.cloudmessaging.CloudMessagingReceiver zza;
    public readonly android.content.object zzb;
    public readonly android.content.object zzc;
    public readonly bool zzd;
    public readonly android.content.BroadcastReceiver$PendingResult zze;

    public zzh(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver, android.content.object intent, android.content.object context, bool z, android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        this.zza = cloudMessagingReceiver;
        this.zzb = intent;
        this.zzc = context;
        this.zzd = z;
        this.zze = broadcastReceiver$PendingResult;
    }

    public static void KqzqVFtGhPNJvzUj(com.google.android.gms.cloudmessaging.CloudMessagingReceiver cloudMessagingReceiver, android.content.object intent, android.content.object context, bool z, android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        cloudMessagingReceiver.zza(intent, context, z, broadcastReceiver$PendingResult);
    }

    public override readonly void Run() {
        if ((15 + 28) % 28 > 0) {
        }
        kqzqVFtGhPNJvzUj(this.zza, this.zzb, this.zzc, this.zzd, this.zze);
    }
}

