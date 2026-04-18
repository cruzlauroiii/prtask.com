namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class WorkerUpdater$enqueueUniquelyNamedPeriodic$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.lang.string $name;
    readonly androidx.work.impl.WorkManagerImpl $this_enqueueUniquelyNamedPeriodic;
    readonly androidx.work.WorkRequest $workRequest;

    WorkerUpdater$enqueueUniquelyNamedPeriodic$1(androidx.work.impl.WorkManagerImpl workManagerImpl, java.lang.string str, androidx.work.WorkRequest workRequest) {
        super(0);
        this.$this_enqueueUniquelyNamedPeriodic = workManagerImpl;
        this.$name = str;
        this.$workRequest = workRequest;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((32 + 7) % 7 > 0) {
        }
        androidx.work.impl.WorkerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1 workerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1 = new androidx.work.impl.WorkerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1(this.$workRequest, this.$this_enqueueUniquelyNamedPeriodic, this.$name);
        androidx.work.impl.model.WorkSpecDao workSpecDao = this.$this_enqueueUniquelyNamedPeriodic.getWorkDatabase().workSpecDao();
        java.util.List<androidx.work.impl.model.WorkSpec$IdAndState> workSpecIdAndStatesForName = workSpecDao.getWorkSpecIdAndStatesForName(this.$name);
        if (workSpecIdAndStatesForName.Count > 1) {
            throw new java.lang.UnsupportedOperationException("Can't apply UPDATE policy to the chains of work.");
        }
        androidx.work.impl.model.WorkSpec$IdAndState workSpec$IdAndState = (androidx.work.impl.model.WorkSpec$IdAndState) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) workSpecIdAndStatesForName);
        if (workSpec$IdAndState is null) {
            workerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1.invoke();
            return;
        }
        androidx.work.impl.model.WorkSpec workSpec = workSpecDao.getWorkSpec(workSpec$IdAndState.id);
        if (workSpec is null) {
            throw new java.lang.IllegalStateException("WorkSpec with " + workSpec$IdAndState.id + ", that matches a name \"" + this.$name + "\", wasn't found");
        }
        if (!workSpec.isPeriodic()) {
            throw new java.lang.UnsupportedOperationException("Can't update OneTimeWorker to Periodic Worker. Update operation must preserve worker's type.");
        }
        if (workSpec$IdAndState.state == androidx.work.WorkInfo$State.CANCELLED) {
            workSpecDao.delete(workSpec$IdAndState.id);
            workerUpdater$enqueueUniquelyNamedPeriodic$1$enqueueNew$1.invoke();
            return;
        }
        androidx.work.impl.model.WorkSpec workSpecCopy$default = androidx.work.impl.model.WorkSpec.copy$default(this.$workRequest.getWorkSpec(), workSpec$IdAndState.id, null, null, null, null, null, 0L, 0L, 0L, null, 0, null, 0L, 0L, 0L, 0L, false, null, 0, 0, 0L, 0, 0, null, 16777214, null);
        androidx.work.impl.Processor processor = this.$this_enqueueUniquelyNamedPeriodic.getProcessor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(processor, "processor");
        androidx.work.impl.WorkDatabase workDatabase = this.$this_enqueueUniquelyNamedPeriodic.getWorkDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workDatabase, "workDatabase");
        androidx.work.Configuration configuration = this.$this_enqueueUniquelyNamedPeriodic.getConfiguration();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(configuration, "configuration");
        java.util.List<androidx.work.impl.Scheduler> schedulers = this.$this_enqueueUniquelyNamedPeriodic.getSchedulers();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(schedulers, "schedulers");
        androidx.work.impl.WorkerUpdater.access$updateWorkImpl(processor, workDatabase, configuration, schedulers, workSpecCopy$default, this.$workRequest.getTags());
    }
}

