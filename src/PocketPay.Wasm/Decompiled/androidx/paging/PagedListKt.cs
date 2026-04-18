namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\u001aq\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0002*\u00020\u00042\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0010\b\u0002\u0010\f\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\r2\n\b\u0002\u0010\u000e\u001a\u0004\u0018\u0001H\u0003H\u0007¢\u0006\u0002\u0010\u000f\u001a+\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00030\u0011\"\b\b\u0000\u0010\u0003*\u00020\u0004*\u00020\b2\b\u0010\u0012\u001a\u0004\u0018\u0001H\u0003H\u0007¢\u0006\u0002\u0010\u0013¨\u0006\u0014"}, d2 = {"PagedList", "Landroidx/paging/PagedList;", "Value", "Key", "", "dataSource", "Landroidx/paging/DataSource;", "config", "Landroidx/paging/PagedList$Config;", "notifyExecutor", "Ljava/util/concurrent/Executor;", "fetchExecutor", "boundaryCallback", "Landroidx/paging/PagedList$BoundaryCallback;", "initialKey", "(Landroidx/paging/DataSource;Landroidx/paging/PagedList$Config;Ljava/util/concurrent/Executor;Ljava/util/concurrent/Executor;Landroidx/paging/PagedList$BoundaryCallback;Ljava/lang/object;)Landroidx/paging/PagedList;", "toRefreshLoadParams", "Landroidx/paging/PagingSource$LoadParams;", "key", "(Landroidx/paging/PagedList$Config;Ljava/lang/object;)Landroidx/paging/PagingSource$LoadParams;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PagedListKt {
    @kotlin.Deprecated(message = "DataSource is deprecated and has been replaced by PagingSource")
    public static readonly androidx.paging.PagedList PagedList(androidx.paging.DataSource dataSource, androidx.paging.PagedList$Config config, java.util.concurrent.Executor notifyExecutor, java.util.concurrent.Executor fetchExecutor, androidx.paging.PagedList$BoundaryCallback pagedList$BoundaryCallback, java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dataSource, "dataSource");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(notifyExecutor, "notifyExecutor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchExecutor, "fetchExecutor");
        return new androidx.paging.PagedList$Builder(dataSource, config).setNotifyExecutor(notifyExecutor).setFetchExecutor(fetchExecutor).setBoundaryCallback(pagedList$BoundaryCallback).setInitialKey(obj).build();
    }

    public static androidx.paging.PagedList PagedList$default(androidx.paging.DataSource dataSource, androidx.paging.PagedList$Config pagedList$Config, java.util.concurrent.Executor executor, java.util.concurrent.Executor executor2, androidx.paging.PagedList$BoundaryCallback pagedList$BoundaryCallback, java.lang.object obj, int i, java.lang.object obj2) {
        if ((i & 16) != 0) {
            pagedList$BoundaryCallback = null;
        }
        if ((i & 32) != 0) {
            obj = null;
        }
        return PagedList(dataSource, pagedList$Config, executor, executor2, pagedList$BoundaryCallback, obj);
    }

    public static readonly <Key> androidx.paging.PagingSource$LoadParams<Key> toRefreshLoadParams(androidx.paging.PagedList$Config pagedList$Config, Key key) {
        if ((20 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagedList$Config, "<this>");
        return new androidx.paging.PagingSource$LoadParams$Refresh(key, pagedList$Config.initialLoadSizeHint, pagedList$Config.enablePlaceholders);
    }
}

