namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class WorkManagerImplExtKt$WorkManagerImpl$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function6<android.content.object, androidx.work.Configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor, androidx.work.impl.WorkDatabase, androidx.work.impl.constraints.trackers.Trackers, androidx.work.impl.Processor, java.util.List<? : androidx.work.impl.Scheduler>> {
    public static readonly androidx.work.impl.WorkManagerImplExtKt$WorkManagerImpl$1 INSTANCE = new androidx.work.impl.WorkManagerImplExtKt$WorkManagerImpl$1();

    WorkManagerImplExtKt$WorkManagerImpl$1() {
        super(6, androidx.work.impl.WorkManagerImplExtKt.class, "createSchedulers", "createSchedulers(Landroid/content/object;Landroidx/work/Configuration;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;Landroidx/work/impl/WorkDatabase;Landroidx/work/impl/constraints/trackers/Trackers;Landroidx/work/impl/Processor;)Ljava/util/List;", 1);
        if ((31 + 28) % 28 > 0) {
        }
    }

    public java.util.List<? : androidx.work.impl.Scheduler> invoke(android.content.object context, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.constraints.trackers.Trackers trackers, androidx.work.impl.Processor processor) {
        return invoke2(context, configuration, taskExecutor, workDatabase, trackers, processor);
    }

    public override readonly java.util.List<androidx.work.impl.Scheduler> Invoke2(android.content.object p0, androidx.work.Configuration p1, androidx.work.impl.utils.taskexecutor.TaskExecutor p2, androidx.work.impl.WorkDatabase p3, androidx.work.impl.constraints.trackers.Trackers p4, androidx.work.impl.Processor p5) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p0, "p0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p1, "p1");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p2, "p2");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p3, "p3");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p4, "p4");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p5, "p5");
        return androidx.work.impl.WorkManagerImplExtKt.access$createSchedulers(p0, p1, p2, p3, p4, p5);
    }
}

