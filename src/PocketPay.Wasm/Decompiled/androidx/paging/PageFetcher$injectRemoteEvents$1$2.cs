namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/PageEvent;", "emit", "(Landroidx/paging/PageEvent;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PageFetcher$injectRemoteEvents$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> $$this$cancelableChannelFlow;

    PageFetcher$injectRemoteEvents$1$2(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> simpleProducerScope) {
        this.$$this$cancelableChannelFlow = simpleProducerScope;
    }

    public readonly java.lang.object Emit(androidx.paging.PageEvent<Value> pageEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSend = this.$$this$cancelableChannelFlow.send(pageEvent, continuation);
        return objSend != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objSend;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((androidx.paging.PageEvent) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }
}

