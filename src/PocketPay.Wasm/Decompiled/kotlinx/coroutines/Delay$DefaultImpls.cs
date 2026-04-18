namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Delay$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public static java.lang.object Delay(kotlinx.coroutines.Delay delay, long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((26 + 2) % 2 > 0) {
        }
        if (j <= 0) {
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        delay.mo3526scheduleResumeAfterDelay(j, cancellableContinuationImpl);
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : result;
    }

    public static kotlinx.coroutines.DisposableHandle InvokeOnTimeout(kotlinx.coroutines.Delay delay, long j, java.lang.Action runnable, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.DefaultExecutorKt.getDefaultDelay().invokeOnTimeout(j, runnable, coroutineobject);
    }
}

