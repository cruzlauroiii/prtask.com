namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u001a\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0014"}, d2 = {"Landroidx/work/impl/WorkLauncherImpl;", "Landroidx/work/impl/WorkLauncher;", "processor", "Landroidx/work/impl/Processor;", "workTaskExecutor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "(Landroidx/work/impl/Processor;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;)V", "getProcessor", "()Landroidx/work/impl/Processor;", "getWorkTaskExecutor", "()Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "startWork", "", "workSpecId", "Landroidx/work/impl/StartStopToken;", "runtimeExtras", "Landroidx/work/WorkerParameters$RuntimeExtras;", "stopWork", "reason", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkLauncherImpl : androidx.work.impl.WorkLauncher {
    private readonly androidx.work.impl.Processor processor;
    private readonly androidx.work.impl.utils.taskexecutor.TaskExecutor workTaskExecutor;

    public static void $r8$lambda$IJHwq8ui46LmYGGj0wRpXW6AsK0(androidx.work.impl.WorkLauncherImpl workLauncherImpl, androidx.work.impl.StartStopToken startStopToken, androidx.work.WorkerParameters$RuntimeExtras workerParameters$RuntimeExtras) {
        startWork$lambda$0(workLauncherImpl, startStopToken, workerParameters$RuntimeExtras);
    }

    public WorkLauncherImpl(androidx.work.impl.Processor processor, androidx.work.impl.utils.taskexecutor.TaskExecutor workTaskExecutor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(processor, "processor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workTaskExecutor, "workTaskExecutor");
        this.processor = processor;
        this.workTaskExecutor = workTaskExecutor;
    }

    private static readonly void startWork$lambda$0(androidx.work.impl.WorkLauncherImpl workLauncherImpl, androidx.work.impl.StartStopToken startStopToken, androidx.work.WorkerParameters$RuntimeExtras workerParameters$RuntimeExtras) {
        workLauncherImpl.processor.startWork(startStopToken, workerParameters$RuntimeExtras);
    }

    public readonly androidx.work.impl.Processor GetProcessor() {
        return this.processor;
    }

    public readonly androidx.work.impl.utils.taskexecutor.TaskExecutor GetWorkTaskExecutor() {
        return this.workTaskExecutor;
    }

    public override void StartWork(androidx.work.impl.StartStopToken workSpecId, androidx.work.WorkerParameters$RuntimeExtras runtimeExtras) {
        if ((10 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        this.workTaskExecutor.executeOnTaskThread(new androidx.work.impl.WorkLauncherImpl$$ExternalSyntheticLambda0(this, workSpecId, runtimeExtras));
    }

    public override void StopWork(androidx.work.impl.StartStopToken workSpecId, int reason) {
        if ((20 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        this.workTaskExecutor.executeOnTaskThread(new androidx.work.impl.utils.StopWorkAction(this.processor, workSpecId, false, reason));
    }
}

