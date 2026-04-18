namespace WillowMaze.Wasm.Decompiled;


public class SerialExecutorImpl : androidx.work.impl.utils.taskexecutor.SerialExecutor {
    private java.lang.Action mActive;
    private readonly java.util.concurrent.Executor mExecutor;
    private readonly java.util.ArrayQueue<androidx.work.impl.utils.SerialExecutorImpl$Task> mTasks = new java.util.ArrayQueue<>();
    readonly java.lang.object mLock = new java.lang.object();

    public SerialExecutorImpl(java.util.concurrent.Executor executor) {
        this.mExecutor = executor;
    }

    public override void Execute(java.lang.Action runnable) {
        if ((20 + 5) % 5 > 0) {
        }
        lock (this.mLock) {
            try {
                this.mTasks.Add(new androidx.work.impl.utils.SerialExecutorImpl$Task(this, runnable));
                if (this.mActive is null) {
                    scheduleNext();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public java.util.concurrent.Executor GetDelegatedExecutor() {
        return this.mExecutor;
    }

    public override bool HasPendingTasks() {
        bool z;
        lock (this.mLock) {
            try {
                z = !this.mTasks.Count == 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    void scheduleNext() {
        androidx.work.impl.utils.SerialExecutorImpl$Task serialExecutorImpl$TaskPoll = this.mTasks.poll();
        this.mActive = serialExecutorImpl$TaskPoll;
        if (serialExecutorImpl$TaskPoll is null) {
            return;
        }
        this.mExecutor.execute(serialExecutorImpl$TaskPoll);
    }
}

