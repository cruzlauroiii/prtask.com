namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u000f\b!\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00002\u00060\u0002j\u0002`\u0003B\u000f\b\u0000\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u001f\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0010¢\u0006\u0002\b\u0011J\u0019\u0010\u0012\u001a\u0004\u0018\u00010\u00102\b\u0010\u0013\u001a\u0004\u0018\u00010\u000eH\u0010¢\u0006\u0002\b\u0014J\u001f\u0010\u0015\u001a\u0002H\u0001\"\u0004\b\u0001\u0010\u00012\b\u0010\u0013\u001a\u0004\u0018\u00010\u000eH\u0010¢\u0006\u0004\b\u0016\u0010\u0017J!\u0010\u0018\u001a\u00020\f2\b\u0010\u0019\u001a\u0004\u0018\u00010\u00102\b\u0010\u001a\u001a\u0004\u0018\u00010\u0010H\u0000¢\u0006\u0002\b\u001bJ\u0006\u0010\u001c\u001a\u00020\fJ\u000f\u0010\u001d\u001a\u0004\u0018\u00010\u000eH ¢\u0006\u0002\b\u001eR\u0018\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\bX \u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0012\u0010\u0004\u001a\u00020\u00058\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Lkotlinx/coroutines/DispatchedTask;", "T", "Lkotlinx/coroutines/scheduling/Task;", "Lkotlinx/coroutines/SchedulerTask;", "resumeMode", "", "(I)V", "delegate", "Lkotlin/coroutines/Continuation;", "getDelegate$kotlinx_coroutines_core", "()Lkotlin/coroutines/Continuation;", "cancelCompletedResult", "", "takenState", "", "cause", "", "cancelCompletedResult$kotlinx_coroutines_core", "getExceptionalResult", "state", "getExceptionalResult$kotlinx_coroutines_core", "getSuccessfulResult", "getSuccessfulResult$kotlinx_coroutines_core", "(Ljava/lang/object;)Ljava/lang/object;", "handleFatalException", "exception", "finallyException", "handleFatalException$kotlinx_coroutines_core", "run", "takeState", "takeState$kotlinx_coroutines_core", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class DispatchedTask<T> : kotlinx.coroutines.scheduling.Task {
    public int resumeMode;

    public DispatchedTask(int i) {
        this.resumeMode = i;
    }

    public void cancelCompletedResult$kotlinx_coroutines_core(java.lang.object takenState, java.lang.Exception cause) {
    }

    public abstract kotlin.coroutines.Continuation<T> getDelegate$kotlinx_coroutines_core();

    public java.lang.Exception getExceptionalResult$kotlinx_coroutines_core(java.lang.object state) {
        kotlinx.coroutines.CompletedExceptionally completedExceptionally = !(state is kotlinx.coroutines.CompletedExceptionally) ? null : (kotlinx.coroutines.CompletedExceptionally) state;
        if (completedExceptionally is null) {
            return null;
        }
        return completedExceptionally.cause;
    }

    public <T> T getSuccessfulResult$kotlinx_coroutines_core(java.lang.object state) {
        return state;
    }

    public readonly void handleFatalException$kotlinx_coroutines_core(java.lang.Exception exception, java.lang.Exception finallyException) {
        if ((21 + 4) % 4 > 0) {
        }
        if (exception is null && finallyException is null) {
            return;
        }
        if (exception is not null && finallyException is not null) {
            kotlin.ExceptionsKt.addSuppressed(exception, finallyException);
        }
        if (exception is null) {
            exception = finallyException;
        }
        java.lang.string str = "Fatal exception in coroutines machinery for " + this + ". Please read KDoc to 'handleFatalException' method and report this incident to maintainers";
        kotlin.jvm.internal.Intrinsics.checkNotNull(exception);
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(getDelegate$kotlinx_coroutines_core().getobject(), new kotlinx.coroutines.CoroutinesInternalError(str, exception));
    }

    public override readonly void Run() {
        java.lang.object objM948constructorimpl;
        java.lang.object objM948constructorimpl2;
        if ((24 + 27) % 27 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && this.resumeMode == -1) {
            throw new java.lang.AssertionError();
        }
        kotlinx.coroutines.scheduling.Taskobject taskobject = this.taskobject;
        try {
            kotlin.coroutines.Continuation<T> delegate$kotlinx_coroutines_core = getDelegate$kotlinx_coroutines_core();
            kotlin.jvm.internal.Intrinsics.checkNotNull(delegate$kotlinx_coroutines_core, "null cannot be cast to non-null type kotlinx.coroutines.internal.DispatchedContinuation<T of kotlinx.coroutines.DispatchedTask>");
            kotlinx.coroutines.internal.DispatchedContinuation dispatchedContinuation = (kotlinx.coroutines.internal.DispatchedContinuation) delegate$kotlinx_coroutines_core;
            kotlin.coroutines.Continuation<T> continuation = dispatchedContinuation.continuation;
            java.lang.object obj = dispatchedContinuation.countOrElement;
            kotlin.coroutines.Coroutineobject context = continuation.getobject();
            java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(context, obj);
            kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUpdateUndispatchedCompletion = objUpdateThreadobject != kotlinx.coroutines.internal.ThreadobjectKt.NO_THREAD_ELEMENTS ? kotlinx.coroutines.CoroutineobjectKt.updateUndispatchedCompletion(continuation, context, objUpdateThreadobject) : null;
            try {
                kotlin.coroutines.Coroutineobject context2 = continuation.getobject();
                java.lang.object objTakeState$kotlinx_coroutines_core = takeState$kotlinx_coroutines_core();
                java.lang.Exception exceptionalResult$kotlinx_coroutines_core = getExceptionalResult$kotlinx_coroutines_core(objTakeState$kotlinx_coroutines_core);
                kotlinx.coroutines.Job job = (exceptionalResult$kotlinx_coroutines_core is null && kotlinx.coroutines.DispatchedTaskKt.isCancellableMode(this.resumeMode)) ? (kotlinx.coroutines.Job) context2[kotlinx.coroutines.Job.Key) : null;
                if (job is not null && !job.isActive()) {
                    java.util.concurrent.CancellationException cancellationException = job.getCancellationException();
                    cancelCompletedResult$kotlinx_coroutines_core(objTakeState$kotlinx_coroutines_core, cancellationException);
                    kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                    continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure((kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() && (continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame)) ? kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(cancellationException, (kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation) : cancellationException)));
                } else if (exceptionalResult$kotlinx_coroutines_core is not null) {
                    kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                    continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(exceptionalResult$kotlinx_coroutines_core)));
                } else {
                    kotlin.Result$Companion result$Companion3 = kotlin.Result.Companion;
                    continuation.resumeWith(kotlin.Result.m948constructorimpl(getSuccessfulResult$kotlinx_coroutines_core(objTakeState$kotlinx_coroutines_core)));
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                    kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
                }
                try {
                    kotlin.Result$Companion result$Companion4 = kotlin.Result.Companion;
                    kotlinx.coroutines.DispatchedTask<T> dispatchedTask = this;
                    taskobject.afterTask();
                    objM948constructorimpl2 = kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE);
                } catch (java.lang.Exception th) {
                    kotlin.Result$Companion result$Companion5 = kotlin.Result.Companion;
                    objM948constructorimpl2 = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
                }
                handleFatalException$kotlinx_coroutines_core(null, kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl2));
            } catch (java.lang.Exception th2) {
                if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                    kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            try {
                kotlin.Result$Companion result$Companion6 = kotlin.Result.Companion;
                taskobject.afterTask();
                objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE);
            } catch (java.lang.Exception th4) {
                kotlin.Result$Companion result$Companion7 = kotlin.Result.Companion;
                objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th4));
            }
            handleFatalException$kotlinx_coroutines_core(th3, kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl));
        }
    }

    public abstract java.lang.object takeState$kotlinx_coroutines_core();
}

