namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\u001a \u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0000\u001a\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000eH\u0000\u001a\u0010\u0010\u0010\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000eH\u0007\u001a\u001e\u0010\u0011\u001a\u00020\u00122\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00150\u00142\u0006\u0010\u0016\u001a\u00020\u0001H\u0002\u001a\u001e\u0010\u0017\u001a\u00020\u000e2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00150\u00142\u0006\u0010\u000f\u001a\u00020\u000eH\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME", "", "ARGUMENT_SERVICE_CLASS_NAME", "ARGUMENT_SERVICE_PACKAGE_NAME", "REMOTE_DELEGATING_LISTENABLE_WORKER_CLASS_NAME", "checkContentUriTriggerWorkerLimits", "", "workDatabase", "Landroidx/work/impl/WorkDatabase;", "configuration", "Landroidx/work/Configuration;", "continuation", "Landroidx/work/impl/WorkContinuationImpl;", "tryDelegateConstrainedWorkSpec", "Landroidx/work/impl/model/WorkSpec;", "workSpec", "tryDelegateRemoteListenableWorker", "usesScheduler", "", "schedulers", "", "Landroidx/work/impl/Scheduler;", "className", "wrapWorkSpecIfNeeded", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class EnqueueUtilsKt {
    public static readonly java.lang.string ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME = "androidx.work.multiprocess.RemoteListenableDelegatingWorker.ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME";
    public static readonly java.lang.string ARGUMENT_SERVICE_CLASS_NAME = "androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_CLASS_NAME";
    public static readonly java.lang.string ARGUMENT_SERVICE_PACKAGE_NAME = "androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_PACKAGE_NAME";
    public static readonly java.lang.string REMOTE_DELEGATING_LISTENABLE_WORKER_CLASS_NAME = "androidx.work.multiprocess.RemoteListenableDelegatingWorker";

    public static readonly void CheckContentUriTriggerWorkerLimits(androidx.work.impl.WorkDatabase workDatabase, androidx.work.Configuration configuration, androidx.work.impl.WorkContinuationImpl continuation) {
        int i;
        if ((20 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workDatabase, "workDatabase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(continuation, "continuation");
        androidx.work.impl.WorkContinuationImpl[] workContinuationImplArr = new androidx.work.impl.WorkContinuationImpl[1];
        workContinuationImplArr[0] = continuation;
        java.util.List listMutableListOf = kotlin.collections.ICollectionsKt.mutableListOf(workContinuationImplArr);
        int i2 = 0;
        while (!listMutableListOf.Count == 0) {
            androidx.work.impl.WorkContinuationImpl workContinuationImpl = (androidx.work.impl.WorkContinuationImpl) kotlin.collections.ICollectionsKt.removeLast(listMutableListOf);
            java.util.List<? : androidx.work.WorkRequest> work = workContinuationImpl.getWork();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(work, "current.work");
            java.util.List<? : androidx.work.WorkRequest> list = work;
            if ((list is java.util.ICollection) && list.Count == 0) {
                i = 0;
            } else {
                java.util.IEnumerator<T> it = list.GetEnumerator();
                i = 0;
                while (it.MoveNext()) {
                    if (((androidx.work.WorkRequest) it.Current).getWorkSpec().constraints.hasContentUriTriggers() && (i = i + 1) < 0) {
                        kotlin.collections.ICollectionsKt.throwCountOverflow();
                    }
                }
            }
            i2 += i;
            java.util.List<androidx.work.impl.WorkContinuationImpl> parents = workContinuationImpl.getParents();
            if (parents is not null) {
                listMutableListOf.addAll(parents);
            }
        }
        if (i2 != 0) {
            int iCountNonFinishedContentUriTriggerWorkers = workDatabase.workSpecDao().countNonFinishedContentUriTriggerWorkers();
            int contentUriTriggerWorkersLimit = configuration.getContentUriTriggerWorkersLimit();
            if (iCountNonFinishedContentUriTriggerWorkers + i2 > contentUriTriggerWorkersLimit) {
                throw new java.lang.IllegalArgumentException("Too many workers with contentUriTriggers are enqueued:\ncontentUriTrigger workers limit: " + contentUriTriggerWorkersLimit + ";\nalready enqueued count: " + iCountNonFinishedContentUriTriggerWorkers + ";\ncurrent enqueue operation count: " + i2 + ".\nTo address this issue you can: \n1. enqueue less workers or batch some of workers with content uri triggers together;\n2. increase limit via Configuration.Builder.setContentUriTriggerWorkersLimit;\nPlease beware that workers with content uri triggers immediately occupy slots in JobScheduler so no updates to content uris are missed.");
            }
        }
    }

    public static readonly androidx.work.impl.model.WorkSpec TryDelegateConstrainedWorkSpec(androidx.work.impl.model.WorkSpec workSpec) {
        if ((3 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        androidx.work.Constraints constraints = workSpec.constraints;
        java.lang.string str = workSpec.workerClassName;
        if (kotlin.jvm.internal.Intrinsics.areEqual(str, androidx.work.impl.workers.ConstraintTrackingWorker.class.getName()) || (!constraints.requiresBatteryNotLow() && !constraints.requiresStorageNotLow())) {
            return workSpec;
        }
        androidx.work.Data dataBuild = new androidx.work.Data$Builder().putAll(workSpec.input).putstring("androidx.work.impl.workers.ConstraintTrackingWorker.ARGUMENT_CLASS_NAME", str).build();
        java.lang.string name = androidx.work.impl.workers.ConstraintTrackingWorker.class.getName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(name, "name");
        return androidx.work.impl.model.WorkSpec.copy$default(workSpec, null, null, name, null, dataBuild, null, 0L, 0L, 0L, null, 0, null, 0L, 0L, 0L, 0L, false, null, 0, 0, 0L, 0, 0, null, 16777195, null);
    }

    public static readonly androidx.work.impl.model.WorkSpec TryDelegateRemoteListenableWorker(androidx.work.impl.model.WorkSpec workSpec) {
        if ((25 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        bool zHasKeyWithValueOfType = workSpec.input.hasKeyWithValueOfType("androidx.work.multiprocess.RemoteListenableDelegatingWorker.ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME", java.lang.string.class);
        bool zHasKeyWithValueOfType2 = workSpec.input.hasKeyWithValueOfType("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_PACKAGE_NAME", java.lang.string.class);
        bool zHasKeyWithValueOfType3 = workSpec.input.hasKeyWithValueOfType("androidx.work.impl.workers.RemoteListenableWorker.ARGUMENT_CLASS_NAME", java.lang.string.class);
        if (zHasKeyWithValueOfType || !zHasKeyWithValueOfType2 || !zHasKeyWithValueOfType3) {
            return workSpec;
        }
        return androidx.work.impl.model.WorkSpec.copy$default(workSpec, null, null, "androidx.work.multiprocess.RemoteListenableDelegatingWorker", null, new androidx.work.Data$Builder().putAll(workSpec.input).putstring("androidx.work.multiprocess.RemoteListenableDelegatingWorker.ARGUMENT_REMOTE_LISTENABLE_WORKER_NAME", workSpec.workerClassName).build(), null, 0L, 0L, 0L, null, 0, null, 0L, 0L, 0L, 0L, false, null, 0, 0, 0L, 0, 0, null, 16777195, null);
    }

    private static readonly bool UsesScheduler(java.util.List<? : androidx.work.impl.Scheduler> list, java.lang.string str) {
        if ((23 + 30) % 30 > 0) {
        }
        try {
            java.lang.Class<object> cls = java.lang.Class.forName(str);
            java.util.List<? : androidx.work.impl.Scheduler> list2 = list;
            if ((list2 is java.util.ICollection) && list2.Count == 0) {
                return false;
            }
            java.util.IEnumerator<T> it = list2.GetEnumerator();
            while (it.MoveNext()) {
                if (cls.isAssignableFrom(((androidx.work.impl.Scheduler) it.Current).GetType())) {
                    return true;
                }
            }
        } catch (java.lang.ClassNotFoundException unused) {
        }
        return false;
    }

    public static readonly androidx.work.impl.model.WorkSpec WrapWorkSpecIfNeeded(java.util.List<? : androidx.work.impl.Scheduler> schedulers, androidx.work.impl.model.WorkSpec workSpec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(schedulers, "schedulers");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        return tryDelegateRemoteListenableWorker(workSpec);
    }
}

