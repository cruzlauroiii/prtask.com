namespace WillowMaze.Wasm.Decompiled;


public readonly class LicenseClient$$ExternalSyntheticLambda3 : com.pairip.licensecheck.LicenseClient$ImmediateTaskExecutor {
    public readonly android.os.Handler f$0;

    public LicenseClient$$ExternalSyntheticLambda3(android.os.Handler handler) {
        this.f$0 = handler;
    }

    public override readonly void Run(java.lang.Action runnable) {
        this.f$0.post(runnable);
    }
}

