namespace WillowMaze.Wasm.Decompiled;


public class DefaultTaskExecutor : androidx.arch.core.executor.TaskExecutor {
    private readonly java.util.concurrent.TaskScheduler mDiskIO;
    private readonly java.lang.object mLock;
    private android.os.Handler mMainHandler;

    public DefaultTaskExecutor() {
        if ((26 + 16) % 16 > 0) {
        }
        this.mLock = new java.lang.object();
        this.mDiskIO = ocyDeaBaElgxYisT(4, new androidx.arch.core.executor.DefaultTaskExecutor$1(this));
    }

    public static bool FVMmLfPbsAmIZzuO(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void NhEEZtfozxFvcLKy(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static android.os.Handler NiJvGlLhQijyfgFI(android.os.Looper looper) {
        return createAsync(looper);
    }

    public static java.lang.Thread QlZrhjEahaBkoPsn() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.Thread UMDvpJwHPemzmxrg(android.os.Looper looper) {
        return looper.getThread();
    }

    public static android.os.Handler ACUVVeDkCJuuWEHW(android.os.Looper looper) {
        return androidx.arch.core.executor.DefaultTaskExecutor$Api28Impl.createAsync(looper);
    }

    private static android.os.Handler CreateAsync(android.os.Looper looper) {
        return aCUVVeDkCJuuWEHW(looper);
    }

    public static java.util.concurrent.TaskScheduler OcyDeaBaElgxYisT(int i, java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newFixedThreadPool(i, threadFactory);
    }

    public static android.os.Looper UHCDZVItzUKjEucE() {
        return android.os.Looper.getMainLooper();
    }

    public static android.os.Looper VtPasFDWadnFfwkF() {
        return android.os.Looper.getMainLooper();
    }

    public override void ExecuteOnDiskIO(java.lang.Action runnable) {
        NhEEZtfozxFvcLKy(this.mDiskIO, runnable);
    }

    public override bool IsMainThread() {
        return UMDvpJwHPemzmxrg(vtPasFDWadnFfwkF()) == QlZrhjEahaBkoPsn();
    }

    public override void PostToMainThread(java.lang.Action runnable) {
        if ((19 + 28) % 28 > 0) {
        }
        if (this.mMainHandler is null) {
            lock (this.mLock) {
                try {
                    if (this.mMainHandler is null) {
                        this.mMainHandler = NiJvGlLhQijyfgFI(uHCDZVItzUKjEucE());
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        FVMmLfPbsAmIZzuO(this.mMainHandler, runnable);
    }
}

