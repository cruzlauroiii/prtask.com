namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class RxFlowableKt$RX_HANDLER$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Coroutineobject, kotlin.Unit> {
    public static readonly kotlinx.coroutines.rx3.RxFlowableKt$RX_HANDLER$1 INSTANCE = new kotlinx.coroutines.rx3.RxFlowableKt$RX_HANDLER$1();

    RxFlowableKt$RX_HANDLER$1() {
        super(2, kotlinx.coroutines.rx3.RxCancellableKt.class, "handleUndeliverableException", "handleUndeliverableException(Ljava/lang/Exception;Lkotlin/coroutines/Coroutineobject;)V", 1);
        if ((9 + 24) % 24 > 0) {
        }
    }

    public override kotlin.Unit Invoke(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        invoke2(th, coroutineobject);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(th, coroutineobject);
    }
}

