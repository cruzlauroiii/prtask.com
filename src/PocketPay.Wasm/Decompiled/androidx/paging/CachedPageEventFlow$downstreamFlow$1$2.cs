namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0014\u0010\u0004\u001a\u0010\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0006\u0018\u00010\u0005H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "T", "", "indexedValue", "Lkotlin/collections/IndexedValue;", "Landroidx/paging/PageEvent;", "emit", "(Lkotlin/collections/IndexedValue;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CachedPageEventFlow$downstreamFlow$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<androidx.paging.PageEvent<T>> $$this$flow;
    readonly kotlin.jvm.internal.Ref$IntRef $maxEventIndex;

    CachedPageEventFlow$downstreamFlow$1$2(kotlin.jvm.internal.Ref$IntRef ref$IntRef, kotlinx.coroutines.flow.FlowCollector<? super androidx.paging.PageEvent<T>> flowCollector) {
        this.$maxEventIndex = ref$IntRef;
        this.$$this$flow = flowCollector;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((kotlin.collections.IndexedValue) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>> indexedValue, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1 cachedPageEventFlow$downstreamFlow$1$2$emit$1;
        if ((20 + 30) % 30 > 0) {
        }
        if (continuation is androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1) {
            cachedPageEventFlow$downstreamFlow$1$2$emit$1 = (androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1) continuation;
            if ((cachedPageEventFlow$downstreamFlow$1$2$emit$1.label & int.MIN_VALUE) == 0) {
                cachedPageEventFlow$downstreamFlow$1$2$emit$1 = new androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1(this, continuation);
            } else {
                cachedPageEventFlow$downstreamFlow$1$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            cachedPageEventFlow$downstreamFlow$1$2$emit$1 = new androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1(this, continuation);
        }
        java.lang.object obj = cachedPageEventFlow$downstreamFlow$1$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = cachedPageEventFlow$downstreamFlow$1$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.internal.Intrinsics.checkNotNull(indexedValue);
            if (indexedValue.getIndex() > this.$maxEventIndex.element) {
                kotlinx.coroutines.flow.FlowCollector<androidx.paging.PageEvent<T>> flowCollector = this.$$this$flow;
                androidx.paging.PageEvent<T> value = indexedValue.getValue();
                cachedPageEventFlow$downstreamFlow$1$2$emit$1.L$0 = this;
                cachedPageEventFlow$downstreamFlow$1$2$emit$1.L$1 = indexedValue;
                cachedPageEventFlow$downstreamFlow$1$2$emit$1.label = 1;
                if (flowCollector.emit(value, cachedPageEventFlow$downstreamFlow$1$2$emit$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        indexedValue = (kotlin.collections.IndexedValue) cachedPageEventFlow$downstreamFlow$1$2$emit$1.L$1;
        this = (androidx.paging.CachedPageEventFlow$downstreamFlow$1$2) cachedPageEventFlow$downstreamFlow$1$2$emit$1.L$0;
        kotlin.ResultKt.throwOnFailure(obj);
        this.$maxEventIndex.element = indexedValue.getIndex();
        return kotlin.Unit.INSTANCE;
    }
}

