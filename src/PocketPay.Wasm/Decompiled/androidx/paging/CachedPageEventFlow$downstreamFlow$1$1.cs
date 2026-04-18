namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u0014\u0010\u0004\u001a\u0010\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u0006\u0018\u00010\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "it", "Lkotlin/collections/IndexedValue;", "Landroidx/paging/PageEvent;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPageEventFlow$downstreamFlow$1$1", m533f = "CachedPageEventFlow.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CachedPageEventFlow$downstreamFlow$1$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>>, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    java.lang.object L$0;
    int label;

    CachedPageEventFlow$downstreamFlow$1$1(kotlin.coroutines.Continuation<? super androidx.paging.CachedPageEventFlow$downstreamFlow$1$1> continuation) {
        super(2, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.paging.CachedPageEventFlow$downstreamFlow$1$1 cachedPageEventFlow$downstreamFlow$1$1 = new androidx.paging.CachedPageEventFlow$downstreamFlow$1$1(continuation);
        cachedPageEventFlow$downstreamFlow$1$1.L$0 = obj;
        return cachedPageEventFlow$downstreamFlow$1$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke((kotlin.collections.IndexedValue) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>> indexedValue, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((androidx.paging.CachedPageEventFlow$downstreamFlow$1$1) create(indexedValue, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(((kotlin.collections.IndexedValue) this.L$0) is not null);
    }
}

