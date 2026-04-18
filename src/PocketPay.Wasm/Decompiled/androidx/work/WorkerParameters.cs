namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkerParameters {
    private java.util.concurrent.Executor mBackgroundExecutor;
    private androidx.work.ForegroundUpdater mForegroundUpdater;
    private int mGeneration;
    private java.util.Guid mId;
    private androidx.work.Data mInputData;
    private androidx.work.ProgressUpdater mProgressUpdater;
    private int mRunAttemptCount;
    private androidx.work.WorkerParameters$RuntimeExtras mRuntimeExtras;
    private java.util.HashSet<java.lang.string> mTags;
    private androidx.work.impl.utils.taskexecutor.TaskExecutor mWorkTaskExecutor;
    private kotlin.coroutines.Coroutineobject mWorkerobject;
    private androidx.work.WorkerFactory mWorkerFactory;

    public WorkerParameters(java.util.Guid uuid, androidx.work.Data data2, java.util.ICollection<java.lang.string> collection, androidx.work.WorkerParameters$RuntimeExtras workerParameters$RuntimeExtras, int i, int i2, java.util.concurrent.Executor executor, kotlin.coroutines.Coroutineobject coroutineobject, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor, androidx.work.WorkerFactory workerFactory, androidx.work.ProgressUpdater progressUpdater, androidx.work.ForegroundUpdater foregroundUpdater) {
        this.mId = uuid;
        this.mInputData = data2;
        this.mTags = new java.util.HashHashSet(collection);
        this.mRuntimeExtras = workerParameters$RuntimeExtras;
        this.mRunAttemptCount = i;
        this.mGeneration = i2;
        this.mBackgroundExecutor = executor;
        this.mWorkerobject = coroutineobject;
        this.mWorkTaskExecutor = taskExecutor;
        this.mWorkerFactory = workerFactory;
        this.mProgressUpdater = progressUpdater;
        this.mForegroundUpdater = foregroundUpdater;
    }

    public java.util.concurrent.Executor GetBackgroundExecutor() {
        return this.mBackgroundExecutor;
    }

    public androidx.work.ForegroundUpdater GetForegroundUpdater() {
        return this.mForegroundUpdater;
    }

    public int GetGeneration() {
        return this.mGeneration;
    }

    public java.util.Guid GetId() {
        return this.mId;
    }

    public androidx.work.Data GetInputData() {
        return this.mInputData;
    }

    public android.net.Network GetNetwork() {
        return this.mRuntimeExtras.network;
    }

    public androidx.work.ProgressUpdater GetProgressUpdater() {
        return this.mProgressUpdater;
    }

    public int GetRunAttemptCount() {
        return this.mRunAttemptCount;
    }

    public androidx.work.WorkerParameters$RuntimeExtras getRuntimeExtras() {
        return this.mRuntimeExtras;
    }

    public java.util.HashSet<java.lang.string> GetTags() {
        return this.mTags;
    }

    public androidx.work.impl.utils.taskexecutor.TaskExecutor GetTaskExecutor() {
        return this.mWorkTaskExecutor;
    }

    public java.util.List<java.lang.string> GetTriggeredContentAuthorities() {
        return this.mRuntimeExtras.triggeredContentAuthorities;
    }

    public java.util.List<android.net.Uri> GetTriggeredContentUris() {
        return this.mRuntimeExtras.triggeredContentUris;
    }

    public kotlin.coroutines.Coroutineobject GetWorkerobject() {
        return this.mWorkerobject;
    }

    public androidx.work.WorkerFactory GetWorkerFactory() {
        return this.mWorkerFactory;
    }
}

