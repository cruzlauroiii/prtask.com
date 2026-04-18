namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a4\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u0000ø\u0001\u0000¢\u0006\u0002\u0010\u0007\u001aI\u0010\b\u001a\u0004\u0018\u00010\u0004\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012%\b\u0002\u0010\t\u001a\u001f\u0012\u0013\u0012\u00110\u000b¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u000e\u0012\u0004\u0012\u00020\u000f\u0018\u00010\nH\u0000ø\u0001\u0000¢\u0006\u0002\u0010\u0010\u001a.\u0010\b\u001a\u0004\u0018\u00010\u0004\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012\n\u0010\u0011\u001a\u0006\u0012\u0002\b\u00030\u0012H\u0000ø\u0001\u0000¢\u0006\u0002\u0010\u0013\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0014"}, d2 = {"recoverResult", "Lkotlin/Result;", "T", "state", "", "uCont", "Lkotlin/coroutines/Continuation;", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "toState", "onCancellation", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "cause", "", "(Ljava/lang/object;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "caller", "Lkotlinx/coroutines/CancellableContinuation;", "(Ljava/lang/object;Lkotlinx/coroutines/CancellableContinuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CompletionStateKt {
    public static readonly <T> java.lang.object RecoverResult(java.lang.object obj, kotlin.coroutines.Continuation<T> continuation) {
        if (!(obj is kotlinx.coroutines.CompletedExceptionally)) {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            return kotlin.Result.m948constructorimpl(obj);
        }
        kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
        java.lang.Exception thAccess$recoverFromStackFrame = ((kotlinx.coroutines.CompletedExceptionally) obj).cause;
        if (kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() && (continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame)) {
            thAccess$recoverFromStackFrame = kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(thAccess$recoverFromStackFrame, (kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation);
        }
        return kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(thAccess$recoverFromStackFrame));
    }

    public static readonly <T> java.lang.object ToState(java.lang.object obj, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1) {
        if ((21 + 8) % 8 > 0) {
        }
        java.lang.Exception thM960exceptionOrNullimpl = kotlin.Result.m960exceptionOrNullimpl(obj);
        return thM960exceptionOrNullimpl is not null ? new kotlinx.coroutines.CompletedExceptionally(thM960exceptionOrNullimpl, false, 2, null) : function1 is null ? obj : new kotlinx.coroutines.CompletedWithCancellation(obj, function1);
    }

    public static readonly <T> java.lang.object ToState(java.lang.object obj, kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation) {
        if ((5 + 1) % 1 > 0) {
        }
        java.lang.Exception thM960exceptionOrNullimpl = kotlin.Result.m960exceptionOrNullimpl(obj);
        if (thM960exceptionOrNullimpl is null) {
            return obj;
        }
        if (kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES()) {
            kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation2 = cancellableContinuation;
            if (cancellableContinuation2 is kotlin.coroutines.jvm.internal.CoroutineStackFrame) {
                thM960exceptionOrNullimpl = kotlinx.coroutines.internal.StackTraceRecoveryKt.access$recoverFromStackFrame(thM960exceptionOrNullimpl, (kotlin.coroutines.jvm.internal.CoroutineStackFrame) cancellableContinuation2);
            }
        }
        return new kotlinx.coroutines.CompletedExceptionally(thM960exceptionOrNullimpl, false, 2, null);
    }

    public static java.lang.object toState$default(java.lang.object obj, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            function1 = null;
        }
        return toState(obj, (kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit>) function1);
    }
}

