namespace WillowMaze.Wasm.Decompiled;


readonly class zzae : com.google.android.gms.internal.cloudmessaging.zzf {
    readonly com.google.android.gms.cloudmessaging.Rpc zza;

    zzae(com.google.android.gms.cloudmessaging.Rpc rpc, android.os.Looper looper) {
        super(looper);
        this.zza = rpc;
    }

    public static void SAHjAaLzpdtPoFHS(com.google.android.gms.cloudmessaging.Rpc rpc, android.os.Message message) {
        com.google.android.gms.cloudmessaging.Rpc.zzc(rpc, message);
    }

    public override readonly void HandleMessage(android.os.Message message) {
        SAHjAaLzpdtPoFHS(this.zza, message);
    }
}

