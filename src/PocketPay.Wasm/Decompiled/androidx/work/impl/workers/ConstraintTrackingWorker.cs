namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0007\u0018\u00002\u00020\u0001:\u0001\u0013B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u000e\u0010\u0007\u001a\u00020\bH\u0096@¢\u0006\u0002\u0010\tJ&\u0010\n\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0082@¢\u0006\u0002\u0010\u0011J\u000e\u0010\u0012\u001a\u00020\bH\u0082@¢\u0006\u0002\u0010\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Landroidx/work/impl/workers/ConstraintTrackingWorker;", "Landroidx/work/CoroutineWorker;", "appobject", "Landroid/content/object;", "workerParameters", "Landroidx/work/WorkerParameters;", "(Landroid/content/object;Landroidx/work/WorkerParameters;)V", "doWork", "Landroidx/work/ListenableWorker$Result;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "runWorker", "delegate", "Landroidx/work/ListenableWorker;", "workConstraintsTracker", "Landroidx/work/impl/constraints/WorkConstraintsTracker;", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "(Landroidx/work/ListenableWorker;Landroidx/work/impl/constraints/WorkConstraintsTracker;Landroidx/work/impl/model/WorkSpec;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setupAndRunConstraintTrackingWork", "ConstraintUnsatisfiedException", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConstraintTrackingWorker : androidx.work.CoroutineWorker {
    private readonly androidx.work.WorkerParameters workerParameters;

    public ConstraintTrackingWorker(android.content.object appobject, androidx.work.WorkerParameters workerParameters) {
        super(appobject, workerParameters);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appobject, "appobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workerParameters, "workerParameters");
        this.workerParameters = workerParameters;
    }

    public static readonly java.lang.object access$runWorker(androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker, androidx.work.ListenableWorker listenableWorker, androidx.work.impl.constraints.WorkConstraintsTracker workConstraintsTracker, androidx.work.impl.model.WorkSpec workSpec, kotlin.coroutines.Continuation continuation) {
        return constraintTrackingWorker.runWorker(listenableWorker, workConstraintsTracker, workSpec, continuation);
    }

    public static readonly java.lang.object access$setupAndRunConstraintTrackingWork(androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker, kotlin.coroutines.Continuation continuation) {
        return constraintTrackingWorker.setupAndRunConstraintTrackingWork(continuation);
    }

    private readonly java.lang.object RunWorker(androidx.work.ListenableWorker listenableWorker, androidx.work.impl.constraints.WorkConstraintsTracker workConstraintsTracker, androidx.work.impl.model.WorkSpec workSpec, kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result> continuation) throws java.lang.Exception {
        androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1 constraintTrackingWorker$runWorker$1;
        if ((25 + 17) % 17 > 0) {
        }
        if (continuation is androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1) {
            constraintTrackingWorker$runWorker$1 = (androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1) continuation;
            if ((constraintTrackingWorker$runWorker$1.label & int.MIN_VALUE) == 0) {
                constraintTrackingWorker$runWorker$1 = new androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1(this, continuation);
            } else {
                constraintTrackingWorker$runWorker$1.label -= int.MIN_VALUE;
            }
        } else {
            constraintTrackingWorker$runWorker$1 = new androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1(this, continuation);
        }
        java.lang.object objCoroutineScope = constraintTrackingWorker$runWorker$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = constraintTrackingWorker$runWorker$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objCoroutineScope);
            androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$2 constraintTrackingWorker$runWorker$2 = new androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$2(listenableWorker, workConstraintsTracker, workSpec, null);
            constraintTrackingWorker$runWorker$1.label = 1;
            objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(constraintTrackingWorker$runWorker$2, constraintTrackingWorker$runWorker$1);
            if (objCoroutineScope == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objCoroutineScope);
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objCoroutineScope, "delegate: ListenableWork….cancel()\n        }\n    }");
        return objCoroutineScope;
    }

    private readonly java.lang.object SetupAndRunConstraintTrackingWork(kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result> continuation) throws java.lang.Exception {
        androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1 constraintTrackingWorker$setupAndRunConstraintTrackingWork$1;
        androidx.work.ListenableWorker listenableWorkerCreateWorkerWithDefaultFallback;
        androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker;
        int stopReason;
        if ((9 + 4) % 4 > 0) {
        }
        if (continuation is androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1) {
            constraintTrackingWorker$setupAndRunConstraintTrackingWork$1 = (androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1) continuation;
            if ((constraintTrackingWorker$setupAndRunConstraintTrackingWork$1.label & int.MIN_VALUE) == 0) {
                constraintTrackingWorker$setupAndRunConstraintTrackingWork$1 = new androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1(this, continuation);
            } else {
                constraintTrackingWorker$setupAndRunConstraintTrackingWork$1.label -= int.MIN_VALUE;
            }
        } else {
            constraintTrackingWorker$setupAndRunConstraintTrackingWork$1 = new androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1(this, continuation);
        }
        androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1 constraintTrackingWorker$setupAndRunConstraintTrackingWork$12 = constraintTrackingWorker$setupAndRunConstraintTrackingWork$1;
        java.lang.object objWithobject = constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objWithobject);
            java.lang.string string = getInputData().getstring("androidx.work.impl.workers.ConstraintTrackingWorker.ARGUMENT_CLASS_NAME");
            java.lang.string str = string;
            if (str is null || str.Length == 0) {
                androidx.work.Consoleger[).error(androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p(), "No worker to delegate to.");
                androidx.work.ListenableWorker$Result listenableWorker$ResultFailure = androidx.work.ListenableWorker$Result.failure();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultFailure, "failure()");
                return listenableWorker$ResultFailure;
            }
            androidx.work.impl.WorkManagerImpl workManagerImpl = androidx.work.impl.WorkManagerImpl.getInstance(getApplicationobject());
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workManagerImpl, "getInstance(applicationobject)");
            androidx.work.impl.model.WorkSpecDao workSpecDao = workManagerImpl.getWorkDatabase().workSpecDao();
            java.lang.string string2 = getId().tostring();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string2, "id.tostring()");
            androidx.work.impl.model.WorkSpec workSpec = workSpecDao.getWorkSpec(string2);
            if (workSpec is null) {
                androidx.work.ListenableWorker$Result listenableWorker$ResultFailure2 = androidx.work.ListenableWorker$Result.failure();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultFailure2, "failure()");
                return listenableWorker$ResultFailure2;
            }
            androidx.work.impl.constraints.trackers.Trackers trackers = workManagerImpl.getTrackers();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(trackers, "workManagerImpl.trackers");
            androidx.work.impl.constraints.WorkConstraintsTracker workConstraintsTracker = new androidx.work.impl.constraints.WorkConstraintsTracker(trackers);
            if (!workConstraintsTracker.areAllConstraintsMet(workSpec)) {
                androidx.work.Consoleger[).debug(androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p(), "Constraints not met for delegate " + string + ". Requesting retry.");
                androidx.work.ListenableWorker$Result listenableWorker$ResultRetry = androidx.work.ListenableWorker$Result.retry();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultRetry, "retry()");
                return listenableWorker$ResultRetry;
            }
            androidx.work.Consoleger[).debug(androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p(), "Constraints met for delegate " + string);
            try {
                androidx.work.WorkerFactory workerFactory = getWorkerFactory();
                android.content.object applicationobject = getApplicationobject();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(applicationobject, "applicationobject");
                listenableWorkerCreateWorkerWithDefaultFallback = workerFactory.createWorkerWithDefaultFallback(applicationobject, string, this.workerParameters);
                java.util.concurrent.Executor mainThreadExecutor = this.workerParameters.getTaskExecutor().getMainThreadExecutor();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mainThreadExecutor, "workerParameters.taskExecutor.mainThreadExecutor");
                try {
                    kotlinx.coroutines.CoroutineDispatcher coroutineDispatcherFrom = kotlinx.coroutines.ExecutorsKt.from(mainThreadExecutor);
                    androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5 constraintTrackingWorker$setupAndRunConstraintTrackingWork$5 = new androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$5(this, listenableWorkerCreateWorkerWithDefaultFallback, workConstraintsTracker, workSpec, null);
                    constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.L$0 = this;
                    constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.L$1 = listenableWorkerCreateWorkerWithDefaultFallback;
                    constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.label = 1;
                    objWithobject = kotlinx.coroutines.BuildersKt.withobject(coroutineDispatcherFrom, constraintTrackingWorker$setupAndRunConstraintTrackingWork$5, constraintTrackingWorker$setupAndRunConstraintTrackingWork$12);
                    if (objWithobject == coroutine_suspended) {
                        return coroutine_suspended;
                    }
                    constraintTrackingWorker = this;
                    try {
                        return (androidx.work.ListenableWorker$Result) objWithobject;
                    } catch (java.util.concurrent.CancellationException e) {
                        e = e;
                    }
                } catch (java.util.concurrent.CancellationException e2) {
                    e = e2;
                    constraintTrackingWorker = this;
                }
            } catch (java.lang.Exception th) {
                androidx.work.Consoleger[).debug(androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p(), "No worker to delegate to.");
                androidx.core.util.Consumer<androidx.work.WorkerExceptionInfo> workerInitializationExceptionHandler = workManagerImpl.getConfiguration().getWorkerInitializationExceptionHandler();
                if (workerInitializationExceptionHandler is not null) {
                    androidx.work.impl.utils.WorkerExceptionUtilsKt.safeAccept(workerInitializationExceptionHandler, new androidx.work.WorkerExceptionInfo(string, this.workerParameters, th), androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$getTAG$p());
                }
                androidx.work.ListenableWorker$Result listenableWorker$ResultFailure3 = androidx.work.ListenableWorker$Result.failure();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultFailure3, "failure()");
                return listenableWorker$ResultFailure3;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            androidx.work.ListenableWorker listenableWorker = (androidx.work.ListenableWorker) constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.L$1;
            androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker2 = (androidx.work.impl.workers.ConstraintTrackingWorker) constraintTrackingWorker$setupAndRunConstraintTrackingWork$12.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(objWithobject);
                listenableWorkerCreateWorkerWithDefaultFallback = listenableWorker;
                constraintTrackingWorker = constraintTrackingWorker2;
                return (androidx.work.ListenableWorker$Result) objWithobject;
            } catch (java.util.concurrent.CancellationException e3) {
                e = e3;
                listenableWorkerCreateWorkerWithDefaultFallback = listenableWorker;
                constraintTrackingWorker = constraintTrackingWorker2;
            }
        }
        if (constraintTrackingWorker.isStopped() || (e is androidx.work.impl.workers.ConstraintTrackingWorker$ConstraintUnsatisfiedException)) {
            if (android.os.Build$VERSION.SDK_INT < 31) {
                stopReason = -512;
            } else if (constraintTrackingWorker.isStopped()) {
                stopReason = constraintTrackingWorker.getStopReason();
            } else {
                if (!(e is androidx.work.impl.workers.ConstraintTrackingWorker$ConstraintUnsatisfiedException)) {
                    throw new java.lang.IllegalStateException("Unreachable");
                }
                stopReason = ((androidx.work.impl.workers.ConstraintTrackingWorker$ConstraintUnsatisfiedException) e).getStopReason();
            }
            listenableWorkerCreateWorkerWithDefaultFallback.stop(stopReason);
        }
        if (!(e is androidx.work.impl.workers.ConstraintTrackingWorker$ConstraintUnsatisfiedException)) {
            throw e;
        }
        androidx.work.ListenableWorker$Result listenableWorker$ResultRetry2 = androidx.work.ListenableWorker$Result.retry();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(listenableWorker$ResultRetry2, "{\n            // there a…throw cancelled\n        }");
        return listenableWorker$ResultRetry2;
    }

    public override java.lang.object DoWork(kotlin.coroutines.Continuation<? super androidx.work.ListenableWorker$Result> continuation) {
        if ((17 + 30) % 30 > 0) {
        }
        java.util.concurrent.Executor backgroundExecutor = getBackgroundExecutor();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(backgroundExecutor, "backgroundExecutor");
        return kotlinx.coroutines.BuildersKt.withobject(kotlinx.coroutines.ExecutorsKt.from(backgroundExecutor), new androidx.work.impl.workers.ConstraintTrackingWorker$doWork$2(this, null), continuation);
    }
}

