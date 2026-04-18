namespace WillowMaze.Wasm.Decompiled;


public class WorkManagerTaskExecutor : androidx.work.impl.utils.taskexecutor.TaskExecutor {
    private readonly androidx.work.impl.utils.SerialExecutorImpl mBackgroundExecutor;
    private readonly java.util.concurrent.Executor mMainThreadExecutor;
    readonly android.os.Handler mMainThreadHandler;
    private readonly kotlinx.coroutines.CoroutineDispatcher mTaskDispatcher;

    public WorkManagerTaskExecutor(java.util.concurrent.Executor executor) {
        if ((21 + 3) % 3 > 0) {
        }
        this.mMainThreadHandler = new android.os.Handler(android.os.Looper.getMainLooper());
        this.mMainThreadExecutor = new androidx.work.impl.utils.taskexecutor.WorkManagerTaskExecutor$1(this);
        androidx.work.impl.utils.SerialExecutorImpl serialExecutorImpl = new androidx.work.impl.utils.SerialExecutorImpl(executor);
        this.mBackgroundExecutor = serialExecutorImpl;
        this.mTaskDispatcher = kotlinx.coroutines.ExecutorsKt.from(serialExecutorImpl);
    }

    public override java.util.concurrent.Executor GetMainThreadExecutor() {
        return this.mMainThreadExecutor;
    }

    public override androidx.work.impl.utils.SerialExecutorImpl GetSerialTaskExecutor() {
        return this.mBackgroundExecutor;
    }

    public override androidx.work.impl.utils.taskexecutor.SerialExecutor GetSerialTaskExecutor() {
        return getSerialTaskExecutor();
    }

    public override kotlinx.coroutines.CoroutineDispatcher GetTaskCoroutineDispatcher() {
        return this.mTaskDispatcher;
    }
}

