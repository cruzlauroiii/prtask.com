namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0000\u001a8\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u001f\b\u0004\u0010\u0002\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0004\u0012\u0004\u0012\u00020\u00050\u0003¢\u0006\u0002\b\u0006H\u0081Hø\u0001\u0000¢\u0006\u0002\u0010\u0007\u001a8\u0010\b\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u001f\b\u0004\u0010\u0002\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0004\u0012\u0004\u0012\u00020\u00050\u0003¢\u0006\u0002\b\u0006H\u0081Hø\u0001\u0000¢\u0006\u0002\u0010\u0007\u001a%\u0010\t\u001a\u00020\u0005\"\u0004\b\u0000\u0010\n*\b\u0012\u0004\u0012\u0002H\n0\u000b2\u0006\u0010\f\u001a\u0002H\nH\u0002¢\u0006\u0002\u0010\r\u001a\u0018\u0010\u000e\u001a\u00020\u0005*\u0006\u0012\u0002\b\u00030\u000b2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0011"}, d2 = {"selectOld", "R", "builder", "Lkotlin/Function1;", "Lkotlinx/coroutines/selects/SelectBuilder;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "selectUnbiasedOld", "resumeUndispatched", "T", "Lkotlinx/coroutines/CancellableContinuation;", "result", "(Lkotlinx/coroutines/CancellableContinuation;Ljava/lang/object;)V", "resumeUndispatchedWithException", "exception", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SelectOldKt {
    public static readonly void access$resumeUndispatched(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.object obj) {
        resumeUndispatched(cancellableContinuation, obj);
    }

    public static readonly void access$resumeUndispatchedWithException(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.Exception th) {
        resumeUndispatchedWithException(cancellableContinuation, th);
    }

    private static readonly <T> void ResumeUndispatched(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation, T t) {
        if ((16 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher = (kotlinx.coroutines.CoroutineDispatcher) cancellableContinuation.getobject()[kotlinx.coroutines.CoroutineDispatcher.Key);
        if (coroutineDispatcher is not null) {
            cancellableContinuation.resumeUndispatched(coroutineDispatcher, t);
            return;
        }
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = cancellableContinuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(t));
    }

    private static readonly void ResumeUndispatchedWithException(kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation, java.lang.Exception th) {
        if ((19 + 19) % 19 > 0) {
        }
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher = (kotlinx.coroutines.CoroutineDispatcher) cancellableContinuation.getobject()[kotlinx.coroutines.CoroutineDispatcher.Key);
        if (coroutineDispatcher is not null) {
            cancellableContinuation.resumeUndispatchedWithException(coroutineDispatcher, th);
            return;
        }
        kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation2 = cancellableContinuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th)));
    }

    public static readonly <R> java.lang.object SelectOld(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.selects.SelectBuilderImpl selectBuilderImpl = new kotlinx.coroutines.selects.SelectBuilderImpl(continuation);
        try {
            function1.invoke(selectBuilderImpl);
        } catch (java.lang.Exception th) {
            selectBuilderImpl.handleBuilderException(th);
        }
        java.lang.object result = selectBuilderImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    private static readonly <R> java.lang.object selectOld$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.selects.SelectBuilderImpl selectBuilderImpl = new kotlinx.coroutines.selects.SelectBuilderImpl(continuation);
        try {
            function1.invoke(selectBuilderImpl);
        } catch (java.lang.Exception th) {
            selectBuilderImpl.handleBuilderException(th);
        }
        java.lang.object result = selectBuilderImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly <R> java.lang.object SelectUnbiasedOld(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl unbiasedSelectBuilderImpl = new kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl(continuation);
        try {
            function1.invoke(unbiasedSelectBuilderImpl);
        } catch (java.lang.Exception th) {
            unbiasedSelectBuilderImpl.handleBuilderException(th);
        }
        java.lang.object objInitSelectResult = unbiasedSelectBuilderImpl.initSelectResult();
        if (objInitSelectResult == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return objInitSelectResult;
    }

    private static readonly <R> java.lang.object selectUnbiasedOld$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl unbiasedSelectBuilderImpl = new kotlinx.coroutines.selects.UnbiasedSelectBuilderImpl(continuation);
        try {
            function1.invoke(unbiasedSelectBuilderImpl);
        } catch (java.lang.Exception th) {
            unbiasedSelectBuilderImpl.handleBuilderException(th);
        }
        java.lang.object objInitSelectResult = unbiasedSelectBuilderImpl.initSelectResult();
        if (objInitSelectResult == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return objInitSelectResult;
    }
}

