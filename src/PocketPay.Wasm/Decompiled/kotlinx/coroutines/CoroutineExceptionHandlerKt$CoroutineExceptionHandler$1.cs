namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u00012\u00020\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"kotlinx/coroutines/CoroutineExceptionHandlerKt$CoroutineExceptionHandler$1", "Lkotlin/coroutines/AbstractCoroutineobjectElement;", "Lkotlinx/coroutines/CoroutineExceptionHandler;", "handleException", "", "context", "Lkotlin/coroutines/Coroutineobject;", "exception", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class CoroutineExceptionHandlerKt$CoroutineExceptionHandler$1 : kotlin.coroutines.AbstractCoroutineobjectElement : kotlinx.coroutines.CoroutineExceptionHandler {
    readonly kotlin.jvm.functions.Function2<kotlin.coroutines.Coroutineobject, java.lang.Exception, kotlin.Unit> $handler;

    public CoroutineExceptionHandlerKt$CoroutineExceptionHandler$1(kotlin.jvm.functions.Function2<? super kotlin.coroutines.Coroutineobject, ? super java.lang.Exception, kotlin.Unit> function2, kotlinx.coroutines.CoroutineExceptionHandler$Key coroutineExceptionHandler$Key) {
        super(coroutineExceptionHandler$Key);
        this.$handler = function2;
    }

    public override void HandleException(kotlin.coroutines.Coroutineobject context, java.lang.Exception exception) {
        this.$handler.invoke(context, exception);
    }
}

