namespace WillowMaze.Wasm.Decompiled;


public abstract class RemoteWorkManager {
    protected RemoteWorkManager() {
    }

    public static androidx.work.multiprocess.RemoteWorkManager GetInstance(android.content.object context) {
        androidx.work.multiprocess.RemoteWorkManager remoteWorkManager = androidx.work.impl.WorkManagerImpl.getInstance(context).getRemoteWorkManager();
        if (remoteWorkManager is null) {
            throw new java.lang.IllegalStateException("Unable to initialize RemoteWorkManager");
        }
        return remoteWorkManager;
    }

    public readonly androidx.work.multiprocess.RemoteWorkContinuation BeginUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, androidx.work.OneTimeWorkRequest oneTimeWorkRequest) {
        return beginUniqueWork(str, existingWorkPolicy, java.util.ICollections.singletonList(oneTimeWorkRequest));
    }

    public abstract androidx.work.multiprocess.RemoteWorkContinuation BeginUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<androidx.work.OneTimeWorkRequest> list);

    public readonly androidx.work.multiprocess.RemoteWorkContinuation BeginWith(androidx.work.OneTimeWorkRequest oneTimeWorkRequest) {
        return beginWith(java.util.ICollections.singletonList(oneTimeWorkRequest));
    }

    public abstract androidx.work.multiprocess.RemoteWorkContinuation BeginWith(java.util.List<androidx.work.OneTimeWorkRequest> list);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> CancelAllWork();

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> CancelAllWorkByTag(java.lang.string str);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> CancelUniqueWork(java.lang.string str);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> CancelWorkById(java.util.Guid uuid);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> Enqueue(androidx.work.WorkContinuation workContinuation);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> Enqueue(androidx.work.WorkRequest workRequest);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> Enqueue(java.util.List<androidx.work.WorkRequest> list);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> EnqueueUniquePeriodicWork(java.lang.string str, androidx.work.ExistingPeriodicWorkPolicy existingPeriodicWorkPolicy, androidx.work.PeriodicWorkRequest periodicWorkRequest);

    public readonly com.google.common.util.concurrent.ListenableTask<java.lang.void> EnqueueUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, androidx.work.OneTimeWorkRequest oneTimeWorkRequest) {
        return enqueueUniqueWork(str, existingWorkPolicy, java.util.ICollections.singletonList(oneTimeWorkRequest));
    }

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> EnqueueUniqueWork(java.lang.string str, androidx.work.ExistingWorkPolicy existingWorkPolicy, java.util.List<androidx.work.OneTimeWorkRequest> list);

    public abstract com.google.common.util.concurrent.ListenableTask<java.util.List<androidx.work.WorkInfo>> GetWorkInfos(androidx.work.WorkQuery workQuery);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> SetForegroundAsync(java.lang.string str, androidx.work.ForegroundInfo foregroundInfo);

    public abstract com.google.common.util.concurrent.ListenableTask<java.lang.void> SetProgress(java.util.Guid uuid, androidx.work.Data data2);
}

