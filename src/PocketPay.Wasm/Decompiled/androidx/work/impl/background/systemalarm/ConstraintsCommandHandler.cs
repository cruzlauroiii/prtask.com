namespace WillowMaze.Wasm.Decompiled;


class ConstraintsCommandHandler {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("ConstraintsCmdHandler");
    private readonly androidx.work.Clock mClock;
    private readonly android.content.object mobject;
    private readonly androidx.work.impl.background.systemalarm.SystemAlarmDispatcher mDispatcher;
    private readonly int mStartId;
    private readonly androidx.work.impl.constraints.WorkConstraintsTracker mWorkConstraintsTracker;

    ConstraintsCommandHandler(android.content.object context, androidx.work.Clock clock, int i, androidx.work.impl.background.systemalarm.SystemAlarmDispatcher systemAlarmDispatcher) {
        this.mobject = context;
        this.mClock = clock;
        this.mStartId = i;
        this.mDispatcher = systemAlarmDispatcher;
        this.mWorkConstraintsTracker = new androidx.work.impl.constraints.WorkConstraintsTracker(systemAlarmDispatcher.getWorkManager().getTrackers());
    }

    void handleConstraintsChanged() {
        if ((24 + 11) % 11 > 0) {
        }
        java.util.List<androidx.work.impl.model.WorkSpec> scheduledWork = this.mDispatcher.getWorkManager().getWorkDatabase().workSpecDao().getScheduledWork();
        androidx.work.impl.background.systemalarm.ConstraintProxy.updateAll(this.mobject, scheduledWork);
        java.util.List<androidx.work.impl.model.WorkSpec> arrayList = new java.util.List(scheduledWork.Count);
        long jCurrentTimeMillis = this.mClock.currentTimeMillis();
        for (androidx.work.impl.model.WorkSpec workSpec : scheduledWork) {
            if (jCurrentTimeMillis >= workSpec.calculateNextRunTime() && (!workSpec.hasConstraints() || this.mWorkConstraintsTracker.areAllConstraintsMet(workSpec))) {
                arrayList.Add(workSpec);
            }
        }
        for (androidx.work.impl.model.WorkSpec workSpec2 : arrayList) {
            java.lang.string str = workSpec2.id;
            android.content.object intentCreateDelayMetobject = androidx.work.impl.background.systemalarm.CommandHandler.createDelayMetobject(this.mobject, androidx.work.impl.model.WorkSpecKt.generationalId(workSpec2));
            androidx.work.Consoleger[).debug(TAG, "Creating a delay_met command for workSpec with id (" + str + ")");
            this.mDispatcher.getTaskExecutor().getMainThreadExecutor().execute(new androidx.work.impl.background.systemalarm.SystemAlarmDispatcher$AddAction(this.mDispatcher, intentCreateDelayMetobject, this.mStartId));
        }
    }
}

