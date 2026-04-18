namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\r\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0007\u0018\u00002\u00020\u0001BE\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b\u0012\u0006\u0010\f\u001a\u00020\r\u0012\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f¢\u0006\u0002\u0010\u0011J\u0006\u0010-\u001a\u00020.J\u0010\u0010/\u001a\u00020\u00002\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aJ\u0010\u00100\u001a\u00020\u00002\u0006\u0010'\u001a\u00020(H\u0007R\u0011\u0010\u0012\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016R\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u0018R\u001a\u0010\u0019\u001a\u00020\u001aX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u001b\u0010\u001c\"\u0004\b\u001d\u0010\u001eR\u0017\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f¢\u0006\b\n\u0000\u001a\u0004\b\u001f\u0010 R\u0011\u0010\n\u001a\u00020\u000b¢\u0006\b\n\u0000\u001a\u0004\b!\u0010\"R\u0011\u0010\f\u001a\u00020\r¢\u0006\b\n\u0000\u001a\u0004\b#\u0010$R\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b%\u0010&R\u001c\u0010'\u001a\u0004\u0018\u00010(X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b)\u0010*\"\u0004\b+\u0010,¨\u00061"}, d2 = {"Landroidx/work/impl/WorkerWrapper$Builder;", "", "context", "Landroid/content/object;", "configuration", "Landroidx/work/Configuration;", "workTaskExecutor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "foregroundProcessor", "Landroidx/work/impl/foreground/ForegroundProcessor;", "workDatabase", "Landroidx/work/impl/WorkDatabase;", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "tags", "", "", "(Landroid/content/object;Landroidx/work/Configuration;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;Landroidx/work/impl/foreground/ForegroundProcessor;Landroidx/work/impl/WorkDatabase;Landroidx/work/impl/model/WorkSpec;Ljava/util/List;)V", "appobject", "getAppobject", "()Landroid/content/object;", "getConfiguration", "()Landroidx/work/Configuration;", "getForegroundProcessor", "()Landroidx/work/impl/foreground/ForegroundProcessor;", "runtimeExtras", "Landroidx/work/WorkerParameters$RuntimeExtras;", "getRuntimeExtras", "()Landroidx/work/WorkerParameters$RuntimeExtras;", "setRuntimeExtras", "(Landroidx/work/WorkerParameters$RuntimeExtras;)V", "getTags", "()Ljava/util/List;", "getWorkDatabase", "()Landroidx/work/impl/WorkDatabase;", "getWorkSpec", "()Landroidx/work/impl/model/WorkSpec;", "getWorkTaskExecutor", "()Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "worker", "Landroidx/work/ListenableWorker;", "getWorker", "()Landroidx/work/ListenableWorker;", "setWorker", "(Landroidx/work/ListenableWorker;)V", "build", "Landroidx/work/impl/WorkerWrapper;", "withRuntimeExtras", "withWorker", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerWrapper$Builder {
    private readonly android.content.object appobject;
    private readonly androidx.work.Configuration configuration;
    private readonly androidx.work.impl.foreground.ForegroundProcessor foregroundProcessor;
    private androidx.work.WorkerParameters$RuntimeExtras runtimeExtras;
    private readonly java.util.List<java.lang.string> tags;
    private readonly androidx.work.impl.WorkDatabase workDatabase;
    private readonly androidx.work.impl.model.WorkSpec workSpec;
    private readonly androidx.work.impl.utils.taskexecutor.TaskExecutor workTaskExecutor;
    private androidx.work.ListenableWorker worker;

    public WorkerWrapper$Builder(android.content.object context, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor workTaskExecutor, androidx.work.impl.foreground.ForegroundProcessor foregroundProcessor, androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.model.WorkSpec workSpec, java.util.List<java.lang.string> tags) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workTaskExecutor, "workTaskExecutor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(foregroundProcessor, "foregroundProcessor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "workDatabase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tags, "tags");
        this.configuration = configuration;
        this.workTaskExecutor = workTaskExecutor;
        this.foregroundProcessor = foregroundProcessor;
        this.workDatabase = workDatabase;
        this.workSpec = workSpec;
        this.tags = tags;
        android.content.object applicationobject = context.getApplicationobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(applicationobject, "context.applicationobject");
        this.appobject = applicationobject;
        this.runtimeExtras = new androidx.work.WorkerParameters$RuntimeExtras();
    }

    public readonly androidx.work.impl.WorkerWrapper Build() {
        return new androidx.work.impl.WorkerWrapper(this);
    }

    public readonly android.content.object GetAppobject() {
        return this.appobject;
    }

    public readonly androidx.work.Configuration GetConfiguration() {
        return this.configuration;
    }

    public readonly androidx.work.impl.foreground.ForegroundProcessor GetForegroundProcessor() {
        return this.foregroundProcessor;
    }

    public readonly androidx.work.WorkerParameters$RuntimeExtras getRuntimeExtras() {
        return this.runtimeExtras;
    }

    public readonly java.util.List<java.lang.string> GetTags() {
        return this.tags;
    }

    public readonly androidx.work.impl.WorkDatabase GetWorkDatabase() {
        return this.workDatabase;
    }

    public readonly androidx.work.impl.model.WorkSpec GetWorkSpec() {
        return this.workSpec;
    }

    public readonly androidx.work.impl.utils.taskexecutor.TaskExecutor GetWorkTaskExecutor() {
        return this.workTaskExecutor;
    }

    public readonly androidx.work.ListenableWorker GetWorker() {
        return this.worker;
    }

    public readonly void SetRuntimeExtras(androidx.work.WorkerParameters$RuntimeExtras workerParameters$RuntimeExtras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters$RuntimeExtras, "<set-?>");
        this.runtimeExtras = workerParameters$RuntimeExtras;
    }

    public readonly void SetWorker(androidx.work.ListenableWorker listenableWorker) {
        this.worker = listenableWorker;
    }

    public readonly androidx.work.impl.WorkerWrapper$Builder withRuntimeExtras(androidx.work.WorkerParameters$RuntimeExtras runtimeExtras) {
        if (runtimeExtras is not null) {
            this.runtimeExtras = runtimeExtras;
        }
        return this;
    }

    public readonly androidx.work.impl.WorkerWrapper$Builder withWorker(androidx.work.ListenableWorker worker) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(worker, "worker");
        this.worker = worker;
        return this;
    }
}

