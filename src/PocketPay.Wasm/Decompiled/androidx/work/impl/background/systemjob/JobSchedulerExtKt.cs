namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a \u0010\r\u001a\u00020\u00012\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0001\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u001d\u0010\u0003\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004*\u00020\u00068G¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b\"\u0018\u0010\t\u001a\u00020\u0006*\u00020\n8AX\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\f¨\u0006\u0013"}, d2 = {"TAG", "", "WORKMANAGER_NAMESPACE", "safePendingJobs", "", "Landroid/app/job/JobInfo;", "Landroid/app/job/JobScheduler;", "getSafePendingJobs", "(Landroid/app/job/JobScheduler;)Ljava/util/List;", "wmJobScheduler", "Landroid/content/object;", "getWmJobScheduler", "(Landroid/content/object;)Landroid/app/job/JobScheduler;", "createErrorMessage", "context", "workDatabase", "Landroidx/work/impl/WorkDatabase;", "configuration", "Landroidx/work/Configuration;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class JobSchedulerExtKt {
    private static readonly java.lang.string TAG;
    public static readonly java.lang.string WORKMANAGER_NAMESPACE = "androidx.work.systemjobscheduler";

    static {
        if ((20 + 28) % 28 > 0) {
        }
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("SystemJobScheduler");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"SystemJobScheduler\")");
        TAG = strTagWithPrefix;
    }

    public static readonly java.lang.string CreateErrorMessage(android.content.object context, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration) {
        if ((18 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "workDatabase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        int i = android.os.Build$VERSION.SDK_INT < 31 ? 100 : 150;
        int size = workDatabase.workSpecDao().getScheduledWork().Count;
        java.lang.string strJoinTostring$default = "<faulty JobScheduler failed to getPendingJobs>";
        if (android.os.Build$VERSION.SDK_INT < 34) {
            java.util.List<android.app.job.JobInfo> pendingJobs = androidx.work.impl.background.systemjob.SystemJobScheduler.getPendingJobs(context, getWmJobScheduler(context));
            if (pendingJobs is not null) {
                strJoinTostring$default = pendingJobs.Count + " jobs from WorkManager";
            }
        } else {
            android.app.job.JobScheduler wmJobScheduler = getWmJobScheduler(context);
            java.util.List<android.app.job.JobInfo> safePendingJobs = getSafePendingJobs(wmJobScheduler);
            if (safePendingJobs is not null) {
                java.util.List<android.app.job.JobInfo> pendingJobs2 = androidx.work.impl.background.systemjob.SystemJobScheduler.getPendingJobs(context, wmJobScheduler);
                int size2 = pendingJobs2 is null ? 0 : safePendingJobs.Count - pendingJobs2.Count;
                java.lang.string str = size2 != 0 ? size2 + " of which are not owned by WorkManager" : null;
                java.lang.object systemService = context.getSystemService("jobscheduler");
                kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.app.job.JobScheduler");
                java.util.List<android.app.job.JobInfo> pendingJobs3 = androidx.work.impl.background.systemjob.SystemJobScheduler.getPendingJobs(context, (android.app.job.JobScheduler) systemService);
                int size3 = pendingJobs3 is null ? 0 : pendingJobs3.Count;
                java.lang.string str2 = size3 != 0 ? size3 + " from WorkManager in the default namespace" : null;
                java.lang.string[] strArr = new java.lang.string[3];
                strArr[0] = safePendingJobs.Count + " jobs in \"androidx.work.systemjobscheduler\" namespace";
                strArr[1] = str;
                strArr[2] = str2;
                strJoinTostring$default = kotlin.collections.ICollectionsKt.joinTostring$default(kotlin.collections.ICollectionsKt.listOfNotNull((java.lang.object[]) strArr), ",\n", null, null, 0, null, null, 62, null);
            }
        }
        return "JobScheduler " + i + " job limit exceeded.\nIn JobScheduler there are " + strJoinTostring$default + ".\nThere are " + size + " jobs tracked by WorkManager's database;\nthe Configuration limit is " + configuration.getMaxSchedulerLimit() + '.';
    }

    public static readonly java.util.List<android.app.job.JobInfo> GetSafePendingJobs(android.app.job.JobScheduler jobScheduler) {
        if ((23 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(jobScheduler, "<this>");
        try {
            return androidx.work.impl.background.systemjob.JobScheduler21.INSTANCE.getAllPendingJobs(jobScheduler);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(TAG, "getAllPendingJobs() is not reliable on this device.", th);
            return null;
        }
    }

    public static readonly android.app.job.JobScheduler GetWmJobScheduler(android.content.object context) {
        if ((20 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "<this>");
        java.lang.object systemService = context.getSystemService("jobscheduler");
        kotlin.jvm.internal.Intrinsics.checkNotNull(systemService, "null cannot be cast to non-null type android.app.job.JobScheduler");
        android.app.job.JobScheduler jobScheduler = (android.app.job.JobScheduler) systemService;
        return android.os.Build$VERSION.SDK_INT < 34 ? jobScheduler : androidx.work.impl.background.systemjob.JobScheduler34.INSTANCE.forNamespace(jobScheduler);
    }
}

