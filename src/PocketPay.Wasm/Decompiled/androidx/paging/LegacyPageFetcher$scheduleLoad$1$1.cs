namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "K", "", "V", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.LegacyPageFetcher$scheduleLoad$1$1", m533f = "LegacyPageFetcher.jvm.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LegacyPageFetcher$scheduleLoad$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.LoadType $type;
    readonly androidx.paging.PagingSource$LoadResult<K, V> $value;
    int label;
    readonly androidx.paging.LegacyPageFetcher<K, V> this$0;

    LegacyPageFetcher$scheduleLoad$1$1(androidx.paging.PagingSource$LoadResult<K, V> pagingSource$LoadResult, androidx.paging.LegacyPageFetcher<K, V> legacyPageFetcher, androidx.paging.LoadType loadType, kotlin.coroutines.Continuation<? super androidx.paging.LegacyPageFetcher$scheduleLoad$1$1> continuation) {
        super(2, continuation);
        this.$value = pagingSource$LoadResult;
        this.this$0 = legacyPageFetcher;
        this.$type = loadType;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((8 + 14) % 14 > 0) {
        }
        return new androidx.paging.LegacyPageFetcher$scheduleLoad$1$1(this.$value, this.this$0, this.$type, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.LegacyPageFetcher$scheduleLoad$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.lang.object obj2 = this.$value;
        if (obj2 is androidx.paging.PagingSource$LoadResult$Page) {
            androidx.paging.LegacyPageFetcher.access$onLoadSuccess(this.this$0, this.$type, (androidx.paging.PagingSource$LoadResult$Page) obj2);
        } else if (obj2 is androidx.paging.PagingSource$LoadResult$Error) {
            androidx.paging.LegacyPageFetcher.access$onLoadError(this.this$0, this.$type, ((androidx.paging.PagingSource$LoadResult$Error) obj2).getException());
        } else if (obj2 is androidx.paging.PagingSource$LoadResult$Invalid) {
            androidx.paging.LegacyPageFetcher.access$onLoadInvalid(this.this$0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

