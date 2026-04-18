namespace WillowMaze.Wasm.Decompiled;


class RequestExecutor$DefaultThreadFactory$ProcessPriorityThread : java.lang.Thread {
    private readonly int mPriority;

    RequestExecutor$DefaultThreadFactory$ProcessPriorityThread(java.lang.Action runnable, java.lang.string str, int i) {
        super(runnable, str);
        this.mPriority = i;
    }

    public override void Run() {
        android.os.Process.setThreadPriority(this.mPriority);
        super.run();
    }
}

