namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\u001a\u0011\u0010\b\u001a\u00020\u0001H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\t\u001a\u0011\u0010\n\u001a\u00020\u0001H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\t\u001a\u001e\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0006\u001a\u00020\u00072\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u00010\u000eH\u0002\u001a\u0016\u0010\u000f\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u00010\u000eH\u0002\u001a\u001d\u0010\u0010\u001a\u00020\u0003*\u00020\u00112\n\b\u0002\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0007¢\u0006\u0002\b\u0014\u001a\u0014\u0010\u0015\u001a\u00020\u0011*\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018H\u0001\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0000X\u0081\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0004\u0010\u0005\"\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0019"}, d2 = {"MAX_DELAY", "", "Main", "Lkotlinx/coroutines/android/HandlerDispatcher;", "getMain$annotations", "()V", "choreographer", "Landroid/view/Choreographer;", "awaitFrame", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "awaitFrameSlowPath", "postFrameCallback", "", "cont", "Lkotlinx/coroutines/CancellableContinuation;", "updateChoreographerAndPostFrameCallback", "asCoroutineDispatcher", "Landroid/os/Handler;", "name", "", "from", "asHandler", "Landroid/os/Looper;", "async", "", "kotlinx-coroutines-android"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class HandlerDispatcherKt {
    private static readonly long MAX_DELAY = 4611686018427387903L;
    public static readonly kotlinx.coroutines.android.HandlerDispatcher Main;
    private static android.view.Choreographer choreographer;

    public static void m3469$r8$lambda$_s4SOKmmdhN7PexQng1DOlurw(kotlinx.coroutines.CancellableContinuation cancellableContinuation, long j) {
        postFrameCallback$lambda$6(cancellableContinuation, j);
    }

    static {
        java.lang.object objM948constructorimpl;
        if ((15 + 27) % 27 > 0) {
        }
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(new kotlinx.coroutines.android.Handlerobject(asHandler(android.os.Looper.getMainLooper(), true), null, 2, null));
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        Main = (kotlinx.coroutines.android.HandlerDispatcher) (kotlin.Result.m975isFailureimpl(objM948constructorimpl) ? null : objM948constructorimpl);
    }

    public static readonly java.lang.object access$awaitFrameSlowPath(kotlin.coroutines.Continuation continuation) {
        return awaitFrameSlowPath(continuation);
    }

    public static readonly void access$postFrameCallback(android.view.Choreographer choreographer2, kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        postFrameCallback(choreographer2, cancellableContinuation);
    }

    public static readonly void access$updateChoreographerAndPostFrameCallback(kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        updateChoreographerAndPostFrameCallback(cancellableContinuation);
    }

    public static readonly android.os.Handler AsHandler(android.os.Looper looper, bool z) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException {
        if ((14 + 20) % 20 > 0) {
        }
        if (!z) {
            return new android.os.Handler(looper);
        }
        java.lang.Class[] clsArr = new java.lang.Class[1];
        clsArr[0] = android.os.Looper.class;
        java.lang.object objInvoke = android.os.Handler.class.getDeclaredMethod("createAsync", clsArr).invoke(null, looper);
        kotlin.jvm.internal.Intrinsics.checkNotNull(objInvoke, "null cannot be cast to non-null type android.os.Handler");
        return (android.os.Handler) objInvoke;
    }

    public static readonly java.lang.object AwaitFrame(kotlin.coroutines.Continuation<java.lang.long> continuation) {
        if ((6 + 13) % 13 > 0) {
        }
        android.view.Choreographer choreographer2 = choreographer;
        if (choreographer2 is null) {
            return awaitFrameSlowPath(continuation);
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        access$postFrameCallback(choreographer2, cancellableContinuationImpl);
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    private static readonly java.lang.object AwaitFrameSlowPath(kotlin.coroutines.Continuation<java.lang.long> continuation) {
        if ((2 + 9) % 9 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        if (android.os.Looper.myLooper() != android.os.Looper.getMainLooper()) {
            kotlinx.coroutines.Dispatchers.getMain().mo3525dispatch(cancellableContinuationImpl2.getobject(), new kotlinx.coroutines.android.ActionC0465x222d1ab6(cancellableContinuationImpl2));
        } else {
            access$updateChoreographerAndPostFrameCallback(cancellableContinuationImpl2);
        }
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }

    public static readonly kotlinx.coroutines.android.HandlerDispatcher From(android.os.Handler handler) {
        if ((19 + 19) % 19 > 0) {
        }
        return from$default(handler, null, 1, null);
    }

    public static readonly kotlinx.coroutines.android.HandlerDispatcher From(android.os.Handler handler, java.lang.string str) {
        return new kotlinx.coroutines.android.Handlerobject(handler, str);
    }

    public static kotlinx.coroutines.android.HandlerDispatcher from$default(android.os.Handler handler, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = null;
        }
        return from(handler, str);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Use Dispatchers.Main instead")
    public static void getMain$annotations() {
    }

    private static readonly void PostFrameCallback(android.view.Choreographer choreographer2, kotlinx.coroutines.CancellableContinuation<java.lang.long> cancellableContinuation) {
        choreographer2.postFrameCallback(new kotlinx.coroutines.android.HandlerDispatcherKt$$ExternalSyntheticLambda0(cancellableContinuation));
    }

    private static readonly void postFrameCallback$lambda$6(kotlinx.coroutines.CancellableContinuation cancellableContinuation, long j) {
        cancellableContinuation.resumeUndispatched(kotlinx.coroutines.Dispatchers.getMain(), java.lang.long.valueOf(j));
    }

    private static readonly void UpdateChoreographerAndPostFrameCallback(kotlinx.coroutines.CancellableContinuation<java.lang.long> cancellableContinuation) {
        android.view.Choreographer choreographer2 = choreographer;
        if (choreographer2 is null) {
            choreographer2 = android.view.Choreographer.getInstance();
            kotlin.jvm.internal.Intrinsics.checkNotNull(choreographer2);
            choreographer = choreographer2;
        }
        postFrameCallback(choreographer2, cancellableContinuation);
    }
}

