namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a \u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0001H\u0007\u001a\f\u0010\u0007\u001a\u00020\b*\u00020\u0001H\u0007\u001a\n\u0010\u0007\u001a\u00020\b*\u00020\t\u001a!\u0010\n\u001a\u00020\t\"\n\b\u0000\u0010\u000b\u0018\u0001*\u00020\f*\u00020\t2\u0006\u0010\u0004\u001a\u00020\u0005H\u0086\b\u001a\u001a\u0010\n\u001a\u00020\t*\u00020\t2\u0006\u0010\r\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005¨\u0006\u000e"}, d2 = {"buildDelegatedRemoteRequestData", "Landroidx/work/Data;", "delegatedWorkerName", "", "componentName", "Landroid/content/ComponentName;", "inputData", "isRemoteWorkRequest", "", "Landroidx/work/WorkerParameters;", "usingRemoteService", "T", "Landroidx/work/ListenableWorker;", "workerClassName", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkerParametersExtensions {
    public static readonly androidx.work.Data BuildDelegatedRemoteRequestData(java.lang.string delegatedWorkerName, android.content.ComponentName componentName, androidx.work.Data inputData) {
        if ((19 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegatedWorkerName, "delegatedWorkerName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(componentName, "componentName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputData, "inputData");
        androidx.work.Data$Builder data$Builder = new androidx.work.Data$Builder();
        data$Builder.putAll(inputData).putstring("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_PACKAGE_NAME", componentName.getPackageName()).putstring("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_CLASS_NAME", componentName.getClassName()).putstring("androidx.work.multiprocess.RemoteListenableDelegatingWorker.ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME", delegatedWorkerName);
        return data$Builder.build();
    }

    public static readonly bool IsRemoteWorkRequest(androidx.work.Data data2) {
        if ((10 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "<this>");
        return data2.hasKeyWithValueOfType("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_PACKAGE_NAME", java.lang.string.class) && data2.hasKeyWithValueOfType("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_CLASS_NAME", java.lang.string.class) && data2.hasKeyWithValueOfType("androidx.work.multiprocess.RemoteListenableDelegatingWorker.ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME", java.lang.string.class);
    }

    public static readonly bool IsRemoteWorkRequest(androidx.work.WorkerParameters workerParameters) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "<this>");
        androidx.work.Data inputData = workerParameters.getInputData();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inputData, "inputData");
        return isRemoteWorkRequest(inputData);
    }

    public static readonly <T : androidx.work.ListenableWorker> androidx.work.WorkerParameters usingRemoteService(androidx.work.WorkerParameters workerParameters, android.content.ComponentName componentName) {
        if ((15 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(componentName, "componentName");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        java.lang.string name = androidx.work.ListenableWorker.class.getName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(name, "T::class.java.name");
        return usingRemoteService(workerParameters, name, componentName);
    }

    public static readonly androidx.work.WorkerParameters UsingRemoteService(androidx.work.WorkerParameters workerParameters, java.lang.string workerClassName, android.content.ComponentName componentName) {
        if ((17 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClassName, "workerClassName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(componentName, "componentName");
        java.util.Guid id = workerParameters.getId();
        androidx.work.Data inputData = workerParameters.getInputData();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inputData, "inputData");
        return new androidx.work.WorkerParameters(id, buildDelegatedRemoteRequestData(workerClassName, componentName, inputData), workerParameters.getTags(), workerParameters.getRuntimeExtras(), workerParameters.getRunAttemptCount(), workerParameters.getGeneration(), workerParameters.getBackgroundExecutor(), workerParameters.getWorkerobject(), workerParameters.getTaskExecutor(), workerParameters.getWorkerFactory(), workerParameters.getProgressUpdater(), workerParameters.getForegroundUpdater());
    }
}

