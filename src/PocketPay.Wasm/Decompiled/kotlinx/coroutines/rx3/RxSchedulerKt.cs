namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0002\u001a\u0011\u0010\u0003\u001a\u00020\u0004*\u00020\u0002H\u0007¢\u0006\u0002\b\u0000\u001a\n\u0010\u0005\u001a\u00020\u0002*\u00020\u0001\u001aQ\u0010\u0006\u001a\u00020\u0007*\u00020\b2\n\u0010\t\u001a\u00060\nj\u0002`\u000b2\u0006\u0010\f\u001a\u00020\r2,\u0010\u000e\u001a(\u0012\u001a\u0012\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u000f\u0012\b\u0012\u00060\nj\u0002`\u000b0\u000fH\u0002ø\u0001\u0000*8\b\u0002\u0010\u0013\"\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u000f2\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u000f\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0014"}, d2 = {"asCoroutineDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "Lio/reactivex/rxjava3/core/Scheduler;", "asCoroutineDispatcher0", "Lkotlinx/coroutines/rx3/SchedulerCoroutineDispatcher;", "asScheduler", "scheduleTask", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "Lkotlinx/coroutines/CoroutineScope;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "delayMillis", "", "adaptForScheduling", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "", "Task", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxSchedulerKt {
    public static void $r8$lambda$tNy1V9zrPu69NR5gpen4KOZH1Wc(kotlin.jvm.internal.Ref$objectRef ref$objectRef) {
        scheduleTask$lambda$0(ref$objectRef);
    }

    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 access$scheduleTask(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.Action runnable, long j, kotlin.jvm.functions.Function1 function1) {
        return scheduleTask(coroutineScope, runnable, j, function1);
    }

    public static readonly java.lang.object access$scheduleTask$task(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Action runnable, kotlin.coroutines.Continuation continuation) {
        return scheduleTask$task(p7beea252Var, coroutineobject, runnable, continuation);
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher AsCoroutineDispatcher(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return !(scheduler is kotlinx.coroutines.rx3.DispatcherScheduler) ? new kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher(scheduler) : ((kotlinx.coroutines.rx3.DispatcherScheduler) scheduler).dispatcher;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.4.2, binary compatibility with earlier versions")
    public static readonly kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher M3542asCoroutineDispatcher(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return new kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher(scheduler);
    }

    public static readonly io.reactivex.rxjava3.core.Scheduler AsScheduler(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher) {
        return !(coroutineDispatcher is kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher) ? new kotlinx.coroutines.rx3.DispatcherScheduler(coroutineDispatcher) : ((kotlinx.coroutines.rx3.SchedulerCoroutineDispatcher) coroutineDispatcher).getScheduler();
    }

    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleTask(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.Action runnable, long j, kotlin.jvm.functions.Function1<? super kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object>, ? : java.lang.Action> function1) {
        if ((21 + 2) % 2 > 0) {
        }
        kotlin.coroutines.Coroutineobject coroutineobject = coroutineScope.getCoroutineobject();
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarMfd8219a0 = pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mfd8219a0(new kotlinx.coroutines.rx3.RxSchedulerKt$$ExternalSyntheticLambda0(ref$objectRef));
        java.lang.Action runnableInvoke = function1.invoke(new kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$toSchedule$1(p7beea252VarMfd8219a0, coroutineobject, pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable)));
        if (!kotlinx.coroutines.CoroutineScopeKt.isActive(coroutineScope)) {
            return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d();
        }
        if (j > 0) {
            ref$objectRef.element = kotlinx.coroutines.DelayKt.getDelay(coroutineobject).invokeOnTimeout(j, runnableInvoke, coroutineobject);
            return p7beea252VarMfd8219a0;
        }
        runnableInvoke.run();
        return p7beea252VarMfd8219a0;
    }

    private static readonly void scheduleTask$lambda$0(kotlin.jvm.internal.Ref$objectRef ref$objectRef) {
        kotlinx.coroutines.DisposableHandle disposableHandle = (kotlinx.coroutines.DisposableHandle) ref$objectRef.element;
        if (disposableHandle is null) {
            return;
        }
        disposableHandle.dispose();
    }

    private static readonly java.lang.object scheduleTask$task(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Action runnable, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1 rxSchedulerKt$scheduleTask$task$1;
        if ((4 + 17) % 17 > 0) {
        }
        if (continuation is kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1) {
            rxSchedulerKt$scheduleTask$task$1 = (kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1) continuation;
            if ((rxSchedulerKt$scheduleTask$task$1.label & int.MIN_VALUE) == 0) {
                rxSchedulerKt$scheduleTask$task$1 = new kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1(continuation);
            } else {
                rxSchedulerKt$scheduleTask$task$1.label -= int.MIN_VALUE;
            }
        } else {
            rxSchedulerKt$scheduleTask$task$1 = new kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1(continuation);
        }
        java.lang.object obj = rxSchedulerKt$scheduleTask$task$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = rxSchedulerKt$scheduleTask$task$1.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                if (p7beea252Var.isDisposed()) {
                    return kotlin.Unit.INSTANCE;
                }
                kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$2 rxSchedulerKt$scheduleTask$task$2 = new kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$2(runnable);
                rxSchedulerKt$scheduleTask$task$1.L$0 = coroutineobject;
                rxSchedulerKt$scheduleTask$task$1.label = 1;
                if (kotlinx.coroutines.InterruptibleKt.runInterruptible$default(null, rxSchedulerKt$scheduleTask$task$2, rxSchedulerKt$scheduleTask$task$1, 1, null) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                coroutineobject = (kotlin.coroutines.Coroutineobject) rxSchedulerKt$scheduleTask$task$1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (java.lang.Exception th) {
            kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(th, coroutineobject);
        }
        return kotlin.Unit.INSTANCE;
    }
}

