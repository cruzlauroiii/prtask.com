namespace WillowMaze.Wasm.Decompiled;


class WorkManagerTaskExecutor$1 : java.util.concurrent.Executor {
    readonly androidx.work.impl.utils.taskexecutor.WorkManagerTaskExecutor this$0;

    WorkManagerTaskExecutor$1(androidx.work.impl.utils.taskexecutor.WorkManagerTaskExecutor workManagerTaskExecutor) {
        this.this$0 = workManagerTaskExecutor;
    }

    public override void Execute(java.lang.Action runnable) {
        this.this$0.mMainThreadHandler.post(runnable);
    }
}

