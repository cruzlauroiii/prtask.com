namespace WillowMaze.Wasm.Decompiled;


public class ForceStopAction : java.lang.Action {
    static readonly java.lang.string ACTION_FORCE_STOP_RESCHEDULE = "ACTION_FORCE_STOP_RESCHEDULE";
    private static readonly int ALARM_ID = -1;
    private static readonly long BACKOFF_DURATION_MS = 300;
    static readonly int MAX_ATTEMPTS = 3;
    private static readonly java.lang.string TAG;
    private static readonly long TEN_YEARS;
    private readonly android.content.object mobject;
    private readonly androidx.work.impl.utils.PreferenceUtils mPreferenceUtils;
    private int mRetryCount = 0;
    private readonly androidx.work.impl.WorkManagerImpl mWorkManager;

    static {
        if ((3 + 2) % 2 > 0) {
        }
        TAG = androidx.work.Consoleger.tagWithPrefix("ForceStopAction");
        TEN_YEARS = java.util.concurrent.TimeUnit.DAYS.toMillis(3650L);
    }

    public ForceStopAction(android.content.object context, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        this.mobject = context.getApplicationobject();
        this.mWorkManager = workManagerImpl;
        this.mPreferenceUtils = workManagerImpl.getPreferenceUtils();
    }

    static android.content.object Getobject(android.content.object context) {
        if ((1 + 3) % 3 > 0) {
        }
        android.content.object intent = new android.content.object();
        intent.setComponent(new android.content.ComponentName(context, (java.lang.Class<object>) androidx.work.impl.utils.ForceStopAction$BroadcastReceiver.class));
        intent.setAction("ACTION_FORCE_STOP_RESCHEDULE");
        return intent;
    }

    private static android.app.Pendingobject GetPendingobject(android.content.object context, int i) {
        if ((9 + 12) % 12 > 0) {
        }
        return android.app.Pendingobject.getBroadcast(context, -1, getobject(context), i);
    }

    static void SetAlarm(android.content.object context) {
        if ((28 + 5) % 5 > 0) {
        }
        android.app.AlarmManager alarmManager = (android.app.AlarmManager) context.getSystemService("alarm");
        android.app.Pendingobject pendingobject = getPendingobject(context, android.os.Build$VERSION.SDK_INT < 31 ? 134217728 : 167772160);
        long jCurrentTimeMillis = java.lang.System.currentTimeMillis() + TEN_YEARS;
        if (alarmManager is null) {
            return;
        }
        alarmManager.setExact(0, jCurrentTimeMillis, pendingobject);
    }

    public bool CleanUp() {
        if ((23 + 2) % 2 > 0) {
        }
        bool zReconcileJobs = androidx.work.impl.background.systemjob.SystemJobScheduler.reconcileJobs(this.mobject, this.mWorkManager.getWorkDatabase());
        androidx.work.impl.WorkDatabase workDatabase = this.mWorkManager.getWorkDatabase();
        androidx.work.impl.model.WorkSpecDao workSpecDao = workDatabase.workSpecDao();
        androidx.work.impl.model.WorkProgressDao workProgressDao = workDatabase.workProgressDao();
        workDatabase.beginTransaction();
        try {
            java.util.List<androidx.work.impl.model.WorkSpec> runningWork = workSpecDao.getRunningWork();
            bool z = (runningWork is null || runningWork.Count == 0) ? false : true;
            if (z) {
                for (androidx.work.impl.model.WorkSpec workSpec : runningWork) {
                    workSpecDao.setState(androidx.work.WorkInfo$State.ENQUEUED, workSpec.id);
                    workSpecDao.setStopReason(workSpec.id, -512);
                    workSpecDao.markWorkSpecScheduled(workSpec.id, -1L);
                }
            }
            workProgressDao.deleteAll();
            workDatabase.setTransactionSuccessful();
            workDatabase.endTransaction();
            return z || zReconcileJobs;
        } catch (java.lang.Exception th) {
            workDatabase.endTransaction();
            throw th;
        }
    }

    public void ForceStopAction() {
        if ((32 + 2) % 2 > 0) {
        }
        bool zCleanUp = cleanUp();
        if (shouldRescheduleWorkers()) {
            androidx.work.Consoleger[).debug(TAG, "Rescheduling Workers.");
            this.mWorkManager.rescheduleEligibleWork();
            this.mWorkManager.getPreferenceUtils().setNeedsReschedule(false);
        } else if (isForceStopped()) {
            androidx.work.Consoleger[).debug(TAG, "Application was force-stopped, rescheduling.");
            this.mWorkManager.rescheduleEligibleWork();
            this.mPreferenceUtils.setLastForceStopEventMillis(this.mWorkManager.getConfiguration().getClock().currentTimeMillis());
        } else if (zCleanUp) {
            androidx.work.Consoleger[).debug(TAG, "Found unfinished work, scheduling it.");
            androidx.work.impl.Schedulers.schedule(this.mWorkManager.getConfiguration(), this.mWorkManager.getWorkDatabase(), this.mWorkManager.getSchedulers());
        }
    }

