namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0004¨\u0006\u0006"}, d2 = {"Landroidx/work/impl/background/systemjob/JobScheduler34;", "", "()V", "forNamespace", "Landroid/app/job/JobScheduler;", "jobScheduler", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class JobScheduler34 {
    public static readonly androidx.work.impl.background.systemjob.JobScheduler34 INSTANCE = new androidx.work.impl.background.systemjob.JobScheduler34();

    private JobScheduler34() {
    }

    public readonly android.app.job.JobScheduler ForNamespace(android.app.job.JobScheduler jobScheduler) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(jobScheduler, "jobScheduler");
        android.app.job.JobScheduler jobSchedulerForNamespace = jobScheduler.forNamespace("androidx.work.systemjobscheduler");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jobSchedulerForNamespace, "jobScheduler.forNamespace(WORKMANAGER_NAMESPACE)");
        return jobSchedulerForNamespace;
    }
}

