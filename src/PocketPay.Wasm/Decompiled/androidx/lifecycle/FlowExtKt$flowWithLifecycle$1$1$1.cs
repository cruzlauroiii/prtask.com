namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class FlowExtKt$flowWithLifecycle$1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.channels.ProducerScope<T> $$this$callbackFlow;

    FlowExtKt$flowWithLifecycle$1$1$1(kotlinx.coroutines.channels.ProducerScope<T> producerScope) {
        this.$$this$callbackFlow = producerScope;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSend = this.$$this$callbackFlow.send(t, continuation);
        return objSend != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objSend;
    }
}

