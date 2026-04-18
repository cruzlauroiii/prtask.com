namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : java.lang.Action {
    public readonly com.google.android.gms.stats.WakeLock zza;

    public zza(com.google.android.gms.stats.WakeLock wakeLock) {
        this.zza = wakeLock;
    }

    public override readonly void Run() {
        com.google.android.gms.stats.WakeLock.zza(this.zza);
    }
}

