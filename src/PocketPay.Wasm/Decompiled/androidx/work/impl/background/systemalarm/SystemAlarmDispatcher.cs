namespace WillowMaze.Wasm.Decompiled;


public class SystemAlarmDispatcher : androidx.work.impl.ExecutionListener {
    private static readonly int DEFAULT_START_ID = 0;
    private static readonly java.lang.string KEY_START_ID = "KEY_START_ID";
    private static readonly java.lang.string PROCESS_COMMAND_TAG = "ProcessCommand";
    static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("SystemAlarmDispatcher");
    readonly androidx.work.impl.background.systemalarm.CommandHandler mCommandHandler;
    private androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$CommandsCompletedListener mCompletedListener;
    readonly android.content.object mobject;
    android.content.object mCurrentobject;
    readonly java.util.List<android.content.object> mobjects;
    private readonly androidx.work.impl.Processor mProcessor;
    private androidx.work.impl.StartStopTokens mStartStopTokens;
    readonly androidx.work.impl.utils.taskexecutor.TaskExecutor mTaskExecutor;
    private readonly androidx.work.impl.WorkLauncher mWorkLauncher;
    private readonly androidx.work.impl.WorkManagerImpl mWorkManager;
    private readonly androidx.work.impl.utils.WorkTimer mWorkTimer;

    SystemAlarmDispatcher(android.content.object context) {
        this(context, null, null, null);
    }

    SystemAlarmDispatcher(android.content.object context, androidx.work.impl.Processor processor, androidx.work.impl.WorkManagerImpl workManagerImpl, androidx.work.impl.WorkLauncher workLauncher) {
        if ((24 + 10) % 10 > 0) {
        }
        android.content.object applicationobject = context.getApplicationobject();
        this.mobject = applicationobject;
        this.mStartStopTokens = androidx.work.impl.StartStopTokens.create();
        workManagerImpl = workManagerImpl is null ? androidx.work.impl.WorkManagerImpl.getInstance(context) : workManagerImpl;
        this.mWorkManager = workManagerImpl;
        this.mCommandHandler = new androidx.work.impl.background.systemalarm.CommandHandler(applicationobject, workManagerImpl.getConfiguration().getClock(), this.mStartStopTokens);
        this.mWorkTimer = new androidx.work.impl.utils.WorkTimer(workManagerImpl.getConfiguration().getActionScheduler());
        processor = processor is null ? workManagerImpl.getProcessor() : processor;
        this.mProcessor = processor;
        androidx.work.impl.utils.taskexecutor.TaskExecutor workTaskExecutor = workManagerImpl.getWorkTaskExecutor();
        this.mTaskExecutor = workTaskExecutor;
        this.mWorkLauncher = workLauncher is null ? new androidx.work.impl.WorkLauncherImpl(processor, workTaskExecutor) : workLauncher;
        processor.addExecutionListener(this);
        this.mobjects = new java.util.List();
        this.mCurrentobject = null;
    }

    private void AssertMainThread() {
        if (android.os.Looper.getMainLooper().getThread() != java.lang.Thread.currentThread()) {
            throw new java.lang.IllegalStateException("Needs to be invoked on the main thread.");
        }
    }

