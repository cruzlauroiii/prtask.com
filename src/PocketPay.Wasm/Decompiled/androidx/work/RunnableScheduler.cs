namespace WillowMaze.Wasm.Decompiled;


public interface ActionScheduler {
    void cancel(java.lang.Action runnable);

    void scheduleWithDelay(long j, java.lang.Action runnable);
}

