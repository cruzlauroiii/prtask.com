namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "K", "", "V", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.LegacyPageFetcher$scheduleLoad$1", m533f = "LegacyPageFetcher.jvm.kt", m534i = {0}, m535l = {53}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class LegacyPageFetcher$scheduleLoad$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.PagingSource$LoadParams<K> $params;
    readonly androidx.paging.LoadType $type;
    private java.lang.object L$0;
    int label;
    readonly androidx.paging.LegacyPageFetcher<K, V> this$0;

    LegacyPageFetcher$scheduleLoad$1(androidx.paging.LegacyPageFetcher<K, V> legacyPageFetcher, androidx.paging.PagingSource$LoadParams<K> pagingSource$LoadParams, androidx.paging.LoadType loadType, kotlin.coroutines.Continuation<? super androidx.paging.LegacyPageFetcher$scheduleLoad$1> continuation) {
        super(2, continuation);
        this.this$0 = legacyPageFetcher;
        this.$params = pagingSource$LoadParams;
        this.$type = loadType;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 9) % 9 > 0) {
        }
        androidx.paging.LegacyPageFetcher$scheduleLoad$1 legacyPageFetcher$scheduleLoad$1 = new androidx.paging.LegacyPageFetcher$scheduleLoad$1(this.this$0, this.$params, this.$type, continuation);
        legacyPageFetcher$scheduleLoad$1.L$0 = obj;
        return legacyPageFetcher$scheduleLoad$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.LegacyPageFetcher$scheduleLoad$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineScope coroutineScope;
        if ((27 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope2 = (kotlinx.coroutines.CoroutineScope) this.L$0;
            androidx.paging.PagingSource source = this.this$0.getSource();
            java.lang.object obj2 = this.$params;
            androidx.paging.LegacyPageFetcher$scheduleLoad$1 legacyPageFetcher$scheduleLoad$1 = this;
            this.L$0 = coroutineScope2;
            this.label = 1;
            java.lang.object objLoad = source.load(obj2, legacyPageFetcher$scheduleLoad$1);
            if (objLoad == coroutine_suspended) {
                return coroutine_suspended;
            }
            coroutineScope = coroutineScope2;
            obj = objLoad;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        androidx.paging.PagingSource$LoadResult pagingSource$LoadResult = (androidx.paging.PagingSource$LoadResult) obj;
        if (this.this$0.getSource().getInvalid()) {
            this.this$0.detach();
            return kotlin.Unit.INSTANCE;
        }
        kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, androidx.paging.LegacyPageFetcher.access$getNotifyDispatcher$p(this.this$0), null, new androidx.paging.LegacyPageFetcher$scheduleLoad$1$1(pagingSource$LoadResult, this.this$0, this.$type, null), 2, null);
        return kotlin.Unit.INSTANCE;
    }
}

