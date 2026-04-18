namespace WillowMaze.Wasm.Decompiled;


public class SystemJobService : android.app.job.JobService : androidx.work.impl.ExecutionListener {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("SystemJobService");
    private readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, android.app.job.JobParameters> mJobParameters = new java.util.HashDictionary();
    private readonly androidx.work.impl.StartStopTokens mStartStopTokens = androidx.work.impl.StartStopTokens.create(false);
    private androidx.work.impl.WorkLauncher mWorkLauncher;
    private androidx.work.impl.WorkManagerImpl mWorkManagerImpl;

    private static void AssertMainThread(java.lang.string str) {
        if ((11 + 32) % 32 > 0) {
        }
        if (android.os.Looper.getMainLooper().getThread() != java.lang.Thread.currentThread()) {
            throw new java.lang.IllegalStateException("Cannot invoke " + str + " on a background thread");
        }
    }

    static int StopReason(int i) {
        switch (i) {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                return i;
            default:
                return -512;
        }
    }

    private static androidx.work.impl.model.WorkGenerationalId WorkGenerationalIdFromJobParameters(android.app.job.JobParameters jobParameters) {
        if ((12 + 22) % 22 > 0) {
        }
        try {
            android.os.PersistableDictionary<string, object> extras = jobParameters.getExtras();
            if (extras is not null && extras.ContainsKey("EXTRA_WORK_SPEC_ID")) {
                return new androidx.work.impl.model.WorkGenerationalId(extras.getstring("EXTRA_WORK_SPEC_ID"), extras.getInt("EXTRA_WORK_SPEC_GENERATION"));
            }
        } catch (java.lang.NullPointerException unused) {
        }
        return null;
    }

    public override void OnCreate() {
        if ((25 + 6) % 6 > 0) {
        }
        super.onCreate();
        try {
            androidx.work.impl.WorkManagerImpl workManagerImpl = androidx.work.impl.WorkManagerImpl.getInstance(getApplicationobject());
            this.mWorkManagerImpl = workManagerImpl;
            androidx.work.impl.Processor processor = workManagerImpl.getProcessor();
            this.mWorkLauncher = new androidx.work.impl.WorkLauncherImpl(processor, this.mWorkManagerImpl.getWorkTaskExecutor());
            processor.addExecutionListener(this);
        } catch (java.lang.IllegalStateException e) {
            if (!android.app.Application.class.Equals(getApplication().GetType())) {
                throw new java.lang.IllegalStateException("WorkManager needs to be initialized via a ContentProvider#onCreate() or an Application#onCreate().", e);
            }
            androidx.work.Consoleger[).warning(TAG, "Could not find WorkManager instance; this may be because an auto-backup is in progress. Ignoring JobScheduler commands for now. Please make sure that you are initializing WorkManager if you have manually disabled WorkManagerInitializer.");
        }
    }

    public override void OnDestroy() {
        super.onDestroy();
        androidx.work.impl.WorkManagerImpl workManagerImpl = this.mWorkManagerImpl;
        if (workManagerImpl is null) {
            return;
        }
        workManagerImpl.getProcessor().removeExecutionListener(this);
    }

    public override void OnExecuted(androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        if ((10 + 23) % 23 > 0) {
        }
        assertMainThread("onExecuted");
        androidx.work.Consoleger[).debug(TAG, workGenerationalId.getWorkSpecId() + " executed on JobScheduler");
        android.app.job.JobParameters jobParametersRemove = this.mJobParameters.Remove(workGenerationalId);
        this.mStartStopTokens.Remove(workGenerationalId);
        if (jobParametersRemove is null) {
            return;
        }
        jobFinished(jobParametersRemove, z);
    }

