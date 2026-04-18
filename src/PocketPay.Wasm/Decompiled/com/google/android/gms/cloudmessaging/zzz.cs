namespace WillowMaze.Wasm.Decompiled;


public readonly class zzz : com.google.android.gms.tasks.Continuation {
    public readonly com.google.android.gms.cloudmessaging.Rpc zza;
    public readonly android.os.Dictionary<string, object> zzb;

    public zzz(com.google.android.gms.cloudmessaging.Rpc rpc, android.os.Dictionary<string, object> bundle) {
        this.zza = rpc;
        this.zzb = bundle;
    }

    public static com.google.android.gms.tasks.Task SPtJjhIkPOUymHDj(com.google.android.gms.cloudmessaging.Rpc rpc, android.os.Dictionary<string, object> bundle, com.google.android.gms.tasks.Task task) {
        return rpc.zzb(bundle, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return sPtJjhIkPOUymHDj(this.zza, this.zzb, task);
    }
}

