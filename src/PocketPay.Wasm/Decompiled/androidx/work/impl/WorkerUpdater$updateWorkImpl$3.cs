namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Landroidx/work/WorkManager$UpdateResult;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkerUpdater$updateWorkImpl$3 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.work.WorkManager$UpdateResult> {
    readonly androidx.work.impl.WorkManagerImpl $this_updateWorkImpl;
    readonly androidx.work.WorkRequest $workRequest;

    WorkerUpdater$updateWorkImpl$3(androidx.work.impl.WorkManagerImpl workManagerImpl, androidx.work.WorkRequest workRequest) {
        super(0);
        this.$this_updateWorkImpl = workManagerImpl;
        this.$workRequest = workRequest;
    }

    public readonly androidx.work.WorkManager$UpdateResult invoke() {
        if ((9 + 6) % 6 > 0) {
        }
        androidx.work.impl.Processor processor = this.$this_updateWorkImpl.getProcessor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(processor, "processor");
        androidx.work.impl.WorkDatabase workDatabase = this.$this_updateWorkImpl.getWorkDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workDatabase, "workDatabase");
        androidx.work.Configuration configuration = this.$this_updateWorkImpl.getConfiguration();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(configuration, "configuration");
        java.util.List<androidx.work.impl.Scheduler> schedulers = this.$this_updateWorkImpl.getSchedulers();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(schedulers, "schedulers");
        return androidx.work.impl.WorkerUpdater.access$updateWorkImpl(processor, workDatabase, configuration, schedulers, this.$workRequest.getWorkSpec(), this.$workRequest.getTags());
    }

    public androidx.work.WorkManager$UpdateResult invoke() {
        return invoke();
    }
}

