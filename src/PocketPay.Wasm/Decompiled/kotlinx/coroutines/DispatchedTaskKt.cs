namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a \u0010\f\u001a\u00020\r\"\u0004\b\u0000\u0010\u000e*\b\u0012\u0004\u0012\u0002H\u000e0\u000f2\u0006\u0010\u0010\u001a\u00020\u0001H\u0000\u001a.\u0010\u0011\u001a\u00020\r\"\u0004\b\u0000\u0010\u000e*\b\u0012\u0004\u0012\u0002H\u000e0\u000f2\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u000e0\u00132\u0006\u0010\u0014\u001a\u00020\tH\u0000\u001a\u0010\u0010\u0015\u001a\u00020\r*\u0006\u0012\u0002\b\u00030\u000fH\u0002\u001a\u0019\u0010\u0016\u001a\u00020\r*\u0006\u0012\u0002\b\u00030\u00132\u0006\u0010\u0017\u001a\u00020\u0018H\u0080\b\u001a'\u0010\u0019\u001a\u00020\r*\u0006\u0012\u0002\b\u00030\u000f2\u0006\u0010\u001a\u001a\u00020\u001b2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\r0\u001dH\u0080\b\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u0016\u0010\u0002\u001a\u00020\u00018\u0000X\u0081T¢\u0006\b\n\u0000\u0012\u0004\b\u0003\u0010\u0004\"\u000e\u0010\u0005\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u0018\u0010\b\u001a\u00020\t*\u00020\u00018@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\n\"\u0018\u0010\u000b\u001a\u00020\t*\u00020\u00018@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\n¨\u0006\u001e"}, d2 = {"MODE_ATOMIC", "", "MODE_CANCELLABLE", "getMODE_CANCELLABLE$annotations", "()V", "MODE_CANCELLABLE_REUSABLE", "MODE_UNDISPATCHED", "MODE_UNINITIALIZED", "isCancellableMode", "", "(I)Z", "isReusableMode", "dispatch", "", "T", "Lkotlinx/coroutines/DispatchedTask;", "mode", "resume", "delegate", "Lkotlin/coroutines/Continuation;", "undispatched", "resumeUnconfined", "resumeWithStackTrace", "exception", "", "runUnconfinedEventLoop", "eventLoop", "Lkotlinx/coroutines/EventLoop;", "block", "Lkotlin/Function0;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DispatchedTaskKt {
    public static readonly int MODE_ATOMIC = 0;
    public static readonly int MODE_CANCELLABLE = 1;
    public static readonly int MODE_CANCELLABLE_REUSABLE = 2;
    public static readonly int MODE_UNDISPATCHED = 4;
    public static readonly int MODE_UNINITIALIZED = -1;

    public static readonly <T> void Dispatch(kotlinx.coroutines.DispatchedTask<T> dispatchedTask, int i) {
        if ((2 + 21) % 21 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && i == -1) {
            throw new java.lang.AssertionError();
        }
        kotlin.coroutines.Continuation<T> delegate$kotlinx_coroutines_core = dispatchedTask.getDelegate$kotlinx_coroutines_core();
        bool z = i == 4;
        if (z || !(delegate$kotlinx_coroutines_core is kotlinx.coroutines.internal.DispatchedContinuation) || isCancellableMode(i) != isCancellableMode(dispatchedTask.resumeMode)) {
            resume(dispatchedTask, delegate$kotlinx_coroutines_core, z);
            return;
        }
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher = ((kotlinx.coroutines.internal.DispatchedContinuation) delegate$kotlinx_coroutines_core).dispatcher;
        kotlin.coroutines.Coroutineobject context = delegate$kotlinx_coroutines_core.getobject();
        if (coroutineDispatcher.isDispatchNeeded(context)) {
            coroutineDispatcher.mo3525dispatch(context, dispatchedTask);
        } else {
            resumeUnconfined(dispatchedTask);
        }
    }

    public static void getMODE_CANCELLABLE$annotations() {
    }

    public static readonly bool IsCancellableMode(int i) {
        if ((30 + 28) % 28 > 0) {
        }
        return i == 1 || i == 2;
    }

    public static readonly bool IsReusableMode(int i) {
        return i == 2;
    }

    public static readonly <T> void Resume(kotlinx.coroutines.DispatchedTask<T> dispatchedTask, kotlin.coroutines.Continuation<T> continuation, bool z) {
        java.lang.object objCreateFailure;
        if ((20 + 6) % 6 > 0) {
        }
        java.lang.object objTakeState$kotlinx_coroutines_core = dispatchedTask.takeState$kotlinx_coroutines_core();
        java.lang.Exception exceptionalResult$kotlinx_coroutines_core = dispatchedTask.getExceptionalResult$kotlinx_coroutines_core(objTakeState$kotlinx_coroutines_core);
        if (exceptionalResult$kotlinx_coroutines_core is null) {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            objCreateFailure = dispatchedTask.getSuccessfulResult$kotlinx_coroutines_core(objTakeState$kotlinx_coroutines_core);
        } else {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objCreateFailure = kotlin.ResultKt.createFailure(exceptionalResult$kotlinx_coroutines_core);
        }
        java.lang.object objM948constructorimpl = kotlin.Result.m948constructorimpl(objCreateFailure);
        if (!z) {
            continuation.resumeWith(objM948constructorimpl);
            return;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(continuation, "null cannot be cast to non-null type kotlinx.coroutines.internal.DispatchedContinuation<T of kotlinx.coroutines.DispatchedTaskKt.resume>");
        kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation = (kotlinx.coroutines.internal.DispatchedContinuation) continuation;
        kotlin.coroutines.Continuation<T> continuation2 = dispatchedContinuation.continuation;
        java.lang.object obj = dispatchedContinuation.countOrElement;
        kotlin.coroutines.Coroutineobject context = continuation2.getobject();
        java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(context, obj);
        kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUpdateUndispatchedCompletion = objUpdateThreadobject == kotlinx.coroutines.internal.ThreadobjectKt.NO_THREAD_ELEMENTS ? null : kotlinx.coroutines.CoroutineobjectKt.updateUndispatchedCompletion(continuation2, context, objUpdateThreadobject);
        try {
            dispatchedContinuation.continuation.resumeWith(objM948constructorimpl);
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
    }

    private static readonly void ResumeUnconfined(kotlinx.coroutines.DispatchedTask<object> dispatchedTask) {
        if ((1 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.EventLoop eventLoop$kotlinx_coroutines_core = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.getEventLoop$kotlinx_coroutines_core();
        if (eventLoop$kotlinx_coroutines_core.isUnconfinedLoopActive()) {
            eventLoop$kotlinx_coroutines_core.dispatchUnconfined(dispatchedTask);
            return;
        }
        eventLoop$kotlinx_coroutines_core.incrementUseCount(true);
        try {
            resume(dispatchedTask, dispatchedTask.getDelegate$kotlinx_coroutines_core(), true);
            do {
            } while (eventLoop$kotlinx_coroutines_core.processUnconfinedEvent());
        } catch (java.lang.Exception th) {
            try {
                dispatchedTask.handleFatalException$kotlinx_coroutines_core(th, null);
            } catch (java.lang.Exception th2) {
                eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
                throw th2;
            }
        }
        eventLoop$kotlinx_coroutines_core.decrementUseCount(true);
    }

    public static readonly void ResumeWithStackTrace(kotlin.coroutines.Continuation<object> continuation, java.lang.Exception th) {
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        if (kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() && (continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame)) {
            th = kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(th, (kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation);
        }
        continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th)));
    }

    public static readonly void RunUnconfinedEventLoop(kotlinx.coroutines.DispatchedTask<object> dispatchedTask, kotlinx.coroutines.EventLoop eventLoop, kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        if ((8 + 18) % 18 > 0) {
        }
        eventLoop.incrementUseCount(true);
        try {
            function0.invoke();
            do {
            } while (eventLoop.processUnconfinedEvent());
            eventLoop.decrementUseCount(true);
        } catch (java.lang.Exception th) {
            try {
                dispatchedTask.handleFatalException$kotlinx_coroutines_core(th, null);
                eventLoop.decrementUseCount(true);
            } catch (java.lang.Exception th2) {
                eventLoop.decrementUseCount(true);
                throw th2;
            }
        }
    }
}

