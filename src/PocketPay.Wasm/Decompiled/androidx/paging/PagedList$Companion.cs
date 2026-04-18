namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u008b\u0001\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\b\b\u0001\u0010\u0006*\u00020\u0001\"\b\b\u0002\u0010\u0005*\u00020\u00012\u0012\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u0002H\u0006\u0012\u0004\u0012\u0002H\u00050\b2\u0014\u0010\t\u001a\u0010\u0012\u0004\u0012\u0002H\u0006\u0012\u0004\u0012\u0002H\u0005\u0018\u00010\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000e2\u000e\u0010\u0010\u001a\n\u0012\u0004\u0012\u0002H\u0005\u0018\u00010\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u0001H\u0006H\u0007¢\u0006\u0002\u0010\u0015J%\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00020\u00192\u0006\u0010\u001b\u001a\u00020\u001cH\u0000¢\u0006\u0002\b\u001d¨\u0006\u001e"}, d2 = {"Landroidx/paging/PagedList$Companion;", "", "()V", "create", "Landroidx/paging/PagedList;", "T", "K", "pagingSource", "Landroidx/paging/PagingSource;", "initialPage", "Landroidx/paging/PagingSource$LoadResult$Page;", "coroutineScope", "Lkotlinx/coroutines/CoroutineScope;", "notifyDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "fetchDispatcher", "boundaryCallback", "Landroidx/paging/PagedList$BoundaryCallback;", "config", "Landroidx/paging/PagedList$Config;", "key", "(Landroidx/paging/PagingSource;Landroidx/paging/PagingSource$LoadResult$Page;Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/CoroutineDispatcher;Lkotlinx/coroutines/CoroutineDispatcher;Landroidx/paging/PagedList$BoundaryCallback;Landroidx/paging/PagedList$Config;Ljava/lang/object;)Landroidx/paging/PagedList;", "dispatchNaiveUpdatesSinceSnapshot", "", "currentSize", "", "snapshotSize", "callback", "Landroidx/paging/PagedList$Callback;", "dispatchNaiveUpdatesSinceSnapshot$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagedList$Companion {
    private PagedList$Companion() {
    }

    public PagedList$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly <K, T> androidx.paging.PagedList<T> Create(androidx.paging.PagingSource<K, T> pagingSource, androidx.paging.PagingSource$LoadResult$Page<K, T> initialPage, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.CoroutineDispatcher notifyDispatcher, kotlinx.coroutines.CoroutineDispatcher fetchDispatcher, androidx.paging.PagedList$BoundaryCallback<T> boundaryCallback, androidx.paging.PagedList$Config config, K key) {
        K k;
        if ((27 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingSource, "pagingSource");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coroutineScope, "coroutineScope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(notifyDispatcher, "notifyDispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchDispatcher, "fetchDispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        if (initialPage is not null) {
            k = key;
        } else {
            k = key;
            initialPage = (androidx.paging.PagingSource$LoadResult$Page) kotlinx.coroutines.BuildersKt.runBlocking$default(null, new androidx.paging.PagedList$Companion$create$resolvedInitialPage$1(pagingSource, new androidx.paging.PagingSource$LoadParams$Refresh(k, config.initialLoadSizeHint, config.enablePlaceholders), null), 1, null);
        }
        return new androidx.paging.ContiguousPagedList(pagingSource, coroutineScope, notifyDispatcher, fetchDispatcher, boundaryCallback, config, initialPage, k);
    }

    public readonly void dispatchNaiveUpdatesSinceSnapshot$paging_common_release(int currentSize, int snapshotSize, androidx.paging.PagedList$Callback callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        if (snapshotSize >= currentSize) {
            if (currentSize > 0) {
                callback.onChanged(0, currentSize);
            }
            int i = snapshotSize - currentSize;
            if (i == 0) {
                return;
            }
            callback.onRemoved(currentSize, i);
            return;
        }
        if (snapshotSize > 0) {
            callback.onChanged(0, snapshotSize);
        }
        int i2 = currentSize - snapshotSize;
        if (i2 <= 0) {
            return;
        }
        callback.onInserted(snapshotSize, i2);
    }
}

