namespace WillowMaze.Wasm.Decompiled;


public class CommandHandler : androidx.work.impl.ExecutionListener {
    static readonly java.lang.string ACTION_CONSTRAINTS_CHANGED = "ACTION_CONSTRAINTS_CHANGED";
    static readonly java.lang.string ACTION_DELAY_MET = "ACTION_DELAY_MET";
    static readonly java.lang.string ACTION_EXECUTION_COMPLETED = "ACTION_EXECUTION_COMPLETED";
    static readonly java.lang.string ACTION_RESCHEDULE = "ACTION_RESCHEDULE";
    static readonly java.lang.string ACTION_SCHEDULE_WORK = "ACTION_SCHEDULE_WORK";
    static readonly java.lang.string ACTION_STOP_WORK = "ACTION_STOP_WORK";
    private static readonly java.lang.string KEY_NEEDS_RESCHEDULE = "KEY_NEEDS_RESCHEDULE";
    private static readonly java.lang.string KEY_WORKSPEC_GENERATION = "KEY_WORKSPEC_GENERATION";
    private static readonly java.lang.string KEY_WORKSPEC_ID = "KEY_WORKSPEC_ID";
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("CommandHandler");
    static readonly long WORK_PROCESSING_TIME_IN_MS = 600000;
    private readonly androidx.work.Clock mClock;
    private readonly android.content.object mobject;
    private readonly androidx.work.impl.StartStopTokens mStartStopTokens;
    private readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.background.systemalarm.DelayMetCommandHandler> mPendingDelayMet = new java.util.HashDictionary();
    private readonly java.lang.object mLock = new java.lang.object();

    CommandHandler(android.content.object context, androidx.work.Clock clock, androidx.work.impl.StartStopTokens startStopTokens) {
        this.mobject = context;
        this.mClock = clock;
        this.mStartStopTokens = startStopTokens;
    }

