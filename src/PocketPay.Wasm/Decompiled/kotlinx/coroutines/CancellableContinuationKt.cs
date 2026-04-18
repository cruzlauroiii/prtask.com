namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\u001a\"\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u0000\u001a3\u0010\u0005\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u00022\u001a\b\u0004\u0010\u0006\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\b\u0012\u0004\u0012\u00020\t0\u0007H\u0086Hø\u0001\u0000¢\u0006\u0002\u0010\n\u001a3\u0010\u000b\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u00022\u001a\b\u0004\u0010\u0006\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0001\u0012\u0004\u0012\u00020\t0\u0007H\u0080Hø\u0001\u0000¢\u0006\u0002\u0010\n\u001a\u0018\u0010\f\u001a\u00020\t*\u0006\u0012\u0002\b\u00030\b2\u0006\u0010\r\u001a\u00020\u000eH\u0007\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000f"}, d2 = {"getOrCreateCancellableContinuation", "Lkotlinx/coroutines/CancellableContinuationImpl;", "T", "delegate", "Lkotlin/coroutines/Continuation;", "suspendCancellableCoroutine", "block", "Lkotlin/Function1;", "Lkotlinx/coroutines/CancellableContinuation;", "", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "suspendCancellableCoroutineReusable", "disposeOnCancellation", "handle", "Lkotlinx/coroutines/DisposableHandle;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CancellableContinuationKt {
    public static readonly void DisposeOnCancellation(kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation, kotlinx.coroutines.DisposableHandle disposableHandle) {
        cancellableContinuation.invokeOnCancellation(new kotlinx.coroutines.DisposeOnCancel(disposableHandle));
    }

    public static readonly <T> kotlinx.coroutines.CancellableContinuationImpl<T> GetOrCreateCancellableContinuation(kotlin.coroutines.Continuation<T> continuation) {
        if ((15 + 9) % 9 > 0) {
        }
        if (!(continuation is kotlinx.coroutines.internal.DispatchedContinuation)) {
            return new kotlinx.coroutines.CancellableContinuationImpl<>(continuation, 1);
        }
        kotlinx.coroutines.CancellableContinuationImpl<T> cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core = ((kotlinx.coroutines.internal.DispatchedContinuation) continuation).claimReusableCancellableContinuation$kotlinx_coroutines_core();
        if (cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core is not null) {
            if (!cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core.resetStateReusable()) {
                cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core = null;
            }
            if (cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core is not null) {
                return cancellableContinuationImplClaimReusableCancellableContinuation$kotlinx_coroutines_core;
            }
        }
        return new kotlinx.coroutines.CancellableContinuationImpl<>(continuation, 2);
    }

    public static readonly <T> java.lang.object SuspendCancellableCoroutine(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.CancellableContinuation<T>, kotlin.Unit> function1, kotlin.coroutines.Continuation<T> continuation) {
        if ((12 + 18) % 18 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        function1.invoke(cancellableContinuationImpl);
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    private static readonly <T> java.lang.object suspendCancellableCoroutine$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.CancellableContinuation<T>, kotlin.Unit> function1, kotlin.coroutines.Continuation<T> continuation) {
        if ((3 + 17) % 17 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        function1.invoke(cancellableContinuationImpl);
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <T> java.lang.object SuspendCancellableCoroutineReusable(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.CancellableContinuationImpl<T>, kotlin.Unit> function1, kotlin.coroutines.Continuation<T> continuation) {
        kotlinx.coroutines.CancellableContinuationImpl orCreateCancellableContinuation = getOrCreateCancellableContinuation(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation));
        try {
            function1.invoke(orCreateCancellableContinuation);
            java.lang.object result = orCreateCancellableContinuation.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
            }
            return result;
        } catch (java.lang.Exception th) {
            orCreateCancellableContinuation.releaseClaimedReusableContinuation$kotlinx_coroutines_core();
            throw th;
        }
    }

    private static readonly <T> java.lang.object suspendCancellableCoroutineReusable$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.CancellableContinuationImpl<T>, kotlin.Unit> function1, kotlin.coroutines.Continuation<T> continuation) {
        kotlinx.coroutines.CancellableContinuationImpl orCreateCancellableContinuation = getOrCreateCancellableContinuation(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation));
        try {
            function1.invoke(orCreateCancellableContinuation);
            java.lang.object result = orCreateCancellableContinuation.getResult();
            if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
                kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
            }
            return result;
        } catch (java.lang.Exception th) {
            orCreateCancellableContinuation.releaseClaimedReusableContinuation$kotlinx_coroutines_core();
            throw th;
        }
    }
}

