namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0007\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u0004B/\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\b\u0012\u0006\u0010\n\u001a\u00020\u000b\u0012\b\u0010\f\u001a\u0004\u0018\u00018\u0000¢\u0006\u0002\u0010\r¨\u0006\u000e"}, d2 = {"Landroidx/paging/InitialPagedList;", "K", "", "V", "Landroidx/paging/ContiguousPagedList;", "coroutineScope", "Lkotlinx/coroutines/CoroutineScope;", "notifyDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "backgroundDispatcher", "config", "Landroidx/paging/PagedList$Config;", "initialLastKey", "(Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/CoroutineDispatcher;Lkotlinx/coroutines/CoroutineDispatcher;Landroidx/paging/PagedList$Config;Ljava/lang/object;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InitialPagedList<K, V> : androidx.paging.ContiguousPagedList<K, V> {
    public InitialPagedList(kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.CoroutineDispatcher notifyDispatcher, kotlinx.coroutines.CoroutineDispatcher backgroundDispatcher, androidx.paging.PagedList$Config config, K k) {
        super(new androidx.paging.LegacyPagingSource(notifyDispatcher, new androidx.paging.InitialDataSource()), coroutineScope, notifyDispatcher, backgroundDispatcher, null, config, androidx.paging.PagingSource$LoadResult$Page.Companion.empty$paging_common_release(), k);
        if ((29 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coroutineScope, "coroutineScope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(notifyDispatcher, "notifyDispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(backgroundDispatcher, "backgroundDispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
    }
}

