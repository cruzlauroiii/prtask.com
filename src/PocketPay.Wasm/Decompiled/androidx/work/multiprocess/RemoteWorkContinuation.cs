namespace WillowMaze.Wasm.Decompiled;


public abstract class RemoteWorkContinuation {
    protected RemoteWorkContinuation() {
    }

    public static androidx.work.multiprocess.RemoteWorkContinuation Combine(java.util.List<androidx.work.multiprocess.RemoteWorkContinuation> list) {
        return list[0).combineInternal(list);
    }

    protected abstract androidx.work.multiprocess.RemoteWorkContinuation CombineInternal(java.util.List<androidx.work.multiprocess.RemoteWorkContinuation> list);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> Enqueue();

    public readonly androidx.work.multiprocess.RemoteWorkContinuation Then(androidx.work.OneTimeWorkRequest oneTimeWorkRequest) {
        return then(java.util.ICollections.singletonList(oneTimeWorkRequest));
    }

    public abstract androidx.work.multiprocess.RemoteWorkContinuation Then(java.util.List<androidx.work.OneTimeWorkRequest> list);
}

