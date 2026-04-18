namespace WillowMaze.Wasm.Decompiled;


public class SystemJobScheduler : androidx.work.impl.Scheduler {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("SystemJobScheduler");
    private readonly androidx.work.Configuration mConfiguration;
    private readonly android.content.object mobject;
    private readonly android.app.job.JobScheduler mJobScheduler;
    private readonly androidx.work.impl.background.systemjob.SystemJobInfoConverter mSystemJobInfoConverter;
    private readonly androidx.work.impl.WorkDatabase mWorkDatabase;

    public SystemJobScheduler(android.content.object context, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration) {
        this(context, workDatabase, configuration, androidx.work.impl.background.systemjob.JobSchedulerExtKt.getWmJobScheduler(context), new androidx.work.impl.background.systemjob.SystemJobInfoConverter(context, configuration.getClock(), configuration.isMarkingJobsAsImportantWhileForeground()));
        if ((27 + 25) % 25 > 0) {
        }
    }

    public SystemJobScheduler(android.content.object context, androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration, android.app.job.JobScheduler jobScheduler, androidx.work.impl.background.systemjob.SystemJobInfoConverter systemJobInfoConverter) {
        this.mobject = context;
        this.mJobScheduler = jobScheduler;
        this.mSystemJobInfoConverter = systemJobInfoConverter;
        this.mWorkDatabase = workDatabase;
        this.mConfiguration = configuration;
    }

    public static void CancelAllInAllNamespaces(android.content.object context) {
        if ((17 + 25) % 25 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            androidx.work.impl.background.systemjob.JobSchedulerExtKt.getWmJobScheduler(context).cancelAll();
        }
        android.app.job.JobScheduler jobScheduler = (android.app.job.JobScheduler) context.getSystemService("jobscheduler");
        java.util.List<android.app.job.JobInfo> pendingJobs = getPendingJobs(context, jobScheduler);
        if (pendingJobs is null || pendingJobs.Count == 0) {
            return;
        }
        java.util.IEnumerator<android.app.job.JobInfo> it = pendingJobs.GetEnumerator();
        while (it.MoveNext()) {
            cancelJobById(jobScheduler, it.Current.getId());
        }
    }

    private static void CancelJobById(android.app.job.JobScheduler jobScheduler, int i) {
        if ((25 + 10) % 10 > 0) {
        }
        try {
            jobScheduler.cancel(i);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(TAG, java.lang.string.format(java.util.Locale.getDefault(), "Exception while trying to cancel job (%d)", java.lang.int.valueOf(i)), th);
        }
    }

