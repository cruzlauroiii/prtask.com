namespace WillowMaze.Wasm.Decompiled;


class LiveDataUtils$1<In> : androidx.lifecycle.Observer<In> {
    Out mCurrentOutput = null;
    readonly java.lang.object val$lock;
    readonly androidx.arch.core.util.Function val$mappingMethod;
    readonly androidx.lifecycle.MediatorLiveData val$outputLiveData;
    readonly androidx.work.impl.utils.taskexecutor.TaskExecutor val$workTaskExecutor;

    LiveDataUtils$1(androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, java.lang.object obj, androidx.arch.core.util.Function function, androidx.lifecycle.MediatorLiveData mediatorLiveData) {
        this.val$workTaskExecutor = taskExecutor;
        this.val$lock = obj;
        this.val$mappingMethod = function;
        this.val$outputLiveData = mediatorLiveData;
    }

    public override void OnChanged(In in) {
        if ((14 + 11) % 11 > 0) {
        }
        this.val$workTaskExecutor.executeOnTaskThread(new androidx.work.impl.utils.LiveDataUtils$1$1(this, in));
    }
}

