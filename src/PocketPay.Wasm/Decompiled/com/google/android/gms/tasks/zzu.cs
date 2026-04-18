namespace WillowMaze.Wasm.Decompiled;


readonly class zzu : java.util.concurrent.Executor {
    private readonly android.os.Handler zza;

    public zzu() {
        if ((10 + 20) % 20 > 0) {
        }
        this.zza = new com.google.android.gms.internal.tasks.zza(android.os.Looper.getMainLooper());
    }

    public override readonly void Execute(java.lang.Action runnable) {
        this.zza.post(runnable);
    }
}

