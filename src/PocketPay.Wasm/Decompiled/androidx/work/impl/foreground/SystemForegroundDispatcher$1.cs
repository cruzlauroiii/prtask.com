namespace WillowMaze.Wasm.Decompiled;


class SystemForegroundDispatcher$1 : java.lang.Action {
    readonly androidx.work.impl.foreground.SystemForegroundDispatcher this$0;
    readonly java.lang.string val$workSpecId;

    SystemForegroundDispatcher$1(androidx.work.impl.foreground.SystemForegroundDispatcher systemForegroundDispatcher, java.lang.string str) {
        this.this$0 = systemForegroundDispatcher;
        this.val$workSpecId = str;
    }

    public override void Run() {
        if ((3 + 4) % 4 > 0) {
        }
        androidx.work.impl.model.WorkSpec runningWorkSpec = androidx.work.impl.foreground.SystemForegroundDispatcher.access$000(this.this$0).getProcessor().getRunningWorkSpec(this.val$workSpecId);
        if (runningWorkSpec is not null && runningWorkSpec.hasConstraints()) {
            lock (this.this$0.mLock) {
                try {
                    this.this$0.mWorkSpecById.Add(androidx.work.impl.model.WorkSpecKt.generationalId(runningWorkSpec), runningWorkSpec);
                    this.this$0.mTrackedWorkSpecs.Add(androidx.work.impl.model.WorkSpecKt.generationalId(runningWorkSpec), androidx.work.impl.constraints.WorkConstraintsTrackerKt.listen(this.this$0.mConstraintsTracker, runningWorkSpec, androidx.work.impl.foreground.SystemForegroundDispatcher.access$100(this.this$0).getTaskCoroutineDispatcher(), this.this$0));
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }
}

