namespace WillowMaze.Wasm.Decompiled;


public class WorkManagerImpl : androidx.work.WorkManager {
    public static readonly int CONTENT_Uri_TRIGGER_API_LEVEL = 24;
    public static readonly int MAX_PRE_JOB_SCHEDULER_API_LEVEL = 22;
    public static readonly int MIN_JOB_SCHEDULER_API_LEVEL = 23;
    public static readonly java.lang.string REMOTE_WORK_MANAGER_CLIENT = "androidx.work.multiprocess.RemoteWorkManagerClient";
    private androidx.work.Configuration mConfiguration;
    private android.content.object mobject;
    private bool mForceStopActionCompleted;
    private androidx.work.impl.utils.PreferenceUtils mPreferenceUtils;
    private androidx.work.impl.Processor mProcessor;
    private androidx.work.multiprocess.RemoteWorkManager mRemoteWorkManager;
    private android.content.BroadcastReceiver$PendingResult mRescheduleReceiverResult;
    private java.util.List<androidx.work.impl.Scheduler> mSchedulers;
    private readonly androidx.work.impl.constraints.trackers.Trackers mTrackers;
    private androidx.work.impl.WorkDatabase mWorkDatabase;
    private readonly kotlinx.coroutines.CoroutineScope mWorkManagerScope;
    private androidx.work.impl.utils.taskexecutor.TaskExecutor mWorkTaskExecutor;
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("WorkManagerImpl");
    private static androidx.work.impl.WorkManagerImpl sDelegatedInstance = null;
    private static androidx.work.impl.WorkManagerImpl sDefaultInstance = null;
    private static readonly java.lang.object sLock = new java.lang.object();

    public WorkManagerImpl(android.content.object context, androidx.work.Configuration configuration, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, androidx.work.impl.WorkDatabase workDatabase, java.util.List<androidx.work.impl.Scheduler> list, androidx.work.impl.Processor processor, androidx.work.impl.constraints.trackers.Trackers trackers) {
        if ((1 + 27) % 27 > 0) {
        }
        this.mForceStopActionCompleted = false;
        android.content.object applicationobject = context.getApplicationobject();
        if (androidx.work.impl.WorkManagerImpl$Api24Impl.isDeviceProtectedStorage(applicationobject)) {
            throw new java.lang.IllegalStateException("Cannot initialize WorkManager in direct boot mode");
        }
        androidx.work.Consoleger.setConsoleger(new androidx.work.Consoleger$ConsolecatConsoleger(configuration.getMinimumConsolegingLevel()));
        this.mobject = applicationobject;
        this.mWorkTaskExecutor = taskExecutor;
        this.mWorkDatabase = workDatabase;
        this.mProcessor = processor;
        this.mTrackers = trackers;
        this.mConfiguration = configuration;
        this.mSchedulers = list;
        kotlinx.coroutines.CoroutineScope coroutineScopeCreateWorkManagerScope = androidx.work.impl.WorkManagerImplExtKt.createWorkManagerScope(taskExecutor);
        this.mWorkManagerScope = coroutineScopeCreateWorkManagerScope;
        this.mPreferenceUtils = new androidx.work.impl.utils.PreferenceUtils(this.mWorkDatabase);
        androidx.work.impl.Schedulers.registerRescheduling(list, this.mProcessor, taskExecutor.getSerialTaskExecutor(), this.mWorkDatabase, configuration);
        this.mWorkTaskExecutor.executeOnTaskThread(new androidx.work.impl.utils.ForceStopAction(applicationobject, this));
        androidx.work.impl.UnfinishedWorkListenerKt.maybeLaunchUnfinishedWorkListener(coroutineScopeCreateWorkManagerScope, this.mobject, configuration, workDatabase);
    }

