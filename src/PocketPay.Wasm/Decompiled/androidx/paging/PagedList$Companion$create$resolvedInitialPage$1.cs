namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u0004\"\b\b\u0002\u0010\u0003*\u00020\u0004*\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/PagingSource$LoadResult$Page;", "K", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagedList$Companion$create$resolvedInitialPage$1", m533f = "PagedList.kt", m534i = {}, m535l = {178}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagedList$Companion$create$resolvedInitialPage$1<K, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult$Page<K, T>>, java.lang.object> {
    readonly androidx.paging.PagingSource<K, T> $pagingSource;
    readonly androidx.paging.PagingSource$LoadParams$Refresh<K> $params;
    int label;

    PagedList$Companion$create$resolvedInitialPage$1(androidx.paging.PagingSource<K, T> pagingSource, androidx.paging.PagingSource$LoadParams$Refresh<K> pagingSource$LoadParams$Refresh, kotlin.coroutines.Continuation<? super androidx.paging.PagedList$Companion$create$resolvedInitialPage$1> continuation) {
        super(2, continuation);
        this.$pagingSource = pagingSource;
        this.$params = pagingSource$LoadParams$Refresh;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.PagedList$Companion$create$resolvedInitialPage$1(this.$pagingSource, this.$params, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult$Page<K, T>> continuation) {
        return ((androidx.paging.PagedList$Companion$create$resolvedInitialPage$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.PagingSource<K, T> pagingSource = this.$pagingSource;
            androidx.paging.PagingSource$LoadParams$Refresh<K> pagingSource$LoadParams$Refresh = this.$params;
            androidx.paging.PagedList$Companion$create$resolvedInitialPage$1<K, T> pagedList$Companion$create$resolvedInitialPage$1 = this;
            this.label = 1;
            obj = pagingSource.load(pagingSource$LoadParams$Refresh, pagedList$Companion$create$resolvedInitialPage$1);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        androidx.paging.PagingSource$LoadResult pagingSource$LoadResult = (androidx.paging.PagingSource$LoadResult) obj;
        if (pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Page) {
            return (androidx.paging.PagingSource$LoadResult$Page) pagingSource$LoadResult;
        }
        if (pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Error) {
            throw ((androidx.paging.PagingSource$LoadResult$Error) pagingSource$LoadResult).getException();
        }
        if (pagingSource$LoadResult is androidx.paging.PagingSource$LoadResult$Invalid) {
            throw new java.lang.IllegalStateException("Failed to create PagedList. The provided PagingSource returned LoadResult.Invalid, but a LoadResult.Page was expected. To use a PagingSource which supports invalidation, use a PagedList builder that accepts a factory method for PagingSource or DataSource.Factory, such as LivePagedList.");
        }
        throw new kotlin.NoWhenBranchMatchedException();
    }
}

