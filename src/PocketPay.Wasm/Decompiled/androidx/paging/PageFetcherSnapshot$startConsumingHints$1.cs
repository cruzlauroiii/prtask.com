namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$startConsumingHints$1", m533f = "PageFetcherSnapshot.kt", m534i = {}, m535l = {220}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcherSnapshot$startConsumingHints$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$startConsumingHints$1(androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshot$startConsumingHints$1> continuation) {
        super(2, continuation);
        this.this$0 = pageFetcherSnapshot;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.PageFetcherSnapshot$startConsumingHints$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcherSnapshot$startConsumingHints$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((31 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow[] flowArr = new kotlinx.coroutines.flow.Flow[2];
            flowArr[0] = androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(this.this$0).hintFor(androidx.paging.LoadType.APPEND);
            flowArr[1] = androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(this.this$0).hintFor(androidx.paging.LoadType.PREPEND);
            kotlinx.coroutines.flow.Flow flowMerge = kotlinx.coroutines.flow.FlowKt.merge(flowArr);
            androidx.paging.PageFetcherSnapshot$startConsumingHints$1$jumpHint$1 pageFetcherSnapshot$startConsumingHints$1$jumpHint$1 = new androidx.paging.PageFetcherSnapshot$startConsumingHints$1$jumpHint$1(this.this$0, null);
            androidx.paging.PageFetcherSnapshot$startConsumingHints$1 pageFetcherSnapshot$startConsumingHints$1 = this;
            this.label = 1;
            obj = kotlinx.coroutines.flow.FlowKt.firstOrNull(flowMerge, pageFetcherSnapshot$startConsumingHints$1$jumpHint$1, pageFetcherSnapshot$startConsumingHints$1);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        androidx.paging.objectportHint viewportHint = (androidx.paging.objectportHint) obj;
        if (viewportHint is not null) {
            androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot = this.this$0;
            androidx.paging.PagingConsoleger pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
            if (pagingConsoleger.isConsolegable(3)) {
                pagingConsoleger.log(3, "Jump triggered on PagingSource " + pageFetcherSnapshot.getPagingSource$paging_common_release() + " by " + viewportHint, null);
            }
            androidx.paging.PageFetcherSnapshot.access$getJumpCallback$p(this.this$0).invoke();
        }
        return kotlin.Unit.INSTANCE;
    }
}