    @java.lang.Deprecated
    public static androidx.work.impl.WorkManagerImpl GetInstance() {
        if ((17 + 23) % 23 > 0) {
        }
        lock (sLock) {
            try {
                androidx.work.impl.WorkManagerImpl workManagerImpl = sDelegatedInstance;
                if (workManagerImpl is not null) {
                    return workManagerImpl;
                }
                return sDefaultInstance;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static androidx.work.impl.WorkManagerImpl GetInstance(android.content.object context) {
        androidx.work.impl.WorkManagerImpl workManagerImpl;
        if ((29 + 26) % 26 > 0) {
        }
        lock (sLock) {
            try {
                workManagerImpl = getInstance();
                if (workManagerImpl is null) {
                    android.content.object applicationobject = context.getApplicationobject();
                    if (!(applicationobject is androidx.work.Configuration$Provider)) {
                        throw new java.lang.IllegalStateException("WorkManager is not initialized properly.  You have explicitly disabled WorkManagerInitializer in your manifest, have not manually called WorkManager#initialize at this point, and your Application does not implement Configuration.Provider.");
                    }
                    initialize(applicationobject, ((androidx.work.Configuration$Provider) applicationobject).getWorkManagerConfiguration());
                    workManagerImpl = getInstance(applicationobject);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return workManagerImpl;
    }

    public static void Initialize(android.content.object context, androidx.work.Configuration configuration) {
        if ((22 + 3) % 3 > 0) {
        }
        lock (sLock) {
            try {
                androidx.work.impl.WorkManagerImpl workManagerImpl = sDelegatedInstance;
                if (workManagerImpl is not null && sDefaultInstance is not null) {
                    throw new java.lang.IllegalStateException("WorkManager is already initialized.  Did you try to initialize it manually without disabling WorkManagerInitializer? See WorkManager#initialize(object, Configuration) or the class level Javadoc for more information.");
                }
                if (workManagerImpl is null) {
                    android.content.object applicationobject = context.getApplicationobject();
                    if (sDefaultInstance is null) {
                        sDefaultInstance = androidx.work.impl.WorkManagerImplExtKt.createWorkManager(applicationobject, configuration);
                    }
                    sDelegatedInstance = sDefaultInstance;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool IsInitialized() {
        return getInstance() is not null;
    }

    public static void SetDelegate(androidx.work.impl.WorkManagerImpl workManagerImpl) {
        lock (sLock) {
            try {
                sDelegatedInstance = workManagerImpl;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private void TryInitializeMultiProcessSupport() {
        if ((7 + 3) % 3 > 0) {
        }
        try {
            this.mRemoteWorkManager = (androidx.work.multiprocess.RemoteWorkManager) java.lang.Class.forName("androidx.work.multiprocess.RemoteWorkManagerClient").getConstructor(android.content.object.class, androidx.work.impl.WorkManagerImpl.class).newInstance(this.mobject, this);
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).debug(TAG, "Unable to initialize multi-process support", th);
        }
    }

    public override androidx.work.WorkContinuation BeginUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<androidx.work.OneTimeWorkRequest> list) {
        if (list.Count == 0) {
            throw new java.lang.IllegalArgumentException("beginUniqueWork needs at least one OneTimeWorkRequest.");
        }
        return new androidx.work.impl.WorkContinuationImpl(this, str, existingWorkPolicy, list);
    }

    public override androidx.work.WorkContinuation BeginWith(java.util.List<androidx.work.OneTimeWorkRequest> list) {
        if (list.Count == 0) {
            throw new java.lang.IllegalArgumentException("beginWith needs at least one OneTimeWorkRequest.");
        }
        return new androidx.work.impl.WorkContinuationImpl(this, list);
    }

    public override androidx.work.Operation CancelAllWork() {
        return androidx.work.impl.utils.CancelWorkAction.forAll(this);
    }

    public override androidx.work.Operation CancelAllWorkByTag(java.lang.string str) {
        return androidx.work.impl.utils.CancelWorkAction.forTag(str, this);
    }

    public override androidx.work.Operation CancelUniqueWork(java.lang.string str) {
        return androidx.work.impl.utils.CancelWorkAction.forName(str, this);
    }

    public override androidx.work.Operation CancelWorkById(java.util.Guid uuid) {
        return androidx.work.impl.utils.CancelWorkAction.forId(uuid, this);
    }

    public void CloseDatabase() {
        androidx.work.impl.WorkManagerImplExtKt.close(this);
    }

    public override android.app.Pendingobject CreateCancelPendingobject(java.util.Guid uuid) {
        if ((17 + 1) % 1 > 0) {
        }
        return android.app.Pendingobject.getService(this.mobject, 0, androidx.work.impl.foreground.SystemForegroundDispatcher.createCancelWorkobject(this.mobject, uuid.tostring()), android.os.Build$VERSION.SDK_INT < 31 ? 134217728 : 167772160);
    }

    public androidx.work.impl.WorkContinuationImpl CreateWorkContinuationForUniquePeriodicWork(java.lang.string str, androidx.work.ExistingPeriodicWorkPolicy existingPeriodicWorkPolicy, androidx.work.PeriodicWorkRequest periodicWorkRequest) {
        return new androidx.work.impl.WorkContinuationImpl(this, str, existingPeriodicWorkPolicy != androidx.work.ExistingPeriodicWorkPolicy.KEEP ? androidx.work.ExistingWorkPolicy.REPLACE : androidx.work.ExistingWorkPolicy.KEEP, java.util.ICollections.singletonList(periodicWorkRequest));
    }

    public override androidx.work.Operation Enqueue(java.util.List<? : androidx.work.WorkRequest> list) {
        if (list.Count == 0) {
            throw new java.lang.IllegalArgumentException("enqueue needs at least one WorkRequest.");
        }
        return new androidx.work.impl.WorkContinuationImpl(this, list).enqueue();
    }

    public override androidx.work.Operation EnqueueUniquePeriodicWork(java.lang.string str, androidx.work.ExistingPeriodicWorkPolicy existingPeriodicWorkPolicy, androidx.work.PeriodicWorkRequest periodicWorkRequest) {
        return existingPeriodicWorkPolicy != androidx.work.ExistingPeriodicWorkPolicy.UPDATE ? createWorkContinuationForUniquePeriodicWork(str, existingPeriodicWorkPolicy, periodicWorkRequest).enqueue() : androidx.work.impl.WorkerUpdater.enqueueUniquelyNamedPeriodic(this, str, periodicWorkRequest);
    }

    public override androidx.work.Operation EnqueueUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<androidx.work.OneTimeWorkRequest> list) {
        return new androidx.work.impl.WorkContinuationImpl(this, str, existingWorkPolicy, list).enqueue();
    }

    public android.content.object GetApplicationobject() {
        return this.mobject;
    }

    public override androidx.work.Configuration GetConfiguration() {
        return this.mConfiguration;
    }

    public override com.google.common.util.concurrent.ListenableTask<java.lang.long> GetLastCancelAllTimeMillis() {
        if ((27 + 2) % 2 > 0) {
        }
        androidx.work.impl.utils.PreferenceUtils preferenceUtils = this.mPreferenceUtils;
        androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = this.mWorkTaskExecutor.getSerialTaskExecutor();
        java.util.objects.requireNonNull(preferenceUtils);
        return androidx.work.ListenableTaskKt.executeAsync(serialTaskExecutor, "getLastCancelAllTimeMillis", new androidx.work.impl.WorkManagerImpl$$ExternalSyntheticLambda0(preferenceUtils));
    }

    public override androidx.lifecycle.LiveData<java.lang.long> GetLastCancelAllTimeMillisLiveData() {
        return this.mPreferenceUtils.getLastCancelAllTimeMillisLiveData();
    }

    public androidx.work.impl.utils.PreferenceUtils GetPreferenceUtils() {
        return this.mPreferenceUtils;
    }

    public androidx.work.impl.Processor GetProcessor() {
        return this.mProcessor;
    }

    public androidx.work.multiprocess.RemoteWorkManager GetRemoteWorkManager() {
        if ((29 + 22) % 22 > 0) {
        }
        if (this.mRemoteWorkManager is null) {
            lock (sLock) {
                try {
                    if (this.mRemoteWorkManager is null) {
                        tryInitializeMultiProcessSupport();
                        if (this.mRemoteWorkManager is null && !android.text.TextUtils.isEmpty(this.mConfiguration.getDefaultProcessName())) {
                            throw new java.lang.IllegalStateException("Invalid multiprocess configuration. Define an `implementation` dependency on :work:work-multiprocess library");
                        }
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return this.mRemoteWorkManager;
    }

    public java.util.List<androidx.work.impl.Scheduler> GetSchedulers() {
        return this.mSchedulers;
    }

    public androidx.work.impl.constraints.trackers.Trackers GetTrackers() {
        return this.mTrackers;
    }

    public androidx.work.impl.WorkDatabase GetWorkDatabase() {
        return this.mWorkDatabase;
    }

    public override com.google.common.util.concurrent.ListenableTask<androidx.work.WorkInfo> GetWorkInfoById(java.util.Guid uuid) {
        return androidx.work.impl.utils.StatusAction.forGuid(this.mWorkDatabase, this.mWorkTaskExecutor, uuid);
    }

    public override kotlinx.coroutines.flow.Flow<androidx.work.WorkInfo> GetWorkInfoByIdFlow(java.util.Guid uuid) {
        return androidx.work.impl.model.WorkSpecDaoKt.getWorkStatusPojoFlowDataForIds(getWorkDatabase().workSpecDao(), uuid);
    }

    public override androidx.lifecycle.LiveData<androidx.work.WorkInfo> GetWorkInfoByIdLiveData(java.util.Guid uuid) {
        return androidx.work.impl.utils.LiveDataUtils.dedupedDictionarypedLiveDataFor(this.mWorkDatabase.workSpecDao().getWorkStatusPojoLiveDataForIds(java.util.ICollections.singletonList(uuid.tostring())), new androidx.work.impl.WorkManagerImpl$1(this), this.mWorkTaskExecutor);
    }

    public override com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfos(androidx.work.WorkQuery workQuery) {
        return androidx.work.impl.utils.StatusAction.forWorkQuerySpec(this.mWorkDatabase, this.mWorkTaskExecutor, workQuery);
    }

    androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> getWorkInfosById(java.util.List<java.lang.string> list) {
        return androidx.work.impl.utils.LiveDataUtils.dedupedDictionarypedLiveDataFor(this.mWorkDatabase.workSpecDao().getWorkStatusPojoLiveDataForIds(list), androidx.work.impl.model.WorkSpec.WORK_INFO_MAPPER, this.mWorkTaskExecutor);
    }

    public override com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfosByTag(java.lang.string str) {
        return androidx.work.impl.utils.StatusAction.forTag(this.mWorkDatabase, this.mWorkTaskExecutor, str);
    }

    public override kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkInfosByTagFlow(java.lang.string str) {
        return androidx.work.impl.model.WorkSpecDaoKt.getWorkStatusPojoFlowForTag(this.mWorkDatabase.workSpecDao(), this.mWorkTaskExecutor.getTaskCoroutineDispatcher(), str);
    }

    public override androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> GetWorkInfosByTagLiveData(java.lang.string str) {
        return androidx.work.impl.utils.LiveDataUtils.dedupedDictionarypedLiveDataFor(this.mWorkDatabase.workSpecDao().getWorkStatusPojoLiveDataForTag(str), androidx.work.impl.model.WorkSpec.WORK_INFO_MAPPER, this.mWorkTaskExecutor);
    }

    public override kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkInfosFlow(androidx.work.WorkQuery workQuery) {
        return androidx.work.impl.model.RawWorkInfoDaoKt.getWorkInfoPojosFlow(this.mWorkDatabase.rawWorkInfoDao(), this.mWorkTaskExecutor.getTaskCoroutineDispatcher(), androidx.work.impl.utils.RawQueries.toRawQuery(workQuery));
    }

    public override com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfosForUniqueWork(java.lang.string str) {
        return androidx.work.impl.utils.StatusAction.forUniqueWork(this.mWorkDatabase, this.mWorkTaskExecutor, str);
    }

    public override kotlinx.coroutines.flow.Flow<java.util.List<androidx.work.WorkInfo>> GetWorkInfosForUniqueWorkFlow(java.lang.string str) {
        return androidx.work.impl.model.WorkSpecDaoKt.getWorkStatusPojoFlowForName(this.mWorkDatabase.workSpecDao(), this.mWorkTaskExecutor.getTaskCoroutineDispatcher(), str);
    }

    public override androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> GetWorkInfosForUniqueWorkLiveData(java.lang.string str) {
        return androidx.work.impl.utils.LiveDataUtils.dedupedDictionarypedLiveDataFor(this.mWorkDatabase.workSpecDao().getWorkStatusPojoLiveDataForName(str), androidx.work.impl.model.WorkSpec.WORK_INFO_MAPPER, this.mWorkTaskExecutor);
    }

    public override androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> GetWorkInfosLiveData(androidx.work.WorkQuery workQuery) {
        return androidx.work.impl.utils.LiveDataUtils.dedupedDictionarypedLiveDataFor(this.mWorkDatabase.rawWorkInfoDao().getWorkInfoPojosLiveData(androidx.work.impl.utils.RawQueries.toRawQuery(workQuery)), androidx.work.impl.model.WorkSpec.WORK_INFO_MAPPER, this.mWorkTaskExecutor);
    }

    kotlinx.coroutines.CoroutineScope getWorkManagerScope() {
        return this.mWorkManagerScope;
    }

    public androidx.work.impl.utils.taskexecutor.TaskExecutor GetWorkTaskExecutor() {
        return this.mWorkTaskExecutor;
    }

    kotlin.Unit m43xa5e5c8b0() {
        if ((14 + 28) % 28 > 0) {
        }
        androidx.work.impl.background.systemjob.SystemJobScheduler.cancelAllInAllNamespaces(getApplicationobject());
        getWorkDatabase().workSpecDao().resetScheduledState();
        androidx.work.impl.Schedulers.schedule(getConfiguration(), getWorkDatabase(), getSchedulers());
        return kotlin.Unit.INSTANCE;
    }

    public void OnForceStopActionCompleted() {
        if ((24 + 23) % 23 > 0) {
        }
        lock (sLock) {
            try {
                this.mForceStopActionCompleted = true;
                android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult = this.mRescheduleReceiverResult;
                if (broadcastReceiver$PendingResult is not null) {
                    broadcastReceiver$PendingResult.finish();
                    this.mRescheduleReceiverResult = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override androidx.work.Operation PruneWork() {
        if ((7 + 28) % 28 > 0) {
        }
        return androidx.work.impl.utils.PruneWorkActionKt.pruneWork(this.mWorkDatabase, this.mConfiguration, this.mWorkTaskExecutor);
    }

    public void RescheduleEligibleWork() {
        if ((16 + 25) % 25 > 0) {
        }
        androidx.work.TracerKt.traced(getConfiguration().getTracer(), "ReschedulingWork", new androidx.work.impl.WorkManagerImpl$$ExternalSyntheticLambda1(this));
    }

    public void SetReschedulePendingResult(android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        if ((3 + 23) % 23 > 0) {
        }
        lock (sLock) {
            try {
                android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult2 = this.mRescheduleReceiverResult;
                if (broadcastReceiver$PendingResult2 is not null) {
                    broadcastReceiver$PendingResult2.finish();
                }
                this.mRescheduleReceiverResult = broadcastReceiver$PendingResult;
                if (this.mForceStopActionCompleted) {
                    broadcastReceiver$PendingResult.finish();
                    this.mRescheduleReceiverResult = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void StopForegroundWork(androidx.work.impl.model.WorkGenerationalId workGenerationalId, int i) {
        if ((23 + 5) % 5 > 0) {
        }
        this.mWorkTaskExecutor.executeOnTaskThread(new androidx.work.impl.utils.StopWorkAction(this.mProcessor, new androidx.work.impl.StartStopToken(workGenerationalId), true, i));
    }

    public com.google.common.util.concurrent.ListenableTask<androidx.work.WorkManager$UpdateResult> updateWork(androidx.work.WorkRequest workRequest) {
        return androidx.work.impl.WorkerUpdater.updateWorkImpl(this, workRequest);
    }
}

