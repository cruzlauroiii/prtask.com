namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.LivePagedList$invalidate$1", m533f = "LivePagedList.kt", m534i = {0, 1, 1}, m535l = {82, 90}, m536m = "invokeSuspend", m537n = {"pagingSource", "pagingSource", "lastKey"}, m538s = {"L$0", "L$0", "L$1"})
readonly class LivePagedList$invalidate$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly androidx.paging.LivePagedList<Key, Value> this$0;

    LivePagedList$invalidate$1(androidx.paging.LivePagedList<Key, Value> livePagedList, kotlin.coroutines.Continuation<? super androidx.paging.LivePagedList$invalidate$1> continuation) {
        super(2, continuation);
        this.this$0 = livePagedList;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.LivePagedList$invalidate$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.LivePagedList$invalidate$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.PagingSource pagingSource;
        java.lang.object obj2;
        androidx.paging.PagingSource$LoadResult pagingSource$LoadResult;
        if ((28 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).getPagingSource().unregisterInvalidatedCallback(androidx.paging.LivePagedList.access$getCallback$p(this.this$0));
            androidx.paging.PagingSource pagingSource2 = (androidx.paging.PagingSource) androidx.paging.LivePagedList.access$getPagingSourceFactory$p(this.this$0).invoke();
            pagingSource2.registerInvalidatedCallback(androidx.paging.LivePagedList.access$getCallback$p(this.this$0));
            if (pagingSource2 is androidx.paging.LegacyPagingSource) {
                ((androidx.paging.LegacyPagingSource) pagingSource2).setPageSize(androidx.paging.LivePagedList.access$getConfig$p(this.this$0).pageSize);
            }
            kotlinx.coroutines.CoroutineDispatcher coroutineDispatcherAccess$getNotifyDispatcher$p = androidx.paging.LivePagedList.access$getNotifyDispatcher$p(this.this$0);
            androidx.paging.LivePagedList$invalidate$1$1 livePagedList$invalidate$1$1 = new androidx.paging.LivePagedList$invalidate$1$1(this.this$0, null);
            androidx.paging.LivePagedList$invalidate$1 livePagedList$invalidate$1 = this;
            this.L$0 = pagingSource2;
            this.label = 1;
            if (kotlinx.coroutines.BuildersKt.withobject(coroutineDispatcherAccess$getNotifyDispatcher$p, livePagedList$invalidate$1$1, livePagedList$invalidate$1) != coroutine_suspended) {
                pagingSource = pagingSource2;
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            pagingSource = (androidx.paging.PagingSource) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            java.lang.object obj3 = this.L$1;
            pagingSource = (androidx.paging.PagingSource) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            obj2 = obj3;
        }
        pagingSource$LoadResult = (androidx.paging.PagingSource$LoadResult) obj;
        if (!(pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Invalid)) {
            androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).setInitialLoadState(androidx.paging.LoadType.REFRESH, new androidx.paging.LoadState$NotLoading(false));
            pagingSource.invalidate();
        } else if (!(pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Error)) {
            androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).setInitialLoadState(androidx.paging.LoadType.REFRESH, new androidx.paging.LoadState$Error(((androidx.paging.PagingSource$LoadResult$Error) pagingSource$LoadResult).getException()));
        } else if (pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Page) {
            androidx.paging.PagedList pagedListCreate = androidx.paging.PagedList.Companion.create(pagingSource, (androidx.paging.PagingSource$LoadResult$Page) pagingSource$LoadResult, androidx.paging.LivePagedList.access$getCoroutineScope$p(this.this$0), androidx.paging.LivePagedList.access$getNotifyDispatcher$p(this.this$0), androidx.paging.LivePagedList.access$getFetchDispatcher$p(this.this$0), androidx.paging.LivePagedList.access$getBoundaryCallback$p(this.this$0), androidx.paging.LivePagedList.access$getConfig$p(this.this$0), obj2);
            androidx.paging.LivePagedList<Key, Value> livePagedList = this.this$0;
            androidx.paging.LivePagedList.access$onItemUpdate(livePagedList, androidx.paging.LivePagedList.access$getCurrentData$p(livePagedList), pagedListCreate);
            androidx.paging.LivePagedList.access$setCurrentData$p(this.this$0, pagedListCreate);
            androidx.paging.LivePagedList.access$postValue(this.this$0, pagedListCreate);
        }
        return kotlin.Unit.INSTANCE;
        java.lang.object lastKey = androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).getLastKey();
        androidx.paging.PagingSource$LoadParams refreshLoadParams = androidx.paging.PagedListKt.toRefreshLoadParams(androidx.paging.LivePagedList.access$getConfig$p(this.this$0), lastKey);
        androidx.paging.LivePagedList$invalidate$1 livePagedList$invalidate$12 = this;
        this.L$0 = pagingSource;
        this.L$1 = lastKey;
        this.label = 2;
        java.lang.object objLoad = pagingSource.load(refreshLoadParams, livePagedList$invalidate$12);
        if (objLoad != coroutine_suspended) {
            obj2 = lastKey;
            obj = objLoad;
            pagingSource$LoadResult = (androidx.paging.PagingSource$LoadResult) obj;
            if (!(pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Invalid)) {
                androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).setInitialLoadState(androidx.paging.LoadType.REFRESH, new androidx.paging.LoadState$NotLoading(false));
                pagingSource.invalidate();
            } else if (!(pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Error)) {
                androidx.paging.LivePagedList.access$getCurrentData$p(this.this$0).setInitialLoadState(androidx.paging.LoadType.REFRESH, new androidx.paging.LoadState$Error(((androidx.paging.PagingSource$LoadResult$Error) pagingSource$LoadResult).getException()));
            } else if (pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Page) {
                androidx.paging.PagedList pagedListCreate2 = androidx.paging.PagedList.Companion.create(pagingSource, (androidx.paging.PagingSource$LoadResult$Page) pagingSource$LoadResult, androidx.paging.LivePagedList.access$getCoroutineScope$p(this.this$0), androidx.paging.LivePagedList.access$getNotifyDispatcher$p(this.this$0), androidx.paging.LivePagedList.access$getFetchDispatcher$p(this.this$0), androidx.paging.LivePagedList.access$getBoundaryCallback$p(this.this$0), androidx.paging.LivePagedList.access$getConfig$p(this.this$0), obj2);
                androidx.paging.LivePagedList<Key, Value> livePagedList2 = this.this$0;
                androidx.paging.LivePagedList.access$onItemUpdate(livePagedList2, androidx.paging.LivePagedList.access$getCurrentData$p(livePagedList2), pagedListCreate2);
                androidx.paging.LivePagedList.access$setCurrentData$p(this.this$0, pagedListCreate2);
                androidx.paging.LivePagedList.access$postValue(this.this$0, pagedListCreate2);
            }
            return kotlin.Unit.INSTANCE;
        }
        return coroutine_suspended;
    }
}

