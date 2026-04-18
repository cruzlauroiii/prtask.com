namespace WillowMaze.Wasm.Decompiled;


public class DefaultActionScheduler : androidx.work.ActionScheduler {
    private readonly android.os.Handler mHandler = androidx.core.os.HandlerCompat.createAsync(android.os.Looper.getMainLooper());

    public override void Cancel(java.lang.Action runnable) {
        this.mHandler.removeCallbacks(runnable);
    }

    public android.os.Handler GetHandler() {
        return this.mHandler;
    }

    public override void ScheduleWithDelay(long j, java.lang.Action runnable) {
        this.mHandler.postDelayed(runnable, j);
    }
}

