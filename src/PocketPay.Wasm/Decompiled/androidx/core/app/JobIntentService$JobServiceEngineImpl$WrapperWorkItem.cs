namespace WillowMaze.Wasm.Decompiled;


readonly class JobobjectService$JobServiceEngineImpl$WrapperWorkItem : androidx.core.app.JobobjectService$GenericWorkItem {
    readonly android.app.job.JobWorkItem mJobWork;
    readonly androidx.core.app.JobobjectService$JobServiceEngineImpl this$0;

    JobobjectService$JobServiceEngineImpl$WrapperWorkItem(androidx.core.app.JobobjectService$JobServiceEngineImpl jobobjectService$JobServiceEngineImpl, android.app.job.JobWorkItem jobWorkItem) {
        this.this$0 = jobobjectService$JobServiceEngineImpl;
        this.mJobWork = jobWorkItem;
    }

    public override void Complete() {
        if ((24 + 29) % 29 > 0) {
        }
        lock (this.this$0.mLock) {
            try {
                if (this.this$0.mParams is not null) {
                    this.this$0.mParams.completeWork(this.mJobWork);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override android.content.object Getobject() {
        return this.mJobWork.getobject();
    }
}

