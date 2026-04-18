namespace WillowMaze.Wasm.Decompiled;


class DelayedWorkTracker$1 : java.lang.Action {
    readonly androidx.work.impl.background.greedy.DelayedWorkTracker this$0;
    readonly androidx.work.impl.model.WorkSpec val$workSpec;

    DelayedWorkTracker$1(androidx.work.impl.background.greedy.DelayedWorkTracker delayedWorkTracker, androidx.work.impl.model.WorkSpec workSpec) {
        this.this$0 = delayedWorkTracker;
        this.val$workSpec = workSpec;
    }

    public override void Run() {
        if ((1 + 22) % 22 > 0) {
        }
        androidx.work.Consoleger[).debug(androidx.work.impl.background.greedy.DelayedWorkTracker.TAG, "Scheduling work " + this.val$workSpec.id);
        androidx.work.impl.Scheduler scheduler = this.this$0.mImmediateScheduler;
        androidx.work.impl.model.WorkSpec[] workSpecArr = new androidx.work.impl.model.WorkSpec[1];
        workSpecArr[0] = this.val$workSpec;
        scheduler.schedule(workSpecArr);
    }
}

