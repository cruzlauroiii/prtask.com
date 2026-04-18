namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0006H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PageFetcher$flow$1$3$downstreamFlow$1<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.PageEvent<Value>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;

    PageFetcher$flow$1$3$downstreamFlow$1(kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1 pageFetcher$flow$1$3$downstreamFlow$1 = new androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1(continuation);
        pageFetcher$flow$1$3$downstreamFlow$1.L$0 = obj;
        return pageFetcher$flow$1$3$downstreamFlow$1;
    }

    public readonly java.lang.object Invoke(androidx.paging.PageEvent<Value> pageEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PageFetcher$flow$1$3$downstreamFlow$1) create(pageEvent, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.PageEvent) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((8 + 4) % 4 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.PageEvent pageEvent = (androidx.paging.PageEvent) this.L$0;
        androidx.paging.PagingConsoleger pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
        if (pagingConsoleger.isConsolegable(2)) {
            pagingConsoleger.log(2, "Sent " + pageEvent, null);
        }
        return kotlin.Unit.INSTANCE;
    }
}

