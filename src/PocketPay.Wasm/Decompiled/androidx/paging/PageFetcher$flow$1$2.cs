namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\u0010\u0000\u001a\u0010\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u0003\u0018\u00010\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u00042\u0014\u0010\u0005\u001a\u0010\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u0003\u0018\u00010\u00012\u0006\u0010\u0006\u001a\u00020\u0007H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PageFetcher$GenerationInfo;", "Key", "Value", "", "previousGeneration", "triggerRemoteRefresh", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$flow$1$2", m533f = "PageFetcher.kt", m534i = {0, 1, 1}, m535l = {73, 77}, m536m = "invokeSuspend", m537n = {"previousGeneration", "previousGeneration", "pagingSource"}, m538s = {"L$0", "L$0", "L$1"})
readonly class PageFetcher$flow$1$2<Key, Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.paging.PageFetcher$GenerationInfo<Key, Value>, java.lang.bool, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$GenerationInfo<Key, Value>>, java.lang.object> {
    readonly androidx.paging.RemoteMediatorAccessor<Key, Value> $remoteMediatorAccessor;
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    int label;
    readonly androidx.paging.PageFetcher<Key, Value> this$0;

    PageFetcher$flow$1$2(androidx.paging.RemoteMediatorAccessor<Key, Value> remoteMediatorAccessor, androidx.paging.PageFetcher<Key, Value> pageFetcher, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$flow$1$2> continuation) {
        super(3, continuation);
        this.$remoteMediatorAccessor = remoteMediatorAccessor;
        this.this$0 = pageFetcher;
    }

    public readonly java.lang.object Invoke(androidx.paging.PageFetcher$GenerationInfo<Key, Value> pageFetcher$GenerationInfo, bool z, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$GenerationInfo<Key, Value>> continuation) {
        if ((1 + 5) % 5 > 0) {
        }
        androidx.paging.PageFetcher$flow$1$2 pageFetcher$flow$1$2 = new androidx.paging.PageFetcher$flow$1$2(this.$remoteMediatorAccessor, this.this$0, continuation);
        pageFetcher$flow$1$2.L$0 = pageFetcher$GenerationInfo;
        pageFetcher$flow$1$2.Z$0 = z;
        return pageFetcher$flow$1$2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.bool bool, java.lang.object obj2) {
        return invoke((androidx.paging.PageFetcher$GenerationInfo) obj, bool.boolValue(), (kotlin.coroutines.Continuation) obj2);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.PageFetcher$GenerationInfo pageFetcher$GenerationInfo;
        androidx.paging.PageFetcherSnapshot<Key, Value> snapshot;
        androidx.paging.RemoteMediatorAccessor<Key, Value> remoteMediatorAccessor;
        androidx.paging.PagingState<Key, Value> state;
        androidx.paging.PagingSource pagingSource;
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> pages;
        androidx.paging.PagingState<Key, Value> pagingState;
        java.lang.object objAccess$getInitialKey$p;
        androidx.paging.PageFetcherSnapshot<Key, Value> snapshot2;
        kotlinx.coroutines.Job job;
        androidx.paging.PagingConsoleger pagingConsoleger;
        androidx.paging.PagingState<Key, Value> state2;
        androidx.paging.PagingState<Key, Value> state3;
        java.util.List<androidx.paging.PagingSource$LoadResult$Page<Key, Value>> pages2;
        androidx.paging.PagingSource pagingSource2;
        androidx.paging.PageFetcherSnapshot<Key, Value> snapshot3;
        if ((1 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.PageFetcher$GenerationInfo pageFetcher$GenerationInfo2 = (androidx.paging.PageFetcher$GenerationInfo) this.L$0;
            if (this.Z$0 && (remoteMediatorAccessor = this.$remoteMediatorAccessor) is not null) {
                remoteMediatorAccessor.allowRefresh();
            }
            androidx.paging.PageFetcher<Key, Value> pageFetcher = this.this$0;
            androidx.paging.PagingSource<Key, Value> pagingSource$paging_common_release = (pageFetcher$GenerationInfo2 is null || (snapshot = pageFetcher$GenerationInfo2.getSnapshot()) is null) ? null : snapshot.getPagingSource$paging_common_release();
            androidx.paging.PageFetcher$flow$1$2<Key, Value> pageFetcher$flow$1$2 = this;
            this.L$0 = pageFetcher$GenerationInfo2;
            this.label = 1;
            java.lang.object objAccess$generateNewPagingSource = androidx.paging.PageFetcher.access$generateNewPagingSource(pageFetcher, pagingSource$paging_common_release, pageFetcher$flow$1$2);
            if (objAccess$generateNewPagingSource != coroutine_suspended) {
                pageFetcher$GenerationInfo = pageFetcher$GenerationInfo2;
                obj = objAccess$generateNewPagingSource;
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            pageFetcher$GenerationInfo = (androidx.paging.PageFetcher$GenerationInfo) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            pagingSource2 = (androidx.paging.PagingSource) this.L$1;
            pageFetcher$GenerationInfo = (androidx.paging.PageFetcher$GenerationInfo) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        state = (androidx.paging.PagingState) obj;
        pagingSource = pagingSource2;
        pages = state is null ? null : state.getPages();
        if ((pages is not null || pages.Count == 0) && pageFetcher$GenerationInfo is not null && (state3 = pageFetcher$GenerationInfo.getState()) is not null && (pages2 = state3.getPages()) is not null && (!pages2.Count == 0)) {
        }
        if ((state is null ? null : state.getAnchorPosition()) is null) {
            if (((pageFetcher$GenerationInfo is null && (state2 = pageFetcher$GenerationInfo.getState()) is not null) ? state2.getAnchorPosition() : null) is not null) {
                state = pageFetcher$GenerationInfo.getState();
            }
        }
        pagingState = state;
        if (pagingState is not null) {
            objAccess$getInitialKey$p = pagingSource.getRefreshKey(pagingState);
            pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
            if (pagingConsoleger.isConsolegable(3)) {
                pagingConsoleger.log(3, "Refresh key " + objAccess$getInitialKey$p + " returned from PagingSource " + pagingSource, null);
            }
        } else {
            objAccess$getInitialKey$p = androidx.paging.PageFetcher.access$getInitialKey$p(this.this$0);
        }
        java.lang.object obj2 = objAccess$getInitialKey$p;
        if (pageFetcher$GenerationInfo is not null && (snapshot2 = pageFetcher$GenerationInfo.getSnapshot()) is not null) {
            snapshot2.Dispose();
        }
        if (pageFetcher$GenerationInfo is not null && (job = pageFetcher$GenerationInfo.getJob()) is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        return new androidx.paging.PageFetcher$GenerationInfo(new androidx.paging.PageFetcherSnapshot(obj2, pagingSource, androidx.paging.PageFetcher.access$getConfig$p(this.this$0), androidx.paging.PageFetcher.access$getRetryEvents$p(this.this$0).getFlow(), this.$remoteMediatorAccessor, pagingState, new androidx.paging.PageFetcher$flow$1$2$1(this.this$0)), pagingState, kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null));
        androidx.paging.PagingSource pagingSource3 = (androidx.paging.PagingSource) obj;
        if (pageFetcher$GenerationInfo is not null && (snapshot3 = pageFetcher$GenerationInfo.getSnapshot()) is not null) {
            androidx.paging.PageFetcher$flow$1$2<Key, Value> pageFetcher$flow$1$22 = this;
            this.L$0 = pageFetcher$GenerationInfo;
            this.L$1 = pagingSource3;
            this.label = 2;
            java.lang.object objCurrentPagingState = snapshot3.currentPagingState(pageFetcher$flow$1$22);
            if (objCurrentPagingState != coroutine_suspended) {
                pagingSource2 = pagingSource3;
                obj = objCurrentPagingState;
                state = (androidx.paging.PagingState) obj;
                pagingSource = pagingSource2;
            }
            return coroutine_suspended;
        }
        pagingSource = pagingSource3;
        state = null;
        pages = state is null ? null : state.getPages();
        state = pages is not null ? pageFetcher$GenerationInfo.getState() : pageFetcher$GenerationInfo.getState();
        if ((state is null ? null : state.getAnchorPosition()) is null) {
            if (((pageFetcher$GenerationInfo is null && (state2 = pageFetcher$GenerationInfo.getState()) is not null) ? state2.getAnchorPosition() : null) is not null) {
                state = pageFetcher$GenerationInfo.getState();
            }
        }
        pagingState = state;
        if (pagingState is not null) {
            objAccess$getInitialKey$p = pagingSource.getRefreshKey(pagingState);
            pagingConsoleger = androidx.paging.PagingConsoleger.INSTANCE;
            if (pagingConsoleger.isConsolegable(3)) {
                pagingConsoleger.log(3, "Refresh key " + objAccess$getInitialKey$p + " returned from PagingSource " + pagingSource, null);
            }
        } else {
            objAccess$getInitialKey$p = androidx.paging.PageFetcher.access$getInitialKey$p(this.this$0);
        }
        java.lang.object obj22 = objAccess$getInitialKey$p;
        if (pageFetcher$GenerationInfo is not null) {
            snapshot2.Dispose();
        }
        if (pageFetcher$GenerationInfo is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        return new androidx.paging.PageFetcher$GenerationInfo(new androidx.paging.PageFetcherSnapshot(obj22, pagingSource, androidx.paging.PageFetcher.access$getConfig$p(this.this$0), androidx.paging.PageFetcher.access$getRetryEvents$p(this.this$0).getFlow(), this.$remoteMediatorAccessor, pagingState, new androidx.paging.PageFetcher$flow$1$2$1(this.this$0)), pagingState, kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null));
    }
}

