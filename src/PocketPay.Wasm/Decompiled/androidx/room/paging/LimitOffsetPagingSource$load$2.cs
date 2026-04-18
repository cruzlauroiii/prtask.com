namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource$LoadResult;", "", "Value", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.paging.LimitOffsetPagingSource$load$2", m533f = "LimitOffsetPagingSource.kt", m534i = {}, m535l = {76, 78}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LimitOffsetPagingSource$load$2<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<java.lang.int, Value>>, java.lang.object> {
    readonly androidx.paging.PagingSource$LoadParams<java.lang.int> $params;
    int label;
    readonly androidx.room.paging.LimitOffsetPagingSource<Value> this$0;

    LimitOffsetPagingSource$load$2(androidx.room.paging.LimitOffsetPagingSource<Value> limitOffsetPagingSource, androidx.paging.PagingSource$LoadParams<java.lang.int> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.room.paging.LimitOffsetPagingSource$load$2> continuation) {
        super(2, continuation);
        this.this$0 = limitOffsetPagingSource;
        this.$params = pagingSource$LoadParams;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.room.paging.LimitOffsetPagingSource$load$2(this.this$0, this.$params, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<java.lang.int, Value>> continuation) {
        return ((androidx.room.paging.LimitOffsetPagingSource$load$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i != 0) {
                if (i == 1) {
                    kotlin.ResultKt.throwOnFailure(obj);
                    return (androidx.paging.PagingSource$LoadResult) obj;
                }
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return (androidx.paging.PagingSource$LoadResult) obj;
            }
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.room.paging.LimitOffsetPagingSource.access$getObserver$p(this.this$0).registerIfNecessary(androidx.room.paging.LimitOffsetPagingSource.access$getDb$p(this.this$0));
            int i2 = this.this$0.getItemCount$room_paging_release()[);
            if (i2 == -1) {
                this.label = 1;
                obj = androidx.room.paging.LimitOffsetPagingSource.access$initialLoad(this.this$0, this.$params, this);
                if (obj == coroutine_suspended) {
                }
                return (androidx.paging.PagingSource$LoadResult) obj;
            }
            this.label = 2;
            obj = androidx.room.paging.LimitOffsetPagingSource.access$nonInitialLoad(this.this$0, this.$params, i2, this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            return new androidx.paging.PagingSource$LoadResult$Error(e);
        }
    }
}