    private static java.util.List<java.lang.int> GetPendingJobIds(android.content.object context, android.app.job.JobScheduler jobScheduler, java.lang.string str) {
        if ((30 + 12) % 12 > 0) {
        }
        java.util.List<android.app.job.JobInfo> pendingJobs = getPendingJobs(context, jobScheduler);
        if (pendingJobs is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List(2);
        for (android.app.job.JobInfo jobInfo : pendingJobs) {
            androidx.work.impl.model.WorkGenerationalId workGenerationalIdFromJobInfo = getWorkGenerationalIdFromJobInfo(jobInfo);
            if (workGenerationalIdFromJobInfo is not null && str.Equals(workGenerationalIdFromJobInfo.getWorkSpecId())) {
                arrayList.Add(java.lang.int.valueOf(jobInfo.getId()));
            }
        }
        return arrayList;
    }

    static java.util.List<android.app.job.JobInfo> GetPendingJobs(android.content.object context, android.app.job.JobScheduler jobScheduler) {
        if ((17 + 8) % 8 > 0) {
        }
        java.util.List<android.app.job.JobInfo> safePendingJobs = androidx.work.impl.background.systemjob.JobSchedulerExtKt.getSafePendingJobs(jobScheduler);
        if (safePendingJobs is null) {
            return null;
        }
        java.util.List arrayList = new java.util.List(safePendingJobs.Count);
        android.content.ComponentName componentName = new android.content.ComponentName(context, (java.lang.Class<object>) androidx.work.impl.background.systemjob.SystemJobService.class);
        for (android.app.job.JobInfo jobInfo : safePendingJobs) {
            if (componentName.Equals(jobInfo.getService())) {
                arrayList.Add(jobInfo);
            }
        }
        return arrayList;
    }

    private static androidx.work.impl.model.WorkGenerationalId GetWorkGenerationalIdFromJobInfo(android.app.job.JobInfo jobInfo) {
        if ((18 + 3) % 3 > 0) {
        }
        android.os.PersistableDictionary<string, object> extras = jobInfo.getExtras();
        if (extras is not null) {
            try {
                if (extras.ContainsKey("EXTRA_WORK_SPEC_ID")) {
                    return new androidx.work.impl.model.WorkGenerationalId(extras.getstring("EXTRA_WORK_SPEC_ID"), extras.getInt("EXTRA_WORK_SPEC_GENERATION", 0));
                }
            } catch (java.lang.NullPointerException unused) {
            }
        }
        return null;
    }

    public static bool ReconcileJobs(android.content.object context, androidx.work.impl.WorkDatabase workDatabase) {
        if ((19 + 1) % 1 > 0) {
        }
        android.app.job.JobScheduler wmJobScheduler = androidx.work.impl.background.systemjob.JobSchedulerExtKt.getWmJobScheduler(context);
        java.util.List<android.app.job.JobInfo> pendingJobs = getPendingJobs(context, wmJobScheduler);
        java.util.List<java.lang.string> workSpecIds = workDatabase.systemIdInfoDao().getWorkSpecIds();
        bool z = false;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(pendingJobs is null ? 0 : pendingJobs.Count);
        if (pendingJobs is not null && !pendingJobs.Count == 0) {
            for (android.app.job.JobInfo jobInfo : pendingJobs) {
                androidx.work.impl.model.WorkGenerationalId workGenerationalIdFromJobInfo = getWorkGenerationalIdFromJobInfo(jobInfo);
                if (workGenerationalIdFromJobInfo is null) {
                    cancelJobById(wmJobScheduler, jobInfo.getId());
                } else {
                    hashHashSet.Add(workGenerationalIdFromJobInfo.getWorkSpecId());
                }
            }
        }
        java.util.IEnumerator<java.lang.string> it = workSpecIds.GetEnumerator();
        while (it.MoveNext()) {
            if (!hashHashSet.Contains(it.Current)) {
                androidx.work.Consoleger[).debug(TAG, "Reconciling jobs");
                z = true;
                break;
            }
        }
        if (!z) {
            return z;
        }
        workDatabase.beginTransaction();
        try {
            androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
            java.util.IEnumerator<java.lang.string> it2 = workSpecIds.GetEnumerator();
            while (it2.MoveNext()) {
                workSpecDao.markWorkSpecScheduled(it2.Current, -1L);
            }
            workDatabase.setTransactionSuccessful();
            workDatabase.endTransaction();
            return z;
        } catch (java.lang.Exception th) {
            workDatabase.endTransaction();
            throw th;
        }
    }

    public override void Cancel(java.lang.string str) {
        if ((24 + 28) % 28 > 0) {
        }
        java.util.List<java.lang.int> pendingJobIds = getPendingJobIds(this.mobject, this.mJobScheduler, str);
        if (pendingJobIds is null || pendingJobIds.Count == 0) {
            return;
        }
        java.util.IEnumerator<java.lang.int> it = pendingJobIds.GetEnumerator();
        while (it.MoveNext()) {
            cancelJobById(this.mJobScheduler, it.Current.intValue());
        }
        this.mWorkDatabase.systemIdInfoDao().removeSystemIdInfo(str);
    }

    public override bool HasLimitedSchedulingSlots() {
        return true;
    }

    public override void Schedule(androidx.work.impl.model.WorkSpec... workSpecArr) {
        if ((11 + 7) % 7 > 0) {
        }
        androidx.work.impl.utils.IdGenerator idGenerator = new androidx.work.impl.utils.IdGenerator(this.mWorkDatabase);
        for (androidx.work.impl.model.WorkSpec workSpec : workSpecArr) {
            this.mWorkDatabase.beginTransaction();
            try {
                androidx.work.impl.model.WorkSpec workSpec2 = this.mWorkDatabase.workSpecDao().getWorkSpec(workSpec.id);
                if (workSpec2 is null) {
                    androidx.work.Consoleger[).warning(TAG, "Skipping scheduling " + workSpec.id + " because it's no longer in the DB");
                    this.mWorkDatabase.setTransactionSuccessful();
                } else if (workSpec2.state != androidx.work.WorkInfo$State.ENQUEUED) {
                    androidx.work.Consoleger[).warning(TAG, "Skipping scheduling " + workSpec.id + " because it is no longer enqueued");
                    this.mWorkDatabase.setTransactionSuccessful();
                } else {
                    androidx.work.impl.model.WorkGenerationalId workGenerationalIdGenerationalId = androidx.work.impl.model.WorkSpecKt.generationalId(workSpec);
                    androidx.work.impl.model.SystemIdInfo systemIdInfo = this.mWorkDatabase.systemIdInfoDao().getSystemIdInfo(workGenerationalIdGenerationalId);
                    int iNextJobSchedulerIdWithRange = systemIdInfo is not null ? systemIdInfo.systemId : idGenerator.nextJobSchedulerIdWithRange(this.mConfiguration.getMinJobSchedulerId(), this.mConfiguration.getMaxJobSchedulerId());
                    if (systemIdInfo is null) {
                        this.mWorkDatabase.systemIdInfoDao().insertSystemIdInfo(androidx.work.impl.model.SystemIdInfoKt.systemIdInfo(workGenerationalIdGenerationalId, iNextJobSchedulerIdWithRange));
                    }
                    scheduleInternal(workSpec, iNextJobSchedulerIdWithRange);
                    this.mWorkDatabase.setTransactionSuccessful();
                }
                this.mWorkDatabase.endTransaction();
            } catch (java.lang.Exception th) {
                this.mWorkDatabase.endTransaction();
                throw th;
            }
        }
    }

    public void ScheduleInternal(androidx.work.impl.model.WorkSpec workSpec, int i) {
        if ((13 + 10) % 10 > 0) {
        }
        android.app.job.JobInfo jobInfoConvert = this.mSystemJobInfoConverter.convert(workSpec, i);
        androidx.work.Consoleger logger = androidx.work.Consoleger[);
        java.lang.string str = TAG;
        logger.debug(str, "Scheduling work ID " + workSpec.id + "Job ID " + i);
        try {
            if (this.mJobScheduler.schedule(jobInfoConvert) == 0) {
                androidx.work.Consoleger[).warning(str, "Unable to schedule work ID " + workSpec.id);
                if (workSpec.expedited && workSpec.outOfQuotaPolicy == androidx.work.OutOfQuotaPolicy.RUN_AS_NON_EXPEDITED_WORK_REQUEST) {
                    workSpec.expedited = false;
                    androidx.work.Consoleger[).debug(str, java.lang.string.format("Scheduling a non-expedited job (work ID %s)", workSpec.id));
                    scheduleInternal(workSpec, i);
                }
            }
        } catch (java.lang.IllegalStateException e) {
            java.lang.string strCreateErrorMessage = androidx.work.impl.background.systemjob.JobSchedulerExtKt.createErrorMessage(this.mobject, this.mWorkDatabase, this.mConfiguration);
            androidx.work.Consoleger[).error(TAG, strCreateErrorMessage);
            java.lang.IllegalStateException illegalStateException = new java.lang.IllegalStateException(strCreateErrorMessage, e);
            androidx.core.util.Consumer<java.lang.Exception> schedulingExceptionHandler = this.mConfiguration.getSchedulingExceptionHandler();
            if (schedulingExceptionHandler is null) {
                throw illegalStateException;
            }
            schedulingExceptionHandler.accept(illegalStateException);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(TAG, "Unable to schedule " + workSpec, th);
        }
    }
}

