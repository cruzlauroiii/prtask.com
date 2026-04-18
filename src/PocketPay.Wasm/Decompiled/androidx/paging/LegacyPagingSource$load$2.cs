namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u0004*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource$LoadResult$Page;", "Key", "Value", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.LegacyPagingSource$load$2", m533f = "LegacyPagingSource.jvm.kt", m534i = {}, m535l = {110}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LegacyPagingSource$load$2<Key, Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult$Page<Key, Value>>, java.lang.object> {
    readonly androidx.paging.DataSource$Params<Key> $dataSourceParams;
    readonly androidx.paging.PagingSource$LoadParams<Key> $params;
    int label;
    readonly androidx.paging.LegacyPagingSource<Key, Value> this$0;

    LegacyPagingSource$load$2(androidx.paging.LegacyPagingSource<Key, Value> legacyPagingSource, androidx.paging.DataSource$Params<Key> dataSource$Params, androidx.paging.PagingSource$LoadParams<Key> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.paging.LegacyPagingSource$load$2> continuation) {
        super(2, continuation);
        this.this$0 = legacyPagingSource;
        this.$dataSourceParams = dataSource$Params;
        this.$params = pagingSource$LoadParams;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((25 + 13) % 13 > 0) {
        }
        return new androidx.paging.LegacyPagingSource$load$2(this.this$0, this.$dataSourceParams, this.$params, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult$Page<Key, Value>> continuation) {
        return ((androidx.paging.LegacyPagingSource$load$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((16 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.DataSource<Key, Value> dataSource$paging_common_release = this.this$0.getDataSource$paging_common_release();
            androidx.paging.DataSource$Params<Key> dataSource$Params = this.$dataSourceParams;
            androidx.paging.LegacyPagingSource$load$2<Key, Value> legacyPagingSource$load$2 = this;
            this.label = 1;
            obj = dataSource$paging_common_release.load$paging_common_release(dataSource$Params, legacyPagingSource$load$2);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        androidx.paging.PagingSource$LoadParams<Key> pagingSource$LoadParams = this.$params;
        androidx.paging.DataSource$BaseResult dataSource$BaseResult = (androidx.paging.DataSource$BaseResult) obj;
        return new androidx.paging.PagingSource$LoadResult$Page(dataSource$BaseResult.data, (dataSource$BaseResult.data.Count == 0 && (pagingSource$LoadParams is androidx.paging.PagingSource$LoadParams$Prepend)) ? null : dataSource$BaseResult.getPrevKey(), (dataSource$BaseResult.data.Count == 0 && (pagingSource$LoadParams is androidx.paging.PagingSource$LoadParams$Append)) ? null : dataSource$BaseResult.getNextKey(), dataSource$BaseResult.getItemsBefore(), dataSource$BaseResult.getItemsAfter());
    }
}

