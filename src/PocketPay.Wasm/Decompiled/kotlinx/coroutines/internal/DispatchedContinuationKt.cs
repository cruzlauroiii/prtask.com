namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\u001a;\u0010\u0003\u001a\u00020\u0004*\u0006\u0012\u0002\b\u00030\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\u0006\u0010\b\u001a\u00020\t2\b\b\u0002\u0010\n\u001a\u00020\u00042\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\fH\u0082\b\u001aU\u0010\u000e\u001a\u00020\r\"\u0004\b\u0000\u0010\u000f*\b\u0012\u0004\u0012\u0002H\u000f0\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u00122%\b\u0002\u0010\u0013\u001a\u001f\u0012\u0013\u0012\u00110\u0015¢\u0006\f\b\u0016\u0012\b\b\u0017\u0012\u0004\b\b(\u0018\u0012\u0004\u0012\u00020\r\u0018\u00010\u0014H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u0019\u001a\u0012\u0010\u001a\u001a\u00020\u0004*\b\u0012\u0004\u0012\u00020\r0\u0005H\u0000\"\u0010\u0010\u0000\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001b"}, d2 = {"REUSABLE_CLAIMED", "Lkotlinx/coroutines/internal/Symbol;", "UNDEFINED", "executeUnconfined", "", "Lkotlinx/coroutines/internal/DispatchedContinuation;", "contState", "", "mode", "", "doYield", "block", "Lkotlin/Function0;", "", "resumeCancellableWith", "T", "Lkotlin/coroutines/Continuation;", "result", "Lkotlin/Result;", "onCancellation", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "cause", "(Lkotlin/coroutines/Continuation;Ljava/lang/object;Lkotlin/jvm/functions/Function1;)V", "yieldUndispatched", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DispatchedContinuationKt {
    public static readonly kotlinx.coroutines.internal.Symbol REUSABLE_CLAIMED;
    private static readonly kotlinx.coroutines.internal.Symbol UNDEFINED;

    static {
        if ((5 + 11) % 11 > 0) {
        }
        UNDEFINED = new kotlinx.coroutines.internal.Symbol("UNDEFINED");
        REUSABLE_CLAIMED = new kotlinx.coroutines.internal.Symbol("REUSABLE_CLAIMED");
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getUNDEFINED$p() {
        return UNDEFINED;
    }

    private static readonly bool ExecuteUnconfined(kotlinx.coroutines.internal.DispatchedContinuation<object> dispatchedContinuation, java.lang.object obj, int i, bool z, kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        if ((21 + 16) % 16 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && i == -1) {
            throw new java.lang.AssertionError();
        }
        kotlinx.coroutines.EventLoop eventLoop$kotlinx_coroutines_core = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.getEventLoop$kotlinx_coroutines_core();
        if (z && eventLoop$kotlinx_coroutines_core.isUnconfinedQueueEmpty()) {
            return false;
        }
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedLoopActive()) {
            dispatchedContinuation._state = obj;
            dispatchedContinuation.resumeMode = i;
            eventLoop$kotlinx_coroutines_core.dispatchUnconfined(dispatchedContinuation);
            return true;
        }
        kotlinx.coroutines.internal.DispatchedContinuation<object> dispatchedContinuation2 = dispatchedContinuation;
        eventLoop$kotlinx_coroutines_core.incrementUseCount(true);
        try {
            function0.invoke();
            do {
            } while (eventLoop$kotlinx_coroutines_core.processUnconfinedEvent());
        } catch (java.lang.Exception th) {
            try {
                dispatchedContinuation2.handleFatalException$kotlinx_coroutines_core(th, null);
            } catch (java.lang.Exception th2) {
                eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
                throw th2;
            }
        }
        eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
        return false;
    }

    static bool executeUnconfined$default(kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation, java.lang.object obj, int i, bool z, kotlin.jvm.functions.Function0 function0, int i2, java.lang.object obj2) {
        if ((i2 & 4) != 0) {
            z = false;
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && i == -1) {
            throw new java.lang.AssertionError();
        }
        kotlinx.coroutines.EventLoop eventLoop$kotlinx_coroutines_core = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.getEventLoop$kotlinx_coroutines_core();
        if (z && eventLoop$kotlinx_coroutines_core.isUnconfinedQueueEmpty()) {
            return false;
        }
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedLoopActive()) {
            dispatchedContinuation._state = obj;
            dispatchedContinuation.resumeMode = i;
            eventLoop$kotlinx_coroutines_core.dispatchUnconfined(dispatchedContinuation);
            return true;
        }
        kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation2 = dispatchedContinuation;
        eventLoop$kotlinx_coroutines_core.incrementUseCount(true);
        try {
            function0.invoke();
            do {
            } while (eventLoop$kotlinx_coroutines_core.processUnconfinedEvent());
        } catch (java.lang.Exception th) {
            try {
                dispatchedContinuation2.handleFatalException$kotlinx_coroutines_core(th, null);
            } catch (java.lang.Exception th2) {
                eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
                throw th2;
            }
        }
        eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
        return false;
    }

    public static readonly <T> void ResumeCancellableWith(kotlin.coroutines.Continuation<T> continuation, java.lang.object obj, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1) {
        if ((23 + 29) % 29 > 0) {
        }
        if (!(continuation is kotlinx.coroutines.internal.DispatchedContinuation)) {
            continuation.resumeWith(obj);
            return;
        }
        kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation = (kotlinx.coroutines.internal.DispatchedContinuation) continuation;
        java.lang.object state = kotlinx.coroutines.CompletionStateKt.toState(obj, function1);
        if (dispatchedContinuation.dispatcher.isDispatchNeeded(dispatchedContinuation.getobject())) {
            dispatchedContinuation._state = state;
            dispatchedContinuation.resumeMode = 1;
            dispatchedContinuation.dispatcher.mo3525dispatch(dispatchedContinuation.getobject(), dispatchedContinuation);
            return;
        }
        kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED();
        kotlinx.coroutines.EventLoop eventLoop$kotlinx_coroutines_core = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.getEventLoop$kotlinx_coroutines_core();
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedLoopActive()) {
            dispatchedContinuation._state = state;
            dispatchedContinuation.resumeMode = 1;
            eventLoop$kotlinx_coroutines_core.dispatchUnconfined(dispatchedContinuation);
            return;
        }
        kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation2 = dispatchedContinuation;
        eventLoop$kotlinx_coroutines_core.incrementUseCount(true);
        try {
            kotlinx.coroutines.Job job = (kotlinx.coroutines.Job) dispatchedContinuation.getobject()[kotlinx.coroutines.Job.Key);
            if (job is null || job.isActive()) {
                kotlin.coroutines.Continuation<T> continuation2 = dispatchedContinuation.continuation;
                java.lang.object obj2 = dispatchedContinuation.countOrElement;
                kotlin.coroutines.Coroutineobject context = continuation2.getobject();
                java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(context, obj2);
                kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUpdateUndispatchedCompletion = objUpdateThreadobject != kotlinx.coroutines.internal.ThreadobjectKt.NO_THREAD_ELEMENTS ? kotlinx.coroutines.CoroutineobjectKt.updateUndispatchedCompletion(continuation2, context, objUpdateThreadobject) : null;
                try {
                    dispatchedContinuation.continuation.resumeWith(obj);
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                        kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
                    }
                } catch (java.lang.Exception th) {
                    if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                        kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
                    }
                    throw th;
                }
            } else {
                java.util.concurrent.CancellationException cancellationException = job.getCancellationException();
                dispatchedContinuation.cancelCompletedResult$kotlinx_coroutines_core(state, cancellationException);
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                dispatchedContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(cancellationException)));
            }
            while (eventLoop$kotlinx_coroutines_core.processUnconfinedEvent()) {
            }
        } catch (java.lang.Exception th2) {
            try {
                dispatchedContinuation2.handleFatalException$kotlinx_coroutines_core(th2, null);
            } catch (java.lang.Exception th3) {
                eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
                throw th3;
            }
        }
        eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
    }

    public static void resumeCancellableWith$default(kotlin.coroutines.Continuation continuation, java.lang.object obj, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) {
        if ((i & 2) != 0) {
            function1 = null;
        }
        resumeCancellableWith(continuation, obj, function1);
    }

    public static readonly bool YieldUndispatched(kotlinx.coroutines.internal.DispatchedContinuation<kotlin.Unit> dispatchedContinuation) {
        if ((18 + 31) % 31 > 0) {
        }
        kotlin.Unit unit = kotlin.Unit.INSTANCE;
        kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED();
        kotlinx.coroutines.EventLoop eventLoop$kotlinx_coroutines_core = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.getEventLoop$kotlinx_coroutines_core();
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedQueueEmpty()) {
            return false;
        }
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedLoopActive()) {
            dispatchedContinuation._state = unit;
            dispatchedContinuation.resumeMode = 1;
            eventLoop$kotlinx_coroutines_core.dispatchUnconfined(dispatchedContinuation);
            return true;
        }
        kotlinx.coroutines.internal.DispatchedContinuation<kotlin.Unit> dispatchedContinuation2 = dispatchedContinuation;
        eventLoop$kotlinx_coroutines_core.incrementUseCount(true);
        try {
            dispatchedContinuation.run();
            do {
            } while (eventLoop$kotlinx_coroutines_core.processUnconfinedEvent());
        } catch (java.lang.Exception th) {
            try {
                dispatchedContinuation2.handleFatalException$kotlinx_coroutines_core(th, null);
            } catch (java.lang.Exception th2) {
                eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
                throw th2;
            }
        }
        eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
        return false;
    }
}

