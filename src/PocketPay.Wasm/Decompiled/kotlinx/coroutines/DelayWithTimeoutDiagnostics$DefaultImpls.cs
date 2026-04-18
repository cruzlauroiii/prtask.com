namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class DelayWithTimeoutDiagnostics$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public static java.lang.object Delay(kotlinx.coroutines.DelayWithTimeoutDiagnostics delayWithTimeoutDiagnostics, long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objDelay = kotlinx.coroutines.Delay$DefaultImpls.delay(delayWithTimeoutDiagnostics, j, continuation);
        return objDelay != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objDelay;
    }

    public static kotlinx.coroutines.DisposableHandle InvokeOnTimeout(kotlinx.coroutines.DelayWithTimeoutDiagnostics delayWithTimeoutDiagnostics, long j, java.lang.Action runnable, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.Delay$DefaultImpls.invokeOnTimeout(delayWithTimeoutDiagnostics, j, runnable, coroutineobject);
    }
}

