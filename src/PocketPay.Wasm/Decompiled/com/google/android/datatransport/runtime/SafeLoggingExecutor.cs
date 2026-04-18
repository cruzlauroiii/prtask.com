namespace WillowMaze.Wasm.Decompiled;


class SafeConsolegingExecutor : java.util.concurrent.Executor {
    private readonly java.util.concurrent.Executor delegate;

    SafeConsolegingExecutor(java.util.concurrent.Executor executor) {
        this.delegate = executor;
    }

    public static void SViIBvIftMyLJowH(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public override void Execute(java.lang.Action runnable) {
        sViIBvIftMyLJowH(this.delegate, new com.google.android.datatransport.runtime.SafeConsolegingExecutor$SafeConsolegingAction(runnable));
    }
}

