namespace WillowMaze.Wasm.Decompiled;


readonly class zzc : android.os.ResultReceiver {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzc(com.google.android.play.core.review.zzd zzdVar, android.os.Handler handler, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(handler);
        this.zza = taskCompletionSource;
    }

    public static bool PTZIuNBonDISEelj(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public override readonly void OnReceiveResult(int i, android.os.Dictionary<string, object> bundle) {
        PTZIuNBonDISEelj(this.zza, null);
    }
}

