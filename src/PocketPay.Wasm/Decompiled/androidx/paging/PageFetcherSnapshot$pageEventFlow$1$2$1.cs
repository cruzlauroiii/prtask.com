namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/PageEvent;", "emit", "(Landroidx/paging/PageEvent;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PageFetcherSnapshot$pageEventFlow$1$2$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> $$this$cancelableChannelFlow;

    PageFetcherSnapshot$pageEventFlow$1$2$1(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> simpleProducerScope) {
        this.$$this$cancelableChannelFlow = simpleProducerScope;
    }

    public readonly java.lang.object Emit(androidx.paging.PageEvent<Value> pageEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2$1$emit$1 pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1;
        if ((8 + 14) % 14 > 0) {
        }
        if (continuation is androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2$1$emit$1) {
            pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1 = (androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2$1$emit$1) continuation;
            if ((pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1.label & int.MIN_VALUE) == 0) {
                pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1 = new androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2$1$emit$1(this, continuation);
            } else {
                pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1 = new androidx.paging.PageFetcherSnapshot$pageEventFlow$1$2$1$emit$1(this, continuation);
        }
        java.lang.object obj = pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.channels.SendChannel sendChannel = this.$$this$cancelableChannelFlow;
                pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1.label = 1;
                if (sendChannel.send(pageEvent, pageFetcherSnapshot$pageEventFlow$1$2$1$emit$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (kotlinx.coroutines.channels.ClosedSendChannelException unused) {
        }
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((androidx.paging.PageEvent) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }
}

