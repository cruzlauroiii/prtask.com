namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0018\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0000¨\u0006\u0006"}, d2 = {"handleUndeliverableException", "", "cause", "", "context", "Lkotlin/coroutines/Coroutineobject;", "kotlinx-coroutines-rx3"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RxCancellableKt {
    public static readonly void HandleUndeliverableException(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        if (th is java.util.concurrent.CancellationException) {
            return;
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
        } catch (java.lang.Exception th2) {
            kotlin.ExceptionsKt.addSuppressed(th, th2);
            kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(coroutineobject, th);
        }
    }
}

