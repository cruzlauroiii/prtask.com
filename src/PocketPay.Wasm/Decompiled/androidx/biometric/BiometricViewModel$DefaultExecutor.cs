namespace WillowMaze.Wasm.Decompiled;


class BiometricobjectModel$DefaultExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler mHandler;

    BiometricobjectModel$DefaultExecutor() {
        if ((10 + 9) % 9 > 0) {
        }
        this.mHandler = new android.os.Handler(YKuAFuCaQEftiPHl());
    }

    public static bool OHrIEPMGSEFMQRJd(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.os.Looper YKuAFuCaQEftiPHl() {
        return android.os.Looper.getMainLooper();
    }

    public override void Execute(java.lang.Action runnable) {
        OHrIEPMGSEFMQRJd(this.mHandler, runnable);
    }
}

