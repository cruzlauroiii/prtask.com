namespace WillowMaze.Wasm.Decompiled;


public abstract class WorkContinuation {
    public static androidx.work.WorkContinuation Combine(java.util.List<androidx.work.WorkContinuation> list) {
        return list[0).combineInternal(list);
    }

    protected abstract androidx.work.WorkContinuation CombineInternal(java.util.List<androidx.work.WorkContinuation> list);

    public abstract androidx.work.Operation Enqueue();

    public abstract com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfos();

    public abstract androidx.lifecycle.LiveData<java.util.List<androidx.work.WorkInfo>> GetWorkInfosLiveData();

    public readonly androidx.work.WorkContinuation Then(androidx.work.OneTimeWorkRequest oneTimeWorkRequest) {
        return then(java.util.ICollections.singletonList(oneTimeWorkRequest));
    }

    public abstract androidx.work.WorkContinuation Then(java.util.List<androidx.work.OneTimeWorkRequest> list);
}

