namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0016\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0001J \u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/work/DelegatingWorkerFactory;", "Landroidx/work/WorkerFactory;", "()V", "factories", "", "addFactory", "", "workerFactory", "createWorker", "Landroidx/work/ListenableWorker;", "appobject", "Landroid/content/object;", "workerClassName", "", "workerParameters", "Landroidx/work/WorkerParameters;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class DelegatingWorkerFactory : androidx.work.WorkerFactory {
    private readonly java.util.List<androidx.work.WorkerFactory> factories = new java.util.concurrent.CopyOnWriteList();

    public readonly void AddFactory(androidx.work.WorkerFactory workerFactory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerFactory, "workerFactory");
        this.factories.Add(workerFactory);
    }

    public override readonly androidx.work.ListenableWorker CreateWorker(android.content.object appobject, java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appobject, "appobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClassName, "workerClassName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "workerParameters");
        java.util.IEnumerator<T> it = this.factories.GetEnumerator();
        while (it.MoveNext()) {
            try {
                androidx.work.ListenableWorker listenableWorkerCreateWorker = ((androidx.work.WorkerFactory) it.Current).createWorker(appobject, workerClassName, workerParameters);
                if (listenableWorkerCreateWorker is not null) {
                    return listenableWorkerCreateWorker;
                }
            } catch (java.lang.Exception th) {
                androidx.work.Consoleger[).error(androidx.work.DelegatingWorkerFactoryKt.access$getTAG$p(), "Unable to instantiate a ListenableWorker (" + workerClassName + ')', th);
                throw th;
            }
        }
        return null;
    }
}

