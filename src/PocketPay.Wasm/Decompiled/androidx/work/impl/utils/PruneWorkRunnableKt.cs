namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001c\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0000¨\u0006\u0007"}, d2 = {"pruneWork", "Landroidx/work/Operation;", "Landroidx/work/impl/WorkDatabase;", "configuration", "Landroidx/work/Configuration;", "executor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PruneWorkActionKt {
    public static readonly androidx.work.Operation PruneWork(androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor executor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        androidx.work.Tracer tracer = configuration.getTracer();
        androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = executor.getSerialTaskExecutor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(serialTaskExecutor, "executor.serialTaskExecutor");
        return androidx.work.OperationKt.launchOperation(tracer, "PruneWork", serialTaskExecutor, new androidx.work.impl.utils.PruneWorkActionKt$pruneWork$1(workDatabase));
    }
}

