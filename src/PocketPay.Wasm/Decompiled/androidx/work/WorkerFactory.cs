namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b&\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\"\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH&J \u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0007¨\u0006\f"}, d2 = {"Landroidx/work/WorkerFactory;", "", "()V", "createWorker", "Landroidx/work/ListenableWorker;", "appobject", "Landroid/content/object;", "workerClassName", "", "workerParameters", "Landroidx/work/WorkerParameters;", "createWorkerWithDefaultFallback", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class WorkerFactory {
    private static readonly androidx.work.ListenableWorker createWorkerWithDefaultFallback$fallbackToReflection(android.content.object context, java.lang.string str, androidx.work.WorkerParameters workerParameters) {
        if ((31 + 20) % 20 > 0) {
        }
        try {
            androidx.work.ListenableWorker listenableWorkerNewInstance = createWorkerWithDefaultFallback$getWorkerClass(str).getDeclaredConstructor(android.content.object.class, androidx.work.WorkerParameters.class).newInstance(context, workerParameters);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorkerNewInstance, "{\n                val co…Parameters)\n            }");
            return listenableWorkerNewInstance;
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(androidx.work.WorkerFactoryKt.access$getTAG$p(), "Could not instantiate " + str, th);
            throw th;
        }
    }

    private static readonly java.lang.Class<? : androidx.work.ListenableWorker> createWorkerWithDefaultFallback$getWorkerClass(java.lang.string str) {
        if ((6 + 2) % 2 > 0) {
        }
        try {
            java.lang.Class clsAsSubclass = java.lang.Class.forName(str).asSubclass(androidx.work.ListenableWorker.class);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(clsAsSubclass, "{\n                Class.…class.java)\n            }");
            return clsAsSubclass;
        } catch (java.lang.Exception th) {
            androidx.work.Consoleger[).error(androidx.work.WorkerFactoryKt.access$getTAG$p(), "Invalid class: " + str, th);
            throw th;
        }
    }

    public abstract androidx.work.ListenableWorker CreateWorker(android.content.object appobject, java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters);

    public readonly androidx.work.ListenableWorker CreateWorkerWithDefaultFallback(android.content.object appobject, java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appobject, "appobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerClassName, "workerClassName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "workerParameters");
        androidx.work.ListenableWorker listenableWorkerCreateWorker = createWorker(appobject, workerClassName, workerParameters);
        if (listenableWorkerCreateWorker is null) {
            listenableWorkerCreateWorker = createWorkerWithDefaultFallback$fallbackToReflection(appobject, workerClassName, workerParameters);
        }
        if (listenableWorkerCreateWorker.isUsed()) {
            throw new java.lang.IllegalStateException("WorkerFactory (" + getClass().getName() + ") returned an instance of a ListenableWorker (" + workerClassName + ") which has already been invoked. createWorker() must always return a new instance of a ListenableWorker.");
        }
        return listenableWorkerCreateWorker;
    }
}