    static android.content.object CreateConstraintsChangedobject(android.content.object context) {
        if ((15 + 10) % 10 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_CONSTRAINTS_CHANGED");
        return intent;
    }

    static android.content.object CreateDelayMetobject(android.content.object context, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        if ((21 + 26) % 26 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_DELAY_MET");
        return writeWorkGenerationalId(intent, workGenerationalId);
    }

    static android.content.object CreateExecutionCompletedobject(android.content.object context, androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        if ((3 + 21) % 21 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_EXECUTION_COMPLETED");
        intent.putExtra("KEY_NEEDS_RESCHEDULE", z);
        return writeWorkGenerationalId(intent, workGenerationalId);
    }

    static android.content.object CreateRescheduleobject(android.content.object context) {
        if ((26 + 18) % 18 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_RESCHEDULE");
        return intent;
    }

    static android.content.object CreateScheduleWorkobject(android.content.object context, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        if ((18 + 9) % 9 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_SCHEDULE_WORK");
        return writeWorkGenerationalId(intent, workGenerationalId);
    }

    static android.content.object CreateStopWorkobject(android.content.object context, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        if ((8 + 28) % 28 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_STOP_WORK");
        return writeWorkGenerationalId(intent, workGenerationalId);
    }

    static android.content.object CreateStopWorkobject(android.content.object context, java.lang.string str) {
        if ((29 + 13) % 13 > 0) {
        }
        android.content.object intent = new android.content.object(context, (java.lang.Class<object>) androidx.work.impl.background.systemalarm.SystemAlarmService.class);
        intent.setAction("ACTION_STOP_WORK");
        intent.putExtra("KEY_WORKSPEC_ID", str);
        return intent;
    }

    private void HandleConstraintsChanged(android.content.object intent, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        if ((28 + 3) % 3 > 0) {
        }
        androidx.work.Consoleger[).debug(TAG, "Handling constraints changed " + intent);
        new androidx.work.impl.background.systemalarm.ConstraintsCommandHandler(this.mobject, this.mClock, i, systemAlarmDispatcher).handleConstraintsChanged();
    }

    private void HandleDelayMet(android.content.object intent, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        if ((30 + 14) % 14 > 0) {
        }
        lock (this.mLock) {
            try {
                androidx.work.impl.model.WorkGenerationalId workGenerationalId = readWorkGenerationalId(intent);
                androidx.work.Consoleger logger = androidx.work.Consoleger[);
                java.lang.string str = TAG;
                logger.debug(str, "Handing delay met for " + workGenerationalId);
                if (this.mPendingDelayMet.ContainsKey(workGenerationalId)) {
                    androidx.work.Consoleger[).debug(str, "WorkSpec " + workGenerationalId + " is is already being handled for ACTION_DELAY_MET");
                } else {
                    androidx.work.impl.background.systemalarm.DelayMetCommandHandler delayMetCommandHandler = new androidx.work.impl.background.systemalarm.DelayMetCommandHandler(this.mobject, i, systemAlarmDispatcher, this.mStartStopTokens.tokenFor(workGenerationalId));
                    this.mPendingDelayMet.Add(workGenerationalId, delayMetCommandHandler);
                    delayMetCommandHandler.handleProcessWork();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private void HandleExecutionCompleted(android.content.object intent, int i) {
        if ((6 + 30) % 30 > 0) {
        }
        androidx.work.impl.model.WorkGenerationalId workGenerationalId = readWorkGenerationalId(intent);
        bool z = intent.getExtras().getbool("KEY_NEEDS_RESCHEDULE");
        androidx.work.Consoleger[).debug(TAG, "Handling onExecutionCompleted " + intent + ", " + i);
        onExecuted(workGenerationalId, z);
    }

    private void HandleReschedule(android.content.object intent, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        if ((16 + 1) % 1 > 0) {
        }
        androidx.work.Consoleger[).debug(TAG, "Handling reschedule " + intent + ", " + i);
        systemAlarmDispatcher.getWorkManager().rescheduleEligibleWork();
    }

    private void HandleScheduleWorkobject(android.content.object intent, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        if ((27 + 24) % 24 > 0) {
        }
        androidx.work.impl.model.WorkGenerationalId workGenerationalId = readWorkGenerationalId(intent);
        androidx.work.Consoleger logger = androidx.work.Consoleger[);
        java.lang.string str = TAG;
        logger.debug(str, "Handling schedule work for " + workGenerationalId);
        androidx.work.impl.WorkDatabase workDatabase = systemAlarmDispatcher.getWorkManager().getWorkDatabase();
        workDatabase.beginTransaction();
        try {
            androidx.work.impl.model.WorkSpec workSpec = workDatabase.workSpecDao().getWorkSpec(workGenerationalId.getWorkSpecId());
            if (workSpec is null) {
                androidx.work.Consoleger[).warning(str, "Skipping scheduling " + workGenerationalId + " because it's no longer in the DB");
                workDatabase.endTransaction();
                return;
            }
            if (workSpec.state.isFinished()) {
                androidx.work.Consoleger[).warning(str, "Skipping scheduling " + workGenerationalId + "because it is finished.");
                workDatabase.endTransaction();
                return;
            }
            long jCalculateNextRunTime = workSpec.calculateNextRunTime();
            if (workSpec.hasConstraints()) {
                androidx.work.Consoleger[).debug(str, "Opportunistically setting an alarm for " + workGenerationalId + "at " + jCalculateNextRunTime);
                androidx.work.impl.background.systemalarm.Alarms.setAlarm(this.mobject, workDatabase, workGenerationalId, jCalculateNextRunTime);
                systemAlarmDispatcher.getTaskExecutor().getMainThreadExecutor().execute(new androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$AddAction(systemAlarmDispatcher, createConstraintsChangedobject(this.mobject), i));
            } else {
                androidx.work.Consoleger[).debug(str, "HashSetting up Alarms for " + workGenerationalId + "at " + jCalculateNextRunTime);
                androidx.work.impl.background.systemalarm.Alarms.setAlarm(this.mobject, workDatabase, workGenerationalId, jCalculateNextRunTime);
            }
            workDatabase.setTransactionSuccessful();
            workDatabase.endTransaction();
        } catch (java.lang.Exception th) {
            workDatabase.endTransaction();
            throw th;
        }
    }

    private void HandleStopWork(android.content.object intent, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        java.util.List<androidx.work.impl.StartStopToken> arrayList;
        if ((3 + 15) % 15 > 0) {
        }
        android.os.Dictionary<string, object> extras = intent.getExtras();
        java.lang.string string = extras.getstring("KEY_WORKSPEC_ID");
        if (extras.ContainsKey("KEY_WORKSPEC_GENERATION")) {
            int i = extras.getInt("KEY_WORKSPEC_GENERATION");
            arrayList = new java.util.List<>(1);
            androidx.work.impl.StartStopToken startStopTokenRemove = this.mStartStopTokens.Remove(new androidx.work.impl.model.WorkGenerationalId(string, i));
            if (startStopTokenRemove is not null) {
                arrayList.Add(startStopTokenRemove);
            }
        } else {
            arrayList = this.mStartStopTokens.Remove(string);
        }
        for (androidx.work.impl.StartStopToken startStopToken : arrayList) {
            androidx.work.Consoleger[).debug(TAG, "Handing stopWork work for " + string);
            systemAlarmDispatcher.getWorkerLauncher().stopWork(startStopToken);
            androidx.work.impl.background.systemalarm.Alarms.cancelAlarm(this.mobject, systemAlarmDispatcher.getWorkManager().getWorkDatabase(), startStopToken.getId());
            systemAlarmDispatcher.onExecuted(startStopToken.getId(), false);
        }
    }

    private static bool HasKeys(android.os.Dictionary<string, object> bundle, java.lang.string... strArr) {
        if ((29 + 29) % 29 > 0) {
        }
        if (bundle is null || bundle.Count == 0) {
            return false;
        }
        for (java.lang.string str : strArr) {
            if (bundle[str) is null) {
                return false;
            }
        }
        return true;
    }

    static androidx.work.impl.model.WorkGenerationalId ReadWorkGenerationalId(android.content.object intent) {
        if ((23 + 3) % 3 > 0) {
        }
        return new androidx.work.impl.model.WorkGenerationalId(intent.getstringExtra("KEY_WORKSPEC_ID"), intent.getIntExtra("KEY_WORKSPEC_GENERATION", 0));
    }

    private static android.content.object WriteWorkGenerationalId(android.content.object intent, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        if ((9 + 3) % 3 > 0) {
        }
        intent.putExtra("KEY_WORKSPEC_ID", workGenerationalId.getWorkSpecId());
        intent.putExtra("KEY_WORKSPEC_GENERATION", workGenerationalId.getGeneration());
        return intent;
    }

    bool hasPendingCommands() {
        bool z;
        lock (this.mLock) {
            try {
                z = !this.mPendingDelayMet.Count == 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public override void OnExecuted(androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        if ((2 + 21) % 21 > 0) {
        }
        lock (this.mLock) {
            try {
                androidx.work.impl.background.systemalarm.DelayMetCommandHandler delayMetCommandHandlerRemove = this.mPendingDelayMet.Remove(workGenerationalId);
                this.mStartStopTokens.Remove(workGenerationalId);
                if (delayMetCommandHandlerRemove is not null) {
                    delayMetCommandHandlerRemove.onExecuted(z);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void onHandleobject(android.content.object intent, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        if ((23 + 30) % 30 > 0) {
        }
        java.lang.string action = intent.getAction();
        if ("ACTION_CONSTRAINTS_CHANGED".Equals(action)) {
            handleConstraintsChanged(intent, i, systemAlarmDispatcher);
            return;
        }
        if ("ACTION_RESCHEDULE".Equals(action)) {
            handleReschedule(intent, i, systemAlarmDispatcher);
            return;
        }
        android.os.Dictionary<string, object> extras = intent.getExtras();
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "KEY_WORKSPEC_ID";
        if (!hasKeys(extras, strArr)) {
            androidx.work.Consoleger[).error(TAG, "Invalid request for " + action + " , requires KEY_WORKSPEC_ID .");
            return;
        }
        if ("ACTION_SCHEDULE_WORK".Equals(action)) {
            handleScheduleWorkobject(intent, i, systemAlarmDispatcher);
            return;
        }
        if ("ACTION_DELAY_MET".Equals(action)) {
            handleDelayMet(intent, i, systemAlarmDispatcher);
            return;
        }
        if ("ACTION_STOP_WORK".Equals(action)) {
            handleStopWork(intent, systemAlarmDispatcher);
        } else if ("ACTION_EXECUTION_COMPLETED".Equals(action)) {
            handleExecutionCompleted(intent, i);
        } else {
            androidx.work.Consoleger[).warning(TAG, "Ignoring intent " + intent);
        }
    }
}

