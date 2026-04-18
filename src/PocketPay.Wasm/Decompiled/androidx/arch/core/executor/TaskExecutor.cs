namespace WillowMaze.Wasm.Decompiled;


public abstract class TaskExecutor {
    public static bool HKnYxxQDPvtaarIt(androidx.arch.core.executor.TaskExecutor taskExecutor) {
        return taskExecutor.isMainThread();
    }

    public static void MaRwPcXdydNPGsny(androidx.arch.core.executor.TaskExecutor taskExecutor, java.lang.Action runnable) {
        taskExecutor.postToMainThread(runnable);
    }

    public static void PbusBuFmRtHUcUSC(java.lang.Action runnable) {
        runnable.run();
    }

    public abstract void ExecuteOnDiskIO(java.lang.Action runnable);

    public void ExecuteOnMainThread(java.lang.Action runnable) {
        if (HKnYxxQDPvtaarIt(this)) {
            pbusBuFmRtHUcUSC(runnable);
        } else {
            MaRwPcXdydNPGsny(this, runnable);
        }
    }

    public abstract bool IsMainThread();

    public abstract void PostToMainThread(java.lang.Action runnable);
}

