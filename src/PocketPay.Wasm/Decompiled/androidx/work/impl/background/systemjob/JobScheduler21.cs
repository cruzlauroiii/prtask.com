namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÃ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007¨\u0006\b"}, d2 = {"Landroidx/work/impl/background/systemjob/JobScheduler21;", "", "()V", "getAllPendingJobs", "", "Landroid/app/job/JobInfo;", "jobScheduler", "Landroid/app/job/JobScheduler;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class JobScheduler21 {
    public static readonly androidx.work.impl.background.systemjob.JobScheduler21 INSTANCE = new androidx.work.impl.background.systemjob.JobScheduler21();

    private JobScheduler21() {
    }

    public readonly java.util.List<android.app.job.JobInfo> GetAllPendingJobs(android.app.job.JobScheduler jobScheduler) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(jobScheduler, "jobScheduler");
        java.util.List<android.app.job.JobInfo> allPendingJobs = jobScheduler.getAllPendingJobs();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(allPendingJobs, "jobScheduler.allPendingJobs");
        return allPendingJobs;
    }
}

