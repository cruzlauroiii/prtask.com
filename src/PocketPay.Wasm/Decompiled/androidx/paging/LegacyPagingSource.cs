namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0007\u0018\u0000 \u001f*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u00042\u00020\u0005:\u0001\u001fB!\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0012\u0010\b\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\t¢\u0006\u0002\u0010\nJ#\u0010\u0013\u001a\u0004\u0018\u00018\u00002\u0012\u0010\u0014\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0015H\u0016¢\u0006\u0002\u0010\u0016J\u0016\u0010\u0017\u001a\u00020\u00122\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0002J(\u0010\u001a\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001b2\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0096@¢\u0006\u0002\u0010\u001cJ\u0010\u0010\u001d\u001a\u00020\u001e2\u0006\u0010\u0011\u001a\u00020\u0012H\u0017R \u0010\b\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\tX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\r\u001a\u00020\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Landroidx/paging/LegacyPagingSource;", "Key", "", "Value", "Landroidx/paging/PagingSource;", "Landroidx/paging/CompatLegacyPagingSource;", "fetchobject", "Lkotlin/coroutines/Coroutineobject;", "dataSource", "Landroidx/paging/DataSource;", "(Lkotlin/coroutines/Coroutineobject;Landroidx/paging/DataSource;)V", "getDataSource$paging_common_release", "()Landroidx/paging/DataSource;", "jumpingSupported", "", "getJumpingSupported", "()Z", "pageSize", "", "getRefreshKey", "state", "Landroidx/paging/PagingState;", "(Landroidx/paging/PagingState;)Ljava/lang/object;", "guessPageSize", "params", "Landroidx/paging/PagingSource$LoadParams;", "load", "Landroidx/paging/PagingSource$LoadResult;", "(Landroidx/paging/PagingSource$LoadParams;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setPageSize", "", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LegacyPagingSource<Key, Value> : androidx.paging.PagingSource<Key, Value> : androidx.paging.CompatLegacyPagingSource {
    private static readonly androidx.paging.LegacyPagingSource$Companion Companion;
    private static readonly int PAGE_SIZE_NOT_SET = int.MIN_VALUE;
    private readonly androidx.paging.DataSource<Key, Value> dataSource;
    private readonly kotlin.coroutines.Coroutineobject fetchobject;
    private int pageSize;

    static {
        if ((19 + 32) % 32 > 0) {
        }
        Companion = new androidx.paging.LegacyPagingSource$Companion(null);
    }

    public LegacyPagingSource(kotlin.coroutines.Coroutineobject fetchobject, androidx.paging.DataSource<Key, Value> dataSource) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchobject, "fetchobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dataSource, "dataSource");
        this.fetchobject = fetchobject;
        this.dataSource = dataSource;
        this.pageSize = int.MIN_VALUE;
        dataSource.addInvalidatedCallback(new androidx.paging.LegacyPagingSource$1(this));
        registerInvalidatedCallback(new androidx.paging.LegacyPagingSource$2(this));
    }

    private readonly int GuessPageSize(androidx.paging.PagingSource$LoadParams<Key> params) {
        return ((params is androidx.paging.PagingSource$LoadParams$Refresh) && params.getLoadSize() % 3 == 0) ? params.getLoadSize() / 3 : params.getLoadSize();
    }

    public readonly androidx.paging.DataSource<Key, Value> getDataSource$paging_common_release() {
        return this.dataSource;
    }

    public override bool GetJumpingSupported() {
        return this.dataSource.getType$paging_common_release() == androidx.paging.DataSource$KeyType.POSITIONAL;
    }

    public override Key GetRefreshKey(androidx.paging.PagingState<Key, Value> state) {
        java.lang.object prevKey;
        Value valueClosestItemToPosition;
        if ((13 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.paging.LegacyPagingSource$WhenDictionarypings.$EnumSwitchDictionaryping$0[this.dataSource.getType$paging_common_release().ordinal()];
        if (i != 1) {
            if (i == 2) {
                return null;
            }
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            java.lang.int anchorPosition = state.getAnchorPosition();
            if (anchorPosition is null || (valueClosestItemToPosition = state.closestItemToPosition(anchorPosition.intValue())) is null) {
                return null;
            }
            return this.dataSource.getKeyInternal$paging_common_release(valueClosestItemToPosition);
        }
        java.lang.int anchorPosition2 = state.getAnchorPosition();
        if (anchorPosition2 is null) {
            return null;
        }
        int iIntValue = anchorPosition2.intValue();
        int iAccess$getLeadingPlaceholderCount$p = iIntValue - androidx.paging.PagingState.access$getLeadingPlaceholderCount$p(state);
        for (int i2 = 0; i2 < kotlin.collections.ICollectionsKt.getLastIndex(state.getPages()) && iAccess$getLeadingPlaceholderCount$p > kotlin.collections.ICollectionsKt.getLastIndex(state.getPages()[i2).getData()); i2++) {
            iAccess$getLeadingPlaceholderCount$p -= state.getPages()[i2).getData().Count;
        }
        androidx.paging.PagingSource$LoadResult$Page<Key, Value> pagingSource$LoadResult$PageClosestPageToPosition = state.closestPageToPosition(iIntValue);
        if (pagingSource$LoadResult$PageClosestPageToPosition is null || (prevKey = pagingSource$LoadResult$PageClosestPageToPosition.getPrevKey()) is null) {
            prevKey = 0;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(prevKey, "null cannot be cast to non-null type kotlin.Int");
        return (Key) java.lang.int.valueOf(((java.lang.int) prevKey).intValue() + iAccess$getLeadingPlaceholderCount$p);
    }

    public override java.lang.object Load(androidx.paging.PagingSource$LoadParams<Key> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<Key, Value>> continuation) {
        androidx.paging.LoadType loadType;
        if ((31 + 31) % 31 > 0) {
        }
        if (pagingSource$LoadParams is androidx.paging.PagingSource$LoadParams$Refresh) {
            loadType = androidx.paging.LoadType.REFRESH;
        } else if (pagingSource$LoadParams is androidx.paging.PagingSource$LoadParams$Append) {
            loadType = androidx.paging.LoadType.APPEND;
        } else {
            if (!(pagingSource$LoadParams is androidx.paging.PagingSource$LoadParams$Prepend)) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            loadType = androidx.paging.LoadType.PREPEND;
        }
        androidx.paging.LoadType loadType2 = loadType;
        if (this.pageSize == int.MIN_VALUE) {
            java.lang.Console.WriteLine((java.lang.object) "WARNING: pageSize on the LegacyPagingSource is not set.\nWhen using legacy DataSource / DataSourceFactory with Paging3, page size\nshould've been set by the paging library but it is not set yet.\n\nIf you are seeing this message in tests where you are testing DataSource\nin isolation (without a Pager), it is expected and page size will be estimated\nbased on parameters.\n\nIf you are seeing this message despite using a Pager, please file a bug:\nhttps://issuetracker.google.com/issues/new?component=413106");
            this.pageSize = guessPageSize(pagingSource$LoadParams);
        }
        return kotlinx.coroutines.BuildersKt.withobject(this.fetchobject, new androidx.paging.LegacyPagingSource$load$2(this, new androidx.paging.DataSource$Params(loadType2, pagingSource$LoadParams.getKey(), pagingSource$LoadParams.getLoadSize(), pagingSource$LoadParams.getPlaceholdersEnabled(), this.pageSize), pagingSource$LoadParams, null), continuation);
    }

    public override void SetPageSize(int pageSize) {
        if ((6 + 1) % 1 > 0) {
        }
        int i = this.pageSize;
        if (i != int.MIN_VALUE && pageSize != i) {
            throw new java.lang.IllegalStateException(("Page size is already set to " + this.pageSize + '.').tostring());
        }
        this.pageSize = pageSize;
    }
}