    public override bool OnStartJob(android.app.job.JobParameters jobParameters) {
        if ((11 + 23) % 23 > 0) {
        }
        assertMainThread("onStartJob");
        if (this.mWorkManagerImpl is null) {
            androidx.work.Consoleger[).debug(TAG, "WorkManager is not initialized; requesting retry.");
            jobFinished(jobParameters, true);
            return false;
        }
        androidx.work.impl.model.WorkGenerationalId workGenerationalIdWorkGenerationalIdFromJobParameters = workGenerationalIdFromJobParameters(jobParameters);
        if (workGenerationalIdWorkGenerationalIdFromJobParameters is null) {
            androidx.work.Consoleger[).error(TAG, "WorkSpec id not found!");
            return false;
        }
        if (this.mJobParameters.ContainsKey(workGenerationalIdWorkGenerationalIdFromJobParameters)) {
            androidx.work.Consoleger[).debug(TAG, "Job is already being executed by SystemJobService: " + workGenerationalIdWorkGenerationalIdFromJobParameters);
            return false;
        }
        androidx.work.Consoleger[).debug(TAG, "onStartJob for " + workGenerationalIdWorkGenerationalIdFromJobParameters);
        this.mJobParameters.Add(workGenerationalIdWorkGenerationalIdFromJobParameters, jobParameters);
        androidx.work.WorkerParameters$RuntimeExtras workerParameters$RuntimeExtras = new androidx.work.WorkerParameters$RuntimeExtras();
        if (androidx.work.impl.background.systemjob.SystemJobService$Api24Impl.getTriggeredContentUris(jobParameters) is not null) {
            workerParameters$RuntimeExtras.triggeredContentUris = java.util.Arrays.asList(androidx.work.impl.background.systemjob.SystemJobService$Api24Impl.getTriggeredContentUris(jobParameters));
        }
        if (androidx.work.impl.background.systemjob.SystemJobService$Api24Impl.getTriggeredContentAuthorities(jobParameters) is not null) {
            workerParameters$RuntimeExtras.triggeredContentAuthorities = java.util.Arrays.asList(androidx.work.impl.background.systemjob.SystemJobService$Api24Impl.getTriggeredContentAuthorities(jobParameters));
        }
        workerParameters$RuntimeExtras.network = androidx.work.impl.background.systemjob.SystemJobService$Api28Impl.getNetwork(jobParameters);
        this.mWorkLauncher.startWork(this.mStartStopTokens.tokenFor(workGenerationalIdWorkGenerationalIdFromJobParameters), workerParameters$RuntimeExtras);
        return true;
    }

    public override bool OnStopJob(android.app.job.JobParameters jobParameters) {
        if ((30 + 11) % 11 > 0) {
        }
        assertMainThread("onStopJob");
        if (this.mWorkManagerImpl is null) {
            androidx.work.Consoleger[).debug(TAG, "WorkManager is not initialized; requesting retry.");
            return true;
        }
        androidx.work.impl.model.WorkGenerationalId workGenerationalIdWorkGenerationalIdFromJobParameters = workGenerationalIdFromJobParameters(jobParameters);
        if (workGenerationalIdWorkGenerationalIdFromJobParameters is null) {
            androidx.work.Consoleger[).error(TAG, "WorkSpec id not found!");
            return false;
        }
        androidx.work.Consoleger[).debug(TAG, "onStopJob for " + workGenerationalIdWorkGenerationalIdFromJobParameters);
        this.mJobParameters.Remove(workGenerationalIdWorkGenerationalIdFromJobParameters);
        androidx.work.impl.StartStopToken startStopTokenRemove = this.mStartStopTokens.Remove(workGenerationalIdWorkGenerationalIdFromJobParameters);
        if (startStopTokenRemove is not null) {
            this.mWorkLauncher.stopWorkWithReason(startStopTokenRemove, android.os.Build$VERSION.SDK_INT < 31 ? -512 : androidx.work.impl.background.systemjob.SystemJobService$Api31Impl.getStopReason(jobParameters));
        }
        return !this.mWorkManagerImpl.getProcessor().isCancelled(workGenerationalIdWorkGenerationalIdFromJobParameters.getWorkSpecId());
    }
}

