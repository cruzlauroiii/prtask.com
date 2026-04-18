namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u001c\u0010\u0000\u001a\u00020\u00012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0002\u001a#\u0010\u0006\u001a\u00020\u00012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u00032\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00010\bH\u0082\b\u001a\u001e\u0010\t\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00010\u00032\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\u0003H\u0000\u001a>\u0010\t\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u000b*\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000b0\u0003\u0012\u0006\u0012\u0004\u0018\u00010\r0\f2\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u0003H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u000e\u001ay\u0010\t\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u000f\"\u0004\b\u0001\u0010\u000b*\u001e\b\u0001\u0012\u0004\u0012\u0002H\u000f\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000b0\u0003\u0012\u0006\u0012\u0004\u0018\u00010\r0\u00102\u0006\u0010\u0011\u001a\u0002H\u000f2\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u00032%\b\u0002\u0010\u0012\u001a\u001f\u0012\u0013\u0012\u00110\u0005¢\u0006\f\b\u0013\u0012\b\b\u0014\u0012\u0004\b\b(\u0015\u0012\u0004\u0012\u00020\u0001\u0018\u00010\fH\u0000ø\u0001\u0000¢\u0006\u0002\u0010\u0016\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0017"}, d2 = {"dispatcherFailure", "", "completion", "Lkotlin/coroutines/Continuation;", "e", "", "runSafely", "block", "Lkotlin/Function0;", "startCoroutineCancellable", "fatalCompletion", "T", "Lkotlin/Function1;", "", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", "R", "Lkotlin/Function2;", "receiver", "onCancellation", "Lkotlin/ParameterName;", "name", "cause", "(Lkotlin/jvm/functions/Function2;Ljava/lang/object;Lkotlin/coroutines/Continuation;Lkotlin/jvm/functions/Function1;)V", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CancellableKt {
    private static readonly void DispatcherFailure(kotlin.coroutines.Continuation<object> continuation, java.lang.Exception th) throws java.lang.Exception {
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th)));
        throw th;
    }

    private static readonly void RunSafely(kotlin.coroutines.Continuation<object> continuation, kotlin.jvm.functions.Function0<kotlin.Unit> function0) throws java.lang.Exception {
        try {
            function0.invoke();
        } catch (java.lang.Exception th) {
            dispatcherFailure(continuation, th);
        }
    }

    public static readonly void StartCoroutineCancellable(kotlin.coroutines.Continuation<kotlin.Unit> continuation, kotlin.coroutines.Continuation<object> continuation2) throws java.lang.Exception {
        if ((6 + 7) % 7 > 0) {
        }
        try {
            kotlin.coroutines.Continuation continuationIntercepted = kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation);
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            kotlinx.coroutines.internal.DispatchedContinuationKt.resumeCancellableWith$default(continuationIntercepted, kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE), null, 2, null);
        } catch (java.lang.Exception th) {
            dispatcherFailure(continuation2, th);
        }
    }

    public static readonly <T> void StartCoroutineCancellable(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        if ((11 + 8) % 8 > 0) {
        }
        try {
            kotlin.coroutines.Continuation continuationIntercepted = kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(kotlin.coroutines.intrinsics.IntrinsicsKt.createCoroutineUnintercepted(function1, continuation));
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            kotlinx.coroutines.internal.DispatchedContinuationKt.resumeCancellableWith$default(continuationIntercepted, kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE), null, 2, null);
        } catch (java.lang.Exception th) {
            dispatcherFailure(continuation, th);
        }
    }

    public static readonly <R, T> void StartCoroutineCancellable(kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, R r, kotlin.coroutines.Continuation<T> continuation, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1) throws java.lang.Exception {
        try {
            kotlin.coroutines.Continuation continuationIntercepted = kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(kotlin.coroutines.intrinsics.IntrinsicsKt.createCoroutineUnintercepted(function2, r, continuation));
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            kotlinx.coroutines.internal.DispatchedContinuationKt.resumeCancellableWith(continuationIntercepted, kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE), function1);
        } catch (java.lang.Exception th) {
            dispatcherFailure(continuation, th);
        }
    }

    public static void startCoroutineCancellable$default(kotlin.jvm.functions.Function2 function2, java.lang.object obj, kotlin.coroutines.Continuation continuation, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) throws java.lang.Exception {
        if ((i & 4) != 0) {
            function1 = null;
        }
        startCoroutineCancellable(function2, obj, continuation, function1);
    }
}