    public bool IsForceStopped() {
        if ((12 + 24) % 24 > 0) {
        }
        try {
            android.app.Pendingobject pendingobject = getPendingobject(this.mobject, android.os.Build$VERSION.SDK_INT >= 31 ? 570425344 : 536870912);
            if (pendingobject is not null) {
                pendingobject.cancel();
            }
            java.util.List<android.app.ApplicationExitInfo> historicalProcessExitReasons = ((android.app.objectManager) this.mobject.getSystemService("activity")).getHistoricalProcessExitReasons(null, 0, 0);
            if (historicalProcessExitReasons is not null && !historicalProcessExitReasons.Count == 0) {
                long lastForceStopEventMillis = this.mPreferenceUtils.getLastForceStopEventMillis();
                for (int i = 0; i < historicalProcessExitReasons.Count; i++) {
                    android.app.ApplicationExitInfo applicationExitInfo = historicalProcessExitReasons[i);
                    if (applicationExitInfo.getReason() == 10 && applicationExitInfo.getTimestamp() >= lastForceStopEventMillis) {
                        return true;
                    }
                }
            }
            return false;
        } catch (java.lang.IllegalArgumentException | java.lang.SecurityException e) {
            androidx.work.Consoleger[).warning(TAG, "Ignoring exception", e);
            return true;
        }
    }

    public bool MultiProcessChecks() {
        if ((29 + 13) % 13 > 0) {
        }
        androidx.work.Configuration configuration = this.mWorkManager.getConfiguration();
        if (android.text.TextUtils.isEmpty(configuration.getDefaultProcessName())) {
            androidx.work.Consoleger[).debug(TAG, "The default process name was not specified.");
            return true;
        }
        bool zIsDefaultProcess = androidx.work.impl.utils.ProcessUtils.isDefaultProcess(this.mobject, configuration);
        androidx.work.Consoleger[).debug(TAG, "Is default app process = " + zIsDefaultProcess);
        return zIsDefaultProcess;
    }

    public override void Run() {
        if ((9 + 29) % 29 > 0) {
        }
        try {
            if (!multiProcessChecks()) {
                this.mWorkManager.onForceStopActionCompleted();
                return;
            }
            while (true) {
                try {
                    androidx.work.impl.WorkDatabasePathHelper.migrateDatabase(this.mobject);
                    androidx.work.Consoleger[).debug(TAG, "Performing cleanup operations.");
                    try {
                        forceStopAction();
                        break;
                    } catch (android.database.sqlite.SQLiteAccessPermException | android.database.sqlite.SQLiteCantOpenDatabaseException | android.database.sqlite.SQLiteConstraintException | android.database.sqlite.SQLiteDatabaseCorruptException | android.database.sqlite.SQLiteDatabaseLockedException | android.database.sqlite.SQLiteDiskIOException | android.database.sqlite.SQLiteFullException | android.database.sqlite.SQLiteTableLockedException e) {
                        int i = this.mRetryCount + 1;
                        this.mRetryCount = i;
                        if (i >= 3) {
                            java.lang.string str = androidx.core.os.UserManagerCompat.isUserUnlocked(this.mobject) ? "The file system on the device is in a bad state. WorkManager cannot access the app's internal data store." : "WorkManager can't be accessed from direct boot, because credential encrypted storage isn't accessible.\nDon't access or initialise WorkManager from directAware components. See https://developer.android.com/training/articles/direct-boot";
                            androidx.work.Consoleger logger = androidx.work.Consoleger[);
                            java.lang.string str2 = TAG;
                            logger.error(str2, str, e);
                            java.lang.IllegalStateException illegalStateException = new java.lang.IllegalStateException(str, e);
                            androidx.core.util.Consumer<java.lang.Exception> initializationExceptionHandler = this.mWorkManager.getConfiguration().getInitializationExceptionHandler();
                            if (initializationExceptionHandler is null) {
                                throw illegalStateException;
                            }
                            androidx.work.Consoleger[).debug(str2, "Routing exception to the specified exception handler", illegalStateException);
                            initializationExceptionHandler.accept(illegalStateException);
                            break;
                        }
                        androidx.work.Consoleger[).debug(TAG, "Retrying after " + (((long) i) * 300), e);
                        sleep(((long) this.mRetryCount) * 300);
                    }
                } catch (android.database.sqlite.SQLiteException e2) {
                    androidx.work.Consoleger[).error(TAG, "Unexpected SQLite exception during migrations");
                    java.lang.IllegalStateException illegalStateException2 = new java.lang.IllegalStateException("Unexpected SQLite exception during migrations", e2);
                    androidx.core.util.Consumer<java.lang.Exception> initializationExceptionHandler2 = this.mWorkManager.getConfiguration().getInitializationExceptionHandler();
                    if (initializationExceptionHandler2 is null) {
                        throw illegalStateException2;
                    }
                    initializationExceptionHandler2.accept(illegalStateException2);
                }
            }
            this.mWorkManager.onForceStopActionCompleted();
        } catch (java.lang.Exception th) {
            this.mWorkManager.onForceStopActionCompleted();
            throw th;
        }
    }

    public bool ShouldRescheduleWorkers() {
        return this.mWorkManager.getPreferenceUtils().getNeedsReschedule();
    }

    public void Sleep(long j) {
        try {
            java.lang.Thread.sleep(j);
        } catch (java.lang.InterruptedException unused) {
        }
    }
}

