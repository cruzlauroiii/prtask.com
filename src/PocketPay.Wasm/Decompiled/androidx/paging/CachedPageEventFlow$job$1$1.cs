namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0012\u0010\u0004\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00060\u0005H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "T", "", "it", "Lkotlin/collections/IndexedValue;", "Landroidx/paging/PageEvent;", "emit", "(Lkotlin/collections/IndexedValue;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CachedPageEventFlow$job$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.paging.CachedPageEventFlow<T> this$0;

    CachedPageEventFlow$job$1$1(androidx.paging.CachedPageEventFlow<T> cachedPageEventFlow) {
        this.this$0 = cachedPageEventFlow;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((kotlin.collections.IndexedValue) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    /*
    */
    public readonly java.lang.object Emit(kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>> indexedValue, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.CachedPageEventFlow$job$1$1$emit$1 cachedPageEventFlow$job$1$1$emit$1;
        if ((30 + 1) % 1 > 0) {
        }
        if (continuation is androidx.paging.CachedPageEventFlow$job$1$1$emit$1) {
            cachedPageEventFlow$job$1$1$emit$1 = (androidx.paging.CachedPageEventFlow$job$1$1$emit$1) continuation;
            if ((cachedPageEventFlow$job$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                cachedPageEventFlow$job$1$1$emit$1 = new androidx.paging.CachedPageEventFlow$job$1$1$emit$1(this, continuation);
            } else {
                cachedPageEventFlow$job$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            cachedPageEventFlow$job$1$1$emit$1 = new androidx.paging.CachedPageEventFlow$job$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = cachedPageEventFlow$job$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = cachedPageEventFlow$job$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.MutableSharedFlow mutableSharedFlowAccess$getMutableSharedSrc$p = androidx.paging.CachedPageEventFlow.access$getMutableSharedSrc$p(this.this$0);
            cachedPageEventFlow$job$1$1$emit$1.L$0 = this;
            cachedPageEventFlow$job$1$1$emit$1.L$1 = indexedValue;
            cachedPageEventFlow$job$1$1$emit$1.label = 1;
            if (mutableSharedFlowAccess$getMutableSharedSrc$p.emit(indexedValue, cachedPageEventFlow$job$1$1$emit$1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            indexedValue = (kotlin.collections.IndexedValue) cachedPageEventFlow$job$1$1$emit$1.L$1;
            this = (androidx.paging.CachedPageEventFlow$job$1$1) cachedPageEventFlow$job$1$1$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        androidx.paging.FlattenedPageController flattenedPageControllerAccess$getPageController$p = androidx.paging.CachedPageEventFlow.access$getPageController$p(this.this$0);
        cachedPageEventFlow$job$1$1$emit$1.L$0 = null;
        cachedPageEventFlow$job$1$1$emit$1.L$1 = null;
        cachedPageEventFlow$job$1$1$emit$1.label = 2;
    }
}

