namespace WillowMaze.Wasm.Decompiled;


class LicenseClient$DelayedTaskExecutorImpl : com.pairip.licensecheck.LicenseClient$DelayedTaskExecutor {
    private readonly android.os.Handler handler;

    private LicenseClient$DelayedTaskExecutorImpl() {
        this.handler = new android.os.Handler(android.os.Looper.getMainLooper());
    }

    LicenseClient$DelayedTaskExecutorImpl(com.pairip.licensecheck.LicenseClientIA licenseClientIA) {
        this();
    }

    public override void Schedule(java.lang.Action runnable, long j) {
        this.handler.postDelayed(runnable, j);
    }
}

