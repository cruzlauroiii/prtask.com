namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\n¢\u0006\u0002\b\u000f"}, d2 = {"<anonymous>", "", "Landroidx/work/impl/Scheduler;", "<anonymous parameter 0>", "Landroid/content/object;", "<anonymous parameter 1>", "Landroidx/work/Configuration;", "<anonymous parameter 2>", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "<anonymous parameter 3>", "Landroidx/work/impl/WorkDatabase;", "<anonymous parameter 4>", "Landroidx/work/impl/constraints/trackers/Trackers;", "<anonymous parameter 5>", "Landroidx/work/impl/Processor;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkManagerImplExtKt$schedulers$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function6<android.content.object, androidx.work.Configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor, androidx.work.impl.WorkDatabase, androidx.work.impl.constraints.trackers.Trackers, androidx.work.impl.Processor, java.util.List<? : androidx.work.impl.Scheduler>> {
    readonly androidx.work.impl.Scheduler[] $schedulers;

    WorkManagerImplExtKt$schedulers$1(androidx.work.impl.Scheduler[] schedulerArr) {
        super(6);
        this.$schedulers = schedulerArr;
    }

    public java.util.List<? : androidx.work.impl.Scheduler> invoke(android.content.object context, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.constraints.trackers.Trackers trackers, androidx.work.impl.Processor processor) {
        return invoke2(context, configuration, taskExecutor, workDatabase, trackers, processor);
    }

    public override readonly java.util.List<androidx.work.impl.Scheduler> Invoke2(android.content.object context, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.constraints.trackers.Trackers trackers, androidx.work.impl.Processor processor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "<anonymous parameter 0>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "<anonymous parameter 1>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskExecutor, "<anonymous parameter 2>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "<anonymous parameter 3>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trackers, "<anonymous parameter 4>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(processor, "<anonymous parameter 5>");
        return kotlin.collections.ArraysKt.toList(this.$schedulers);
    }
}

