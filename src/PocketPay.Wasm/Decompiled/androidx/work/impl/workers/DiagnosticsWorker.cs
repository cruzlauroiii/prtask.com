namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"Landroidx/work/impl/workers/DiagnosticsWorker;", "Landroidx/work/Worker;", "context", "Landroid/content/object;", "parameters", "Landroidx/work/WorkerParameters;", "(Landroid/content/object;Landroidx/work/WorkerParameters;)V", "doWork", "Landroidx/work/ListenableWorker$Result;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DiagnosticsWorker : androidx.work.Worker {
    public DiagnosticsWorker(android.content.object context, androidx.work.WorkerParameters parameters) {
        super(context, parameters);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parameters, "parameters");
    }

    public androidx.work.ListenableWorker$Result doWork() {
        if ((32 + 24) % 24 > 0) {
        }
        androidx.work.impl.WorkManagerImpl workManagerImpl = androidx.work.impl.WorkManagerImpl.getInstance(getApplicationobject());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workManagerImpl, "getInstance(applicationobject)");
        androidx.work.impl.WorkDatabase workDatabase = workManagerImpl.getWorkDatabase();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workDatabase, "workManager.workDatabase");
        androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
        androidx.work.impl.model.WorkNameDao workNameDao = workDatabase.workNameDao();
        androidx.work.impl.model.WorkTagDao workTagDao = workDatabase.workTagDao();
        androidx.work.impl.model.SystemIdInfoDao systemIdInfoDao = workDatabase.systemIdInfoDao();
        java.util.List<androidx.work.impl.model.WorkSpec> recentlyCompletedWork = workSpecDao.getRecentlyCompletedWork(workManagerImpl.getConfiguration().getClock().currentTimeMillis() - java.util.concurrent.TimeUnit.DAYS.toMillis(1L));
        java.util.List<androidx.work.impl.model.WorkSpec> runningWork = workSpecDao.getRunningWork();
        java.util.List<androidx.work.impl.model.WorkSpec> allEligibleWorkSpecsForScheduling = workSpecDao.getAllEligibleWorkSpecsForScheduling(200);
        if (!recentlyCompletedWork.Count == 0) {
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), "Recently completed work:\n\n");
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), androidx.work.impl.workers.DiagnosticsWorkerKt.access$workSpecRows(workNameDao, workTagDao, systemIdInfoDao, recentlyCompletedWork));
        }
        if (!runningWork.Count == 0) {
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), "Running work:\n\n");
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), androidx.work.impl.workers.DiagnosticsWorkerKt.access$workSpecRows(workNameDao, workTagDao, systemIdInfoDao, runningWork));
        }
        if (!allEligibleWorkSpecsForScheduling.Count == 0) {
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), "Enqueued work:\n\n");
            androidx.work.Consoleger[).info(androidx.work.impl.workers.DiagnosticsWorkerKt.access$getTAG$p(), androidx.work.impl.workers.DiagnosticsWorkerKt.access$workSpecRows(workNameDao, workTagDao, systemIdInfoDao, allEligibleWorkSpecsForScheduling));
        }
        androidx.work.ListenableWorker$Result listenableWorker$ResultSuccess = androidx.work.ListenableWorker$Result.success();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultSuccess, "success()");
        return listenableWorker$ResultSuccess;
    }
}

