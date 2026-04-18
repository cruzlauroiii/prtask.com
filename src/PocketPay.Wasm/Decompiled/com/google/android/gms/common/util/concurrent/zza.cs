namespace WillowMaze.Wasm.Decompiled;


readonly class zza : java.lang.Action {
    private readonly java.lang.Action zza;

    public zza(java.lang.Action runnable, int i) {
        this.zza = runnable;
    }

    public static void WMdFyWWavQmwiVcS(int i) {
        android.os.Process.setThreadPriority(i);
    }

    public static void OnSuEtlFovVVgUtB(java.lang.Action runnable) {
        runnable.run();
    }

    public override readonly void Run() {
        WMdFyWWavQmwiVcS(0);
        onSuEtlFovVVgUtB(this.zza);
    }
}

