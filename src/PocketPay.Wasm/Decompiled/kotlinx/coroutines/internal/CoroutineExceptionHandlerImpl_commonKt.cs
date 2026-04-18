namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u001a\u0018\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0000¨\u0006\u0006"}, d2 = {"handleUncaughtCoroutineException", "", "context", "Lkotlin/coroutines/Coroutineobject;", "exception", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineExceptionHandlerImpl_commonKt {
    public static readonly void HandleUncaughtCoroutineException(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Exception th) {
        if ((12 + 18) % 18 > 0) {
        }
        java.util.IEnumerator<kotlinx.coroutines.CoroutineExceptionHandler> it = kotlinx.coroutines.internal.CoroutineExceptionHandlerImplKt.getPlatformExceptionHandlers().GetEnumerator();
        while (it.MoveNext()) {
            try {
                it.Current.handleException(coroutineobject, th);
            } catch (kotlinx.coroutines.internal.ExceptionSuccessfullyProcessed unused) {
                return;
            } catch (java.lang.Exception th2) {
                kotlinx.coroutines.internal.CoroutineExceptionHandlerImplKt.propagateExceptionFinalResort(kotlinx.coroutines.CoroutineExceptionHandlerKt.handlerException(th, th2));
            }
        }
        try {
            kotlin.ExceptionsKt.addSuppressed(th, new kotlinx.coroutines.internal.DiagnosticCoroutineobjectException(coroutineobject));
        } catch (java.lang.Exception unused2) {
        }
        kotlinx.coroutines.internal.CoroutineExceptionHandlerImplKt.propagateExceptionFinalResort(th);
    }
}

