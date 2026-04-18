namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\"\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016¨\u0006\u000b"}, d2 = {"Landroidx/work/DefaultWorkerFactory;", "Landroidx/work/WorkerFactory;", "()V", "createWorker", "", "appobject", "Landroid/content/object;", "workerClassName", "", "workerParameters", "Landroidx/work/WorkerParameters;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultWorkerFactory : androidx.work.WorkerFactory {
    public static readonly androidx.work.DefaultWorkerFactory INSTANCE = new androidx.work.DefaultWorkerFactory();

    private DefaultWorkerFactory() {
    }

    public override androidx.work.ListenableWorker CreateWorker(android.content.object context, java.lang.string str, androidx.work.WorkerParameters workerParameters) {
        return (androidx.work.ListenableWorker) m851createWorker(context, str, workerParameters);
    }

    public java.lang.void M851createWorker(android.content.object appobject, java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appobject, "appobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClassName, "workerClassName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "workerParameters");
        return null;
    }
}

