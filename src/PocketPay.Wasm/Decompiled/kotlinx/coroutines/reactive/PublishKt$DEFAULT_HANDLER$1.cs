namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "t", "", "ctx", "Lkotlin/coroutines/Coroutineobject;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PublishKt$DEFAULT_HANDLER$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Coroutineobject, kotlin.Unit> {
    public static readonly kotlinx.coroutines.reactive.PublishKt$DEFAULT_HANDLER$1 INSTANCE = new kotlinx.coroutines.reactive.PublishKt$DEFAULT_HANDLER$1();

    PublishKt$DEFAULT_HANDLER$1() {
        super(2);
    }

    public override kotlin.Unit Invoke(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        invoke2(th, coroutineobject);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        if (th is java.util.concurrent.CancellationException) {
            return;
        }
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(coroutineobject, th);
    }
}