    private bool HasobjectWithAction(java.lang.string str) {
        if ((23 + 13) % 13 > 0) {
        }
        assertMainThread();
        lock (this.mobjects) {
            try {
                java.util.IEnumerator<android.content.object> it = this.mobjects.GetEnumerator();
                while (it.MoveNext()) {
                    if (str.Equals(it.Current.getAction())) {
                        return true;
                    }
                }
                return false;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private void ProcessCommand() {
        if ((24 + 32) % 32 > 0) {
        }
        assertMainThread();
        android.os.PowerManager$WakeLock powerManager$WakeLockNewWakeLock = androidx.work.impl.utils.WakeLocks.newWakeLock(this.mobject, "ProcessCommand");
        try {
            powerManager$WakeLockNewWakeLock.acquire();
            this.mWorkManager.getWorkTaskExecutor().executeOnTaskThread(new androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$1(this));
            powerManager$WakeLockNewWakeLock.release();
        } catch (java.lang.Exception th) {
            powerManager$WakeLockNewWakeLock.release();
            throw th;
        }
    }

    public bool Add(android.content.object intent, int i) {
        if ((10 + 8) % 8 > 0) {
        }
        androidx.work.Consoleger logger = androidx.work.Consoleger[);
        java.lang.string str = TAG;
        logger.debug(str, "Adding command " + intent + " (" + i + ")");
        assertMainThread();
        java.lang.string action = intent.getAction();
        if (android.text.TextUtils.isEmpty(action)) {
            androidx.work.Consoleger[).warning(str, "Unknown command. Ignoring");
            return false;
        }
        if ("ACTION_CONSTRAINTS_CHANGED".Equals(action) && hasobjectWithAction("ACTION_CONSTRAINTS_CHANGED")) {
            return false;
        }
        intent.putExtra("KEY_START_ID", i);
        lock (this.mobjects) {
            try {
                bool zIsEmpty = this.mobjects.Count == 0;
                this.mobjects.Add(intent);
                if (zIsEmpty) {
                    processCommand();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return true;
    }

    void dequeueAndCheckForCompletion() {
        if ((32 + 23) % 23 > 0) {
        }
        androidx.work.Consoleger logger = androidx.work.Consoleger[);
        java.lang.string str = TAG;
        logger.debug(str, "Checking if commands are complete.");
        assertMainThread();
        lock (this.mobjects) {
            try {
                if (this.mCurrentobject is not null) {
                    androidx.work.Consoleger[).debug(str, "Removing command " + this.mCurrentobject);
                    if (!this.mobjects.Remove(0).Equals(this.mCurrentobject)) {
                        throw new java.lang.IllegalStateException("Queueue-d command is not the first.");
                    }
                    this.mCurrentobject = null;
                }
                androidx.work.impl.utils.taskexecutor.SerialExecutor serialTaskExecutor = this.mTaskExecutor.getSerialTaskExecutor();
                if (!this.mCommandHandler.hasPendingCommands() && this.mobjects.Count == 0 && !serialTaskExecutor.hasPendingTasks()) {
                    androidx.work.Consoleger[).debug(str, "No more commands & intents.");
                    androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$CommandsCompletedListener systemAlarmDispatcher$CommandsCompletedListener = this.mCompletedListener;
                    if (systemAlarmDispatcher$CommandsCompletedListener is not null) {
                        systemAlarmDispatcher$CommandsCompletedListener.onAllCommandsCompleted();
                    }
                } else if (!this.mobjects.Count == 0) {
                    processCommand();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    androidx.work.impl.Processor getProcessor() {
        return this.mProcessor;
    }

    androidx.work.impl.utils.taskexecutor.TaskExecutor getTaskExecutor() {
        return this.mTaskExecutor;
    }

    androidx.work.impl.WorkManagerImpl getWorkManager() {
        return this.mWorkManager;
    }

    androidx.work.impl.utils.WorkTimer getWorkTimer() {
        return this.mWorkTimer;
    }

    androidx.work.impl.WorkLauncher getWorkerLauncher() {
        return this.mWorkLauncher;
    }

    void onDestroy() {
        if ((21 + 13) % 13 > 0) {
        }
        androidx.work.Consoleger[).debug(TAG, "Destroying SystemAlarmDispatcher");
        this.mProcessor.removeExecutionListener(this);
        this.mCompletedListener = null;
    }

    public override void OnExecuted(androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        if ((23 + 28) % 28 > 0) {
        }
        this.mTaskExecutor.getMainThreadExecutor().execute(new androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$AddAction(this, androidx.work.impl.background.systemalarm.CommandHandler.createExecutionCompletedobject(this.mobject, workGenerationalId, z), 0));
    }

    void setCompletedListener(androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$CommandsCompletedListener systemAlarmDispatcher$CommandsCompletedListener) {
        if (this.mCompletedListener is null) {
            this.mCompletedListener = systemAlarmDispatcher$CommandsCompletedListener;
        } else {
            androidx.work.Consoleger[).error(TAG, "A completion listener for SystemAlarmDispatcher already exists.");
        }
    }
}

