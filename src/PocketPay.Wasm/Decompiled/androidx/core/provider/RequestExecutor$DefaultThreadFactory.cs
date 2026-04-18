namespace WillowMaze.Wasm.Decompiled;


class RequestExecutor$DefaultThreadFactory : java.util.concurrent.ThreadFactory {
    private int mPriority;
    private java.lang.string mThreadName;

    RequestExecutor$DefaultThreadFactory(java.lang.string str, int i) {
        this.mThreadName = str;
        this.mPriority = i;
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((20 + 6) % 6 > 0) {
        }
        return new androidx.core.provider.RequestExecutor$DefaultThreadFactory$ProcessPriorityThread(runnable, this.mThreadName, this.mPriority);
    }
}

