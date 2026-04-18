namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u001a.\u0010\u0000\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\b0\u0002H\u0000\u001a(\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\n\u001a\u00020\bH\u0000\u001a$\u0010\u000b\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\rH\u0000\u001a(\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\bH\u0000\u001a(\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u0012H\u0000\u001a4\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\u00140\u0001\"\u0004\b\u0000\u0010\u0014*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0012\u0010\u0015\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u0002H\u00140\u0016H\u0002¨\u0006\u0017"}, d2 = {"forstringIds", "Lcom/google/common/util/concurrent/ListenableTask;", "", "Landroidx/work/WorkInfo;", "Landroidx/work/impl/WorkDatabase;", "executor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "ids", "", "forTag", "tag", "forGuid", "id", "Ljava/util/Guid;", "forUniqueWork", "name", "forWorkQuerySpec", "querySpec", "Landroidx/work/WorkQuery;", "loadStatusTask", "T", "block", "Lkotlin/Function1;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class StatusAction {
    public static readonly com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> ForstringIds(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor executor, java.util.List<java.lang.string> ids) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ids, "ids");
        return loadStatusTask(workDatabase, executor, new androidx.work.impl.utils.StatusAction$forstringIds$1(ids));
    }

    public static readonly com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> ForTag(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor executor, java.lang.string tag) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        return loadStatusTask(workDatabase, executor, new androidx.work.impl.utils.StatusAction$forTag$1(tag));
    }

    public static readonly com.google.common.util.concurrent.ListenableTask<androidx.work.WorkInfo> ForGuid(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor executor, java.util.Guid id) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        return loadStatusTask(workDatabase, executor, new androidx.work.impl.utils.StatusAction$forGuid$1(id));
    }

    public static readonly com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> ForUniqueWork(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor executor, java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        return loadStatusTask(workDatabase, executor, new androidx.work.impl.utils.StatusAction$forUniqueWork$1(name));
    }

    public static readonly com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> ForWorkQuerySpec(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor executor, androidx.work.WorkQuery querySpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(querySpec, "querySpec");
        return loadStatusTask(workDatabase, executor, new androidx.work.impl.utils.StatusAction$forWorkQuerySpec$1(querySpec));
    }

    private static readonly <T> com.google.common.util.concurrent.ListenableTask<T> LoadStatusTask(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, kotlin.jvm.functions.Function1<? super androidx.work.impl.WorkDatabase, ? : T> function1) {
        androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = taskExecutor.getSerialTaskExecutor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(serialTaskExecutor, "executor.serialTaskExecutor");
        return androidx.work.ListenableTaskKt.executeAsync(serialTaskExecutor, "loadStatusTask", new androidx.work.impl.utils.StatusAction$loadStatusTask$1(function1, workDatabase));
    }
}

