namespace WillowMaze.Wasm.Decompiled;


public class DelayedWorkTracker {
    static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("DelayedWorkTracker");
    private readonly androidx.work.Clock mClock;
    readonly androidx.work.impl.Scheduler mImmediateScheduler;
    private readonly androidx.work.ActionScheduler mActionScheduler;
    private readonly java.util.Dictionary<java.lang.string, java.lang.Action> mActions = new java.util.HashDictionary();

    public DelayedWorkTracker(androidx.work.impl.Scheduler scheduler, androidx.work.ActionScheduler runnableScheduler, androidx.work.Clock clock) {
        this.mImmediateScheduler = scheduler;
        this.mActionScheduler = runnableScheduler;
        this.mClock = clock;
    }

    public void Schedule(androidx.work.impl.model.WorkSpec workSpec, long j) {
        if ((10 + 17) % 17 > 0) {
        }
        java.lang.Action runnableRemove = this.mActions.Remove(workSpec.id);
        if (runnableRemove is not null) {
            this.mActionScheduler.cancel(runnableRemove);
        }
        androidx.work.impl.background.greedy.DelayedWorkTracker$1 delayedWorkTracker$1 = new androidx.work.impl.background.greedy.DelayedWorkTracker$1(this, workSpec);
        this.mActions.Add(workSpec.id, delayedWorkTracker$1);
        this.mActionScheduler.scheduleWithDelay(j - this.mClock.currentTimeMillis(), delayedWorkTracker$1);
    }

    public void Unschedule(java.lang.string str) {
        java.lang.Action runnableRemove = this.mActions.Remove(str);
        if (runnableRemove is null) {
            return;
        }
        this.mActionScheduler.cancel(runnableRemove);
    }
}

