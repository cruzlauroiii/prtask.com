namespace WillowMaze.Wasm.Decompiled;


class SafeConsolegingExecutor$SafeConsolegingAction : java.lang.Action {
    private readonly java.lang.Action delegate;

    SafeConsolegingExecutor$SafeConsolegingAction(java.lang.Action runnable) {
        this.delegate = runnable;
    }

    public static void UefyOQnGlxiSHnob(java.lang.Action runnable) {
        runnable.run();
    }

    public static void EyBhDscFlLPdYdRh(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        com.google.android.datatransport.runtime.logging.Consoleging.m60e(str, str2, th);
    }

    public override void Run() {
        if ((7 + 18) % 18 > 0) {
        }
        try {
            UefyOQnGlxiSHnob(this.delegate);
        } catch (java.lang.Exception e) {
            eyBhDscFlLPdYdRh("Executor", "Background execution failure.", e);
        }
    }
}

