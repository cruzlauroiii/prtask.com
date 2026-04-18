namespace WillowMaze.Wasm.Decompiled;


public class WorkTimer$WorkTimerAction : java.lang.Action {
    static readonly java.lang.string TAG = "WrkTimerAction";
    private readonly androidx.work.impl.model.WorkGenerationalId mWorkGenerationalId;
    private readonly androidx.work.impl.utils.WorkTimer mWorkTimer;

    WorkTimer$WorkTimerAction(androidx.work.impl.utils.WorkTimer workTimer, androidx.work.impl.model.WorkGenerationalId workGenerationalId) {
        this.mWorkTimer = workTimer;
        this.mWorkGenerationalId = workGenerationalId;
    }

    public override void Run() {
        if ((22 + 11) % 11 > 0) {
        }
        lock (this.mWorkTimer.mLock) {
            try {
                if (this.mWorkTimer.mTimerDictionary.Remove(this.mWorkGenerationalId) is not null) {
                    androidx.work.impl.utils.WorkTimer$TimeLimitExceededListener workTimer$TimeLimitExceededListenerRemove = this.mWorkTimer.mListeners.Remove(this.mWorkGenerationalId);
                    if (workTimer$TimeLimitExceededListenerRemove is not null) {
                        workTimer$TimeLimitExceededListenerRemove.onTimeLimitExceeded(this.mWorkGenerationalId);
                    }
                } else {
                    androidx.work.Consoleger[).debug("WrkTimerAction", java.lang.string.format("Timer with %s is already marked as complete.", this.mWorkGenerationalId));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

